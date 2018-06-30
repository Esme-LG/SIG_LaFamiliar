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

namespace SIG_LaFamiliar.Forms.Tactico
{
    public partial class FormMorososCreditos : MaterialForm
    {
        public FormMorososCreditos()
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

        private void btnProyeccion_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Tactico.FormProyeccion();
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

        private void FormMorososCreditos_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1 && !Proveedor.formMain.Visible) Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tblResultado.DataSource = DatosTacticos.mososidadPorTipoCredito(dtpFecha.Value.Month + 46);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            Reportes.Reportes.ExcelDG(tblResultado, "Morosos por tipo de crédito");
            formEspera.Close();
        }

        private void btnWordDoc_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            Reportes.Reportes.morosidadTipo(tblResultado, "Morosidad por tipo de crédito", dtpFecha.Value.Month + 46+"", Proveedor.usuario.nombre, 00, "word");
            formEspera.Close();
        }

        private void btnPDFDoc_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            Reportes.Reportes.morosidadTipo(tblResultado, "Morosidad por tipo de crédito", dtpFecha.Value.Month + 46 + "", Proveedor.usuario.nombre, 00, "pdf");
            formEspera.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            Reportes.Reportes.morosidadTipo(tblResultado, "Morosidad por tipo de crédito", "asdasd", Proveedor.usuario.nombre, 123123, "print");
            formEspera.Close();
        }

    }
}
