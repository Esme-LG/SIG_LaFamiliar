using SIG_LaFamiliar.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_LaFamiliar.Datos
{
    class DatosUsuarios
    {
        public static Usuario Login(string cuenta, string password)
        {
            Usuario usuario = null;

            string query = "select U.UsuarioID, U.Nombre, U.Cuenta, R.Nombre, dbo.password_validate(U.Contrasenia, @password) Valido from Usuario U inner join Rol R on U.RolID = R.RolID where U.Cuenta = @cuenta";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("password", password), 
                new SqlParameter("cuenta", cuenta)
            };

            SqlDataReader dataReader = DBReader.getDataReader(query, parameters);

            while (dataReader.Read())
            {
                bool valido = dataReader.GetBoolean(4);
                if (valido)
                {
                    usuario = new Usuario();
                    usuario.id = dataReader.GetInt32(0);
                    usuario.nombre = dataReader.GetString(1);
                    usuario.cuenta = dataReader.GetString(2);
                    usuario.rol = dataReader.GetString(3);
                }
            }

            dataReader.Close();

            return usuario;
        }

        public static Rol[] obtenerRoles()
        {
            List<Rol> roles = new List<Rol>();

            string query = "select * from Rol";
            SqlDataReader dataReader = DBReader.getDataReader(query);

            while (dataReader.Read())
            {
                Rol rol = new Rol();

                rol.id = dataReader.GetInt32(0);
                rol.nombre = dataReader.GetString(1);

                roles.Add(rol);
            }

            dataReader.Close();

            return roles.ToArray();
        }

        public static Usuario[] obtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            string query = "select U.UsuarioID, U.Cuenta, U.Nombre, R.Nombre from Usuario U inner join Rol R on U.RolID = R.RolID";
            SqlDataReader dataReader = DBReader.getDataReader(query);

            while (dataReader.Read())
            {
                Usuario usuario = new Usuario();

                usuario.id = dataReader.GetInt32(0);
                usuario.cuenta = dataReader.GetString(1);
                usuario.nombre = dataReader.GetString(2);
                usuario.rol = dataReader.GetString(3);

                usuarios.Add(usuario);
            }

            dataReader.Close();

            return usuarios.ToArray();
        }

        public static Usuario obtenerUsuario(int id)
        {
            Usuario usuario = null;

            string query = "select U.UsuarioID, U.Cuenta, U.Nombre, R.Nombre from Usuario U inner join Rol R on U.RolID = R.RolID where U.UsuarioID = @id";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("id", id)
            };
            
            SqlDataReader dataReader = DBReader.getDataReader(query, parameters);

            while (dataReader.Read())
            {
                usuario = new Usuario();

                usuario.id = dataReader.GetInt32(0);
                usuario.cuenta = dataReader.GetString(1);
                usuario.nombre = dataReader.GetString(2);
                usuario.rol = dataReader.GetString(3);
            }

            dataReader.Close();

            return usuario;
        }

        public static DataTable dtUsuarios()
        {
            string query = "select U.UsuarioID, U.Cuenta as 'Usuario', U.Nombre, R.Nombre as 'Rol' from Usuario U inner join Rol R on U.RolID = R.RolID";
            return DBReader.getDataTable(query);
        }

        public static void crearUsuario(string cuenta, string nombre, string contra, int idRol)
        {
            string query = "insert into Usuario(Cuenta, Nombre, Contrasenia, RolID) values (@cuenta, @nombre, @contra, @rol)";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("cuenta", cuenta),
                new SqlParameter("nombre", nombre),
                new SqlParameter("contra", contra),
                new SqlParameter("rol", idRol)
            };

            DBReader.execute(query, parameters);
        }

        public static void modificarUsuario(int idUsuario, string nombre, int idRol, string contra)
        {
            string query = "update Usuario set Nombre = @nombre, RolID = @rol";
            
            if(contra != "") query += ", Contrasenia = @contra";
            query += " where UsuarioID = @id";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("id", idUsuario),
                new SqlParameter("nombre", nombre),
                new SqlParameter("rol", idRol)
            };

            if(contra != "") parameters.Add(new SqlParameter("contra", contra));

            DBReader.execute(query, parameters);
        }

        public static void eliminarUsuario(int idUsuario)
        {
            string query = "delete from Usuario where UsuarioID = @id";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("id", idUsuario)
            };

            DBReader.execute(query, parameters);
        }
    }
}
