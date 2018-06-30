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
    class DatosTacticos
    {
        public static DataTable morososVigentes(bool B, bool C, bool D, bool F)
        {
            string query = "SELECT A.Codigo, A.Nombre, MAX(C.Categoria) 'Categoria', SUM(C.ValorMora) 'Mora', SUM(C.Saldo) 'Saldo' FROM Asociado A INNER JOIN Credito C ON A.AsociadoID = C.AsociadoID  WHERE C.TieneMora = 1 and C.Categoria in ";

            if (B && C && D && F)
            {
                query += "('F', 'C', 'D', 'B')";
            }

            else if (B && C && D)
            {
                query += "('B', 'C', 'D')";
            }

            else if (B && C && F)
            {
                query += "('B', 'C', 'F')";
            }

            else if (F && C && D)
            {
                query += "('F', 'C', 'D')";
            }

            else if (B && C)
            {
                query += "('B', 'C')";
            }

            else if (B && D)
            {
                query += "('B', 'D')";
            }

            else if (B && F)
            {
                query += "('B', 'F')";
            }

            else if (C && D)
            {
                query += "('C', 'D')";
            }

            else if (C && F)
            {
                query += "('C', 'F')";
            }

            else if (D && F)
            {
                query += "('D', 'F')";
            }

            else if (B)
            {
                query += "('B')";
            }

            else if (C)
            {
                query += "('C')";
            }

            else if (D)
            {
                query += "('D')";
            }

            else if (F)
            {
                query += "('F')";
            }

            query += " group by A.Nombre, A.Codigo";

            return DBReader.getDataTable(query);
        }

        public static DataTable mosososHistoricos(int idPeriodo)
        {
            string query = "SELECT A.Codigo 'Asociado', A.Nombre, C.Codigo 'Credito', C.TieneMora 'Mora Actual', C.Saldo 'Saldo', CH.ValorMora 'Mora' FROM Asociado A INNER JOIN Credito C ON A.AsociadoID = C.AsociadoID INNER JOIN CreditoHistorico CH ON C.CreditoID = CH.CreditoID WHERE CH.TieneMora = 1 AND CH.PeriodoID = " + idPeriodo.ToString();
            return DBReader.getDataTable(query);
        }

        public static Credito obtenerCredito(string codigo)
        {
            Credito credito = null; 

            string query = "SELECT A.Codigo, A.Nombre, C.Cuota, C.Interes, C.Saldo, C.ValorMora FROM Asociado A INNER JOIN Credito C ON A.AsociadoID = C.AsociadoID WHERE C.Codigo = @codigo";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("codigo", codigo)
            };

            SqlDataReader dataReader = DBReader.getDataReader(query, parameters);

            while (dataReader.Read())
            {
                credito = new Credito();
                credito.codigo = dataReader.GetString(0);
                credito.asociado = dataReader.GetString(1);
                credito.cuota = dataReader.GetDecimal(2);
                credito.interes = dataReader.GetDecimal(3);
                credito.saldo = dataReader.GetDecimal(4);
                credito.mora = dataReader.GetDecimal(5);
            }

            dataReader.Close();

            return credito;
        }

        public static DataTable mososidadPorTipoCredito(int idPeriodo)
        {
            string query = "SELECT C.Tipo, COUNT(CH.CrediHistoricoID) 'Cantidad', SUM(CH.ValorMora) 'Monto' FROM Credito C INNER JOIN CreditoHistorico CH ON C.CreditoID = CH.CreditoID WHERE CH.TieneMora = 1 AND CH.PeriodoID = " + idPeriodo.ToString() + " GROUP BY C.Tipo";
            return DBReader.getDataTable(query);
        }

        public static DataTable asociadosCategoria(bool A, bool B, bool C, bool D, bool F)
        {
            string query = "SELECT A.Codigo, A.Nombre, MAX(C.Categoria) 'Categoria' FROM Asociado A INNER JOIN Credito C ON A.AsociadoID = C.AsociadoID where C.Categoria in ";

            if (B && C && D && F)
            {
                query += "('F', 'C', 'D', 'B')";
            }

            else if (B && C && D)
            {
                query += "('B', 'C', 'D')";
            }

            else if (B && C && F)
            {
                query += "('B', 'C', 'F')";
            }

            else if (F && C && D)
            {
                query += "('F', 'C', 'D')";
            }

            else if (B && C)
            {
                query += "('B', 'C')";
            }

            else if (B && D)
            {
                query += "('B', 'D')";
            }

            else if (B && F)
            {
                query += "('B', 'F')";
            }

            else if (C && D)
            {
                query += "('C', 'D')";
            }

            else if (C && F)
            {
                query += "('C', 'F')";
            }

            else if (D && F)
            {
                query += "('D', 'F')";
            }

            else if (B)
            {
                query += "('B')";
            }

            else if (C)
            {
                query += "('C')";
            }

            else if (D)
            {
                query += "('D')";
            }

            else if (F)
            {
                query += "('F')";
            }

            query += " group by A.Nombre, A.Codigo";

            return DBReader.getDataTable(query);
        }

        public static DataTable creditosCompletados(bool nuevo)
        {
            string query;

            if(nuevo) query = "SELECT C.Codigo, A.Nombre, (SELECT MAX(P.Fecha) from Pago P WHERE P.CreditoID = C.CreditoID) 'Fecha', C.NuevoPlan FROM Asociado A INNER JOIN Credito C ON A.AsociadoID = C.AsociadoID WHERE C.Saldo < 500";
            else query = "SELECT C.Codigo, A.Nombre, (SELECT MAX(P.Fecha) from Pago P WHERE P.CreditoID = C.CreditoID) 'Fecha', C.NuevoPlan FROM Asociado A INNER JOIN Credito C ON A.AsociadoID = C.AsociadoID WHERE C.Saldo < 500 and C.NuevoPlan = 1";

            return DBReader.getDataTable(query);
        }
    }
}
