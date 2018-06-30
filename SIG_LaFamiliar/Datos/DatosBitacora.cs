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
    class DatosBitacora
    {
        public static DataTable obtenerBitacora(int idUsuario = 0)
        {
            string query = "select B.Fecha, U.Nombre as Usuario, P.Nombre as Politica from Bitacora B inner join Usuario U on B.UsuarioID = U.UsuarioID inner join Politica P on B.PoliticaID = P.PoliticaID";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (idUsuario > 0)
            {
                query += " where B.UsuarioID = @id";
                parameters.Add(new SqlParameter("id", idUsuario));
            }

            query += " order by Fecha desc";

            return DBReader.getDataTable(query, parameters);
        }

        public static void registrar(string codigo)
        {
            string query = "insert into Bitacora(UsuarioID, PoliticaID) values (@idUsuario, (select PoliticaID from Politica where Codigo = @codigo))";
            
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("idUsuario", Proveedor.usuario.id),
                new SqlParameter("codigo", codigo)
            };

            DBReader.execute(query, parameters);
        }
    }
}
