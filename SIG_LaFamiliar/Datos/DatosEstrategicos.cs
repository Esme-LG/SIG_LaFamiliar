using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_LaFamiliar.Datos
{
    class DatosEstrategicos
    {
        public static DataTable indiceMorosidad(int idInicio, int idFin)
        {
            string query = "SELECT P.PeriodoID, SUM(CH.Saldo) 'Saldo', SUM(CASE WHEN CH.TieneMora = 1 THEN CH.Saldo ELSE 0 END) 'SaldoMora' FROM CreditoHistorico CH INNER JOIN Periodo P ON CH.PeriodoID = P.PeriodoID WHERE P.PeriodoID >= " + idInicio.ToString() + " AND P.PeriodoID <= " + idFin.ToString() + " GROUP BY P.PeriodoID";
            return DBReader.getDataTable(query);
        }

        public static DataTable perdidasFaltaCobro(int idInicio, int idFin)
        {
            string query = "SELECT Pe.PeriodoID, C.Cuota, (SELECT MAX(Pa.Fecha) FROM Pago Pa WHERE Pa.CreditoID = C.CreditoID AND Pa.Fecha < EOMONTH(DATEFROMPARTS(Pe.Anio, Pe.Mes, 1))) 'UltimoPago' FROM CreditoHistorico CH INNER JOIN Periodo Pe ON CH.PeriodoID = Pe.PeriodoID INNER JOIN Credito C ON C.CreditoID = CH.CreditoID WHERE Pe.PeriodoID >= " + idInicio.ToString() + " AND Pe.PeriodoID <= " + idFin.ToString();
            return DBReader.getDataTable(query);
        }

        public static DataTable perdidasAsociados(int idPeriodo)
        {
            string query = "SELECT A.Codigo 'AsociadoCod', A.Nombre, C.Codigo 'CreditoCod', CH.ValorMora FROM Asociado A INNER JOIN Credito C ON A.AsociadoID = C.AsociadoID INNER JOIN CreditoHistorico CH ON C.CreditoID = CH.CreditoID INNER JOIN Periodo P ON CH.PeriodoID = P.PeriodoID WHERE CH.TieneMora = 1 AND P.PeriodoID = " + idPeriodo.ToString();
            return DBReader.getDataTable(query);
        }

        public static DataTable morosidadCuota(int idInicio, int idFin)
        {
            string query = "SELECT P.PeriodoID, COUNT(CASE WHEN C.Cuota <= 25 THEN 1 ELSE null END) 'Cant0', COUNT(CASE WHEN C.Cuota > 25 AND C.Cuota <= 50 THEN 1 ELSE null END) 'Cant25', COUNT(CASE WHEN C.Cuota > 50 AND C.Cuota <= 75 THEN 1 ELSE null END) 'Cant50', COUNT(CASE WHEN C.Cuota > 75 AND C.Cuota <= 100 THEN 1 ELSE null END) 'Cant75', COUNT(CASE WHEN C.Cuota > 100 AND C.Cuota <= 125 THEN 1 ELSE null END) 'Cant100',  COUNT(CASE WHEN C.Cuota > 125 THEN 1 ELSE null END) 'Cant125' FROM Credito C INNER JOIN CreditoHistorico CH ON C.CreditoID = CH.CreditoID INNER JOIN Periodo P ON CH.PeriodoID = P.PeriodoID WHERE CH.TieneMora = 1 AND P.PeriodoID >= " + idInicio.ToString() + " AND P.PeriodoID <= " + idFin.ToString() + " GROUP BY P.PeriodoID";
            return DBReader.getDataTable(query);
        }

        public static DataTable recuperacion(int idInicio, int idFin)
        {
            string query = "SELECT C.CreditoID, P.Monto FROM  Credito C INNER JOIN Pago P ON C.CreditoID = P.CreditoID WHERE C.NuevoPlan = 1 AND MONTH(P.Fecha) >= (SELECT mes FROM Periodo WHERE PeriodoID = " + idInicio.ToString() + ") AND MONTH(P.Fecha) <= (SELECT mes FROM Periodo WHERE PeriodoID = " + idFin.ToString() + ") AND YEAR(P.Fecha) >= (SELECT anio FROM Periodo WHERE PeriodoID = " + idInicio.ToString() + ") AND YEAR(P.Fecha) <= (SELECT anio FROM Periodo WHERE PeriodoID = " + idFin.ToString() + ")";
            return DBReader.getDataTable(query);
        }
    }
}
