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
    public partial class FormUsuario : MaterialForm
    {
        private int idUsuario;

        public FormUsuario(int id = 0)
        {
            InitializeComponent();

            Proveedor.AddStyle(this);

            idUsuario = id;

            if (idUsuario != 0)
            {
                lblTitulo.Text = "Modificar usuario";
                btnEliminar.Visible = true;
            }
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

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            Rol[] roles = DatosUsuarios.obtenerRoles();

            foreach (Rol rol in roles)
            {
                ComboBoxItem item = new ComboBoxItem();

                item.Text = rol.nombre;
                item.Value = rol.id;

                cmbRol.Items.Add(item);
            }

            if (idUsuario != 0)
            {
                Usuario usuario = DatosUsuarios.obtenerUsuario(idUsuario);

                txtNombre.Text = usuario.nombre;
                txtCorreo.Text = usuario.cuenta;
                
                ComboBoxItem selectedItem = null;
                foreach (ComboBoxItem item in cmbRol.Items)
                {
                    if (item.Text == usuario.rol) selectedItem = item;
                }

                cmbRol.SelectedItem = selectedItem;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCorreo.Text == "" || cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese los datos del usuario", "Ha omitido datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (idUsuario != 0)
                {
                    DatosUsuarios.modificarUsuario(idUsuario, txtNombre.Text, (int)(cmbRol.SelectedItem as ComboBoxItem).Value, txtContra.Text);
                    DatosBitacora.registrar("403");

                    Form form = new FormUsuarios();
                    form.Show();

                    MessageBox.Show(form, "Usuario modificado", "Éxito en la operación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    this.Close();
                }
                else if (txtContra.Text != "")
                {
                    DatosUsuarios.crearUsuario(txtCorreo.Text, txtNombre.Text, txtContra.Text, (int)(cmbRol.SelectedItem as ComboBoxItem).Value);
                    DatosBitacora.registrar("402");

                    Form form = new FormUsuarios();
                    form.Show();

                    MessageBox.Show(form, "Usuario creado", "Éxito en la operación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ingrese los datos del usuario", "Ha omitido datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Elimiar usuario?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DatosUsuarios.eliminarUsuario(idUsuario);
                DatosBitacora.registrar("404");

                Form form = new FormUsuarios();
                form.Show();

                MessageBox.Show(form, "Usuario eliminado", "Éxito en la operación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form form = new FormUsuarios();
            form.Show();
            this.Close();
        }

    }
}
