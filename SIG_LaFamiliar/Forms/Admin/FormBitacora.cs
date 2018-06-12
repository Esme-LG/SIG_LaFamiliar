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

namespace SIG_LaFamiliar.Forms.Admin
{
    public partial class FormBitacora : MaterialForm
    {
        public FormBitacora()
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

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Admin.FormInicioAdmin();
            form.Show();
            this.Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Admin.FormUsuarios();
            form.Show();
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Admin.FormNuevoUsuario();
            form.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Proveedor.formMain.Show();
            this.Close();
        }

        private void FormInicioAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1 && !Proveedor.formMain.Visible) Application.Exit();
        }

    }
}
