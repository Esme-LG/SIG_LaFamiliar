using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace SIG_LaFamiliar
{
    public partial class FormLogin : MaterialForm
    {
        public FormLogin()
        {
            InitializeComponent();

            // Crear un administrador de tema material y agregar el form a manejar (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configurar esquema de color
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.LightGreen600, Primary.LightGreen800,
                Primary.LightGreen200, Accent.LightGreen200,
                TextShade.WHITE
            );

            Proveedor.formMain = this;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Form form;

            switch (txtNombre.Text)
            {
                case "t":
                    form = new Forms.Tactico.FormInicioTactico();
                    break;
                case "e":
                    form = new Forms.Estrategico.FormInicioEstrategico();
                    break;
                default:
                    form = new Forms.Admin.FormInicioAdmin();
                    break;
            }

            form.Show();
            this.Hide();
        }
    }
}
