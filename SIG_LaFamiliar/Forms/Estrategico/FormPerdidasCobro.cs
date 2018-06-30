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

namespace SIG_LaFamiliar.Forms.Estrategico
{
    public partial class FormPerdidasCobro : MaterialForm
    {
        public FormPerdidasCobro()
        {
            InitializeComponent();

            Proveedor.AddStyle(this);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Estrategico.FormInicioEstrategico();
            form.Show();
            this.Close();
        }

        private void btnIndice_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Estrategico.FormIndice();
            form.Show();
            this.Close();
        }

        private void btnPerdidasAsociados_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Estrategico.FormPerdidasAsociados();
            form.Show();
            this.Close();
        }

        private void btnMorosos_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Estrategico.FormMorososCuota();
            form.Show();
            this.Close();
        }

        private void btnRecuperacion_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Estrategico.FormRecuperacion();
            form.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Proveedor.formMain.Show();
            this.Close();
        }

        private void FormPerdidasCobro_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1 && !Proveedor.formMain.Visible) Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tblResultado.DataSource = DatosEstrategicos.perdidasFaltaCobro(dtpInicio.Value.Month + 44, dtpFinal.Value.Month + 44);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            Reportes.Reportes.ExcelDG(tblResultado, "Pérdidas por falta de cobro");
            formEspera.Close();
        }

        private void btnWordDoc_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            Reportes.Reportes.docGeneralEstrategico(tblResultado, "Pérdidas por falta de cobro", dtpInicio.Value.Month + 44 + " " + dtpFinal.Value.Month + 44, Proveedor.usuario.nombre, 00, "word");

            formEspera.Close();
        }

        private void btnPDFDoc_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            Reportes.Reportes.docGeneralEstrategico(tblResultado, "Pérdidas por falta de cobro", dtpInicio.Value.Month + 44 +" "+ dtpFinal.Value.Month + 44, Proveedor.usuario.nombre, 00, "pdf");
            formEspera.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            Reportes.Reportes.docGeneralEstrategico(tblResultado, "Pérdidas por falta de cobro", "Junio - 2014", "Juan", 123, "print");
            formEspera.Close();
        }
    }
}
