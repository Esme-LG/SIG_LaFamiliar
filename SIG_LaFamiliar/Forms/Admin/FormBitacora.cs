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
using SIG_LaFamiliar.Clases;
using SIG_LaFamiliar.Datos;

namespace SIG_LaFamiliar.Forms.Admin
{
    public partial class FormBitacora : MaterialForm
    {
        public FormBitacora()
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Proveedor.formMain.Show();
            this.Close();
        }

        private void FormInicioAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1 && !Proveedor.formMain.Visible) Application.Exit();
        }

        private void FormBitacora_Load(object sender, EventArgs e)
        {
            ComboBoxItem defaultItem = new ComboBoxItem();
            defaultItem.Text = "Todos";
            defaultItem.Value = 0;

            cmbUsuario.Items.Add(defaultItem);

            cmbUsuario.SelectedItem = defaultItem;

            Usuario[] usuarios = DatosUsuarios.obtenerUsuarios();

            foreach (Usuario usuario in usuarios)
            {
                ComboBoxItem item = new ComboBoxItem();

                item.Text = usuario.nombre;
                item.Value = usuario.id;

                cmbUsuario.Items.Add(item);
            }

            DatosBitacora.registrar("501");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tblBitacora.DataSource = DatosBitacora.obtenerBitacora((int)(cmbUsuario.SelectedItem as ComboBoxItem).Value);
            int ancho = tblBitacora.Width;

            tblBitacora.Columns["Fecha"].Width = ancho * 30 / 100;
            tblBitacora.Columns["Usuario"].Width = ancho * 35 / 100;
            tblBitacora.Columns["Politica"].Width = ancho * 35 / 100;
        }

    }
}
