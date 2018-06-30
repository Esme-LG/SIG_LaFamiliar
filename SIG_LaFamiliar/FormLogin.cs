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
using SIG_LaFamiliar.Clases;

namespace SIG_LaFamiliar
{
    public partial class FormLogin : MaterialForm
    {
        public FormLogin()
        {
            InitializeComponent();

            Proveedor.AddStyle(this);
            Proveedor.formMain = this;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtContra.Text == "")
            {
                MessageBox.Show("Ingrese su cuenta y contraseña", "Ha omitido datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Usuario usuario = DatosUsuarios.Login(txtNombre.Text, txtContra.Text);

                if (usuario == null)
                {
                    MessageBox.Show("No ha ingresado un nombre de usuario y contraseña válidos.", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Proveedor.usuario = usuario;

                    DatosBitacora.registrar("301");

                    Form form;
                    switch (usuario.rol.ElementAt(0))
                    {
                        case 'T':
                            form = new Forms.Tactico.FormInicioTactico();
                            Proveedor.switchConnection("app");
                            break;
                        case 'E':
                            form = new Forms.Estrategico.FormInicioEstrategico();
                            Proveedor.switchConnection("app");
                            break;
                        default:
                            form = new Forms.Admin.FormInicioAdmin();
                            break;
                    }

                    txtContra.Text = "";
                    txtNombre.Text = "";

                    form.Show();
                    this.Hide();
                }
            }
            
        }
    }
}
