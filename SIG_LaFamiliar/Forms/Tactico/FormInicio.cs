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

namespace SIG_LaFamiliar.Forms.Tactico
{
    public partial class frmInicioTactico : MaterialForm
    {
        public frmInicioTactico()
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

            pnlOpciones.Visible = false;
        }

        private void btnMorosos_MouseEnter(object sender, EventArgs e)
        {
            pnlOpciones.Visible = true;
        }

        private void pnlOpciones_MouseLeave(object sender, EventArgs e)
        {
            pnlOpciones.Visible = false;
        }

        private void pnlOpciones_MouseEnter(object sender, EventArgs e)
        {
            pnlOpciones.Visible = true; 
        }

        private void btnVigentes_MouseEnter(object sender, EventArgs e)
        {
            pnlOpciones.Visible = true;
        }

        private void btnHistoricos_MouseEnter(object sender, EventArgs e)
        {
            pnlOpciones.Visible = true;
        }

        private void btnPorTipoCredito_MouseEnter(object sender, EventArgs e)
        {
            pnlOpciones.Visible = true;
        }
    }
}
