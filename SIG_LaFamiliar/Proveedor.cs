using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIG_LaFamiliar
{
    class Proveedor
    {
        private static Form f;
        private static SqlConnection c;


        // Guarda el FormMain para poder mostrarlo y cerrarlo desde cualquier ventana. 
        public static Form formMain
        {
            get
            {
                return f;
            }
            set
            {
                f = value;
            }
        }

        // Crea, abre y retorna una conexión para todos los procesos. 
        public static SqlConnection connection
        {
            get
            {
                if (c == null)
                {
                    //c = new SqlConnection(SIG_LaFamiliar.Properties.Settings.Default.La_FamiliarConnectionString);
                }
                if (c.State == System.Data.ConnectionState.Closed)
                {
                    c.Open();
                }

                return c;
            }
        }
    }
}
