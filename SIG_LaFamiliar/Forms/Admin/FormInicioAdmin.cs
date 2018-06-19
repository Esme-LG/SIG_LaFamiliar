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
    public partial class FormInicioAdmin : MaterialForm
    {
        public FormInicioAdmin()
        {
            InitializeComponent();

            Proveedor.AddStyle(this);

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Admin.FormUsuarios();
            form.Show();
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Admin.FormUsuario();
            form.Show();
            this.Close();
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Admin.FormBitacora();
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
