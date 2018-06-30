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
using SIG_LaFamiliar.Datos;

namespace SIG_LaFamiliar.Forms.Admin
{
    public partial class FormUsuarios : MaterialForm
    {
        public FormUsuarios()
        {
            InitializeComponent();

            Proveedor.AddStyle(this);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Admin.FormInicioAdmin();
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

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            tblUsuarios.DataSource = DatosUsuarios.dtUsuarios();
            tblUsuarios.Columns["UsuarioID"].Visible = false;

            int ancho = tblUsuarios.Width;

            tblUsuarios.Columns["Usuario"].Width = ancho * 25 / 100;
            tblUsuarios.Columns["Nombre"].Width = ancho * 50 / 100;
            tblUsuarios.Columns["Rol"].Width = ancho * 25 / 100;

            DatosBitacora.registrar("401");
        }

        private void tblUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int id = (int)tblUsuarios.Rows[e.RowIndex].Cells["UsuarioID"].Value;
                Form form = new FormUsuario(id);
                form.Show();
                this.Close();
            }   
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Form form = new FormUsuario();
            form.Show();
            this.Close();
        }
    }
}
