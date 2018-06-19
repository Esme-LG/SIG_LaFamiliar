using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace SIG_LaFamiliar
{
    class Proveedor
    {
        private static Form f;
        private static SqlConnection c;
        private static MaterialSkinManager m;


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

        public static MaterialSkinManager MaterialManager
        {
            get
            {
                if (m == null)
                {
                    m = MaterialSkinManager.Instance;
                    m.Theme = MaterialSkinManager.Themes.LIGHT;

                    // Configurar esquema de color
                    m.ColorScheme = new ColorScheme(
                        Primary.LightGreen600, Primary.LightGreen800,
                        Primary.LightGreen200, Accent.LightGreen200,
                        TextShade.WHITE
                    );
                }

                return m;
            }
        }

        public static void AddStyle(MaterialForm form)
        {
            // Crear un administrador de tema material y agregar el form a manejar
            MaterialManager.AddFormToManage(form);
        }
    }
}
