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

namespace SIG_LaFamiliar.Forms.Tactico
{
    public partial class FormProyeccion : MaterialForm
    {
        public FormProyeccion()
        {
            InitializeComponent();

            Proveedor.AddStyle(this);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Tactico.FormInicioTactico();
            form.Show();
            this.Close();
        }

        private void btnMorososVigentes_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Tactico.FormMorososVigentes();
            form.Show();
            this.Close();
        }

        private void btnMorososHistoricos_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Tactico.FormMorososHistorico();
            form.Show();
            this.Close();
        }

        private void btnMorososTipo_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Tactico.FormMorososCreditos();
            form.Show();
            this.Close();
        }

        private void btnAsociados_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Tactico.FormAsociadosCategoria();
            form.Show();
            this.Close();
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Tactico.FormCreditosCompletados();
            form.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Proveedor.formMain.Show();
            this.Close();
        }

        private void FormProyeccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1 && !Proveedor.formMain.Visible) Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCredito.Text == "" || (nudCuota.Value == 0 && nudPlazo.Value == 0))
            {
                MessageBox.Show("Ingrese todos los datos solicitados", "Error en el ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Credito credito = DatosTacticos.obtenerCredito(txtCredito.Text);

                if(credito == null) MessageBox.Show("No se encontró un crédito con ese código", "Error en la búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    lblAsociado.Text = credito.asociado + ", " + credito.codigo;
                    lblMora.Text = "$" + credito.mora.ToString();
                    lblCuotaActual.Text = "$" + credito.cuota.ToString();
                    lblPagosActual.Text = ((int)(credito.saldo / credito.cuota)).ToString();

                    if (nudPlazo.Value != 0)
                    {
                        lblPagosNuevo.Text = nudPlazo.Value.ToString();
                        lblCuotaNueva.Text = "$" + (credito.saldo / nudPlazo.Value).ToString("0.00");
                    }

                    if (nudCuota.Value != 0)
                    {
                        lblCuotaNueva.Text = nudCuota.Value.ToString();
                        lblPagosNuevo.Text = ((int)(credito.saldo / nudCuota.Value)).ToString();
                    }
                }
            }
        }

        private void rdbCuota_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCuota.Checked)
            {
                nudCuota.Enabled = true;
                nudPlazo.Enabled = false;
                nudPlazo.Value = 0;
            }
        }

        private void rdbPlazo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPlazo.Checked)
            {
                nudCuota.Enabled = false;
                nudCuota.Value = 0;
                nudPlazo.Enabled = true;
            }
        }
    }
}
