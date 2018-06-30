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
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using SIG_LaFamiliar.Datos;

namespace SIG_LaFamiliar.Forms.Tactico
{
    public partial class FormMorososVigentes : MaterialForm
    {
        public FormMorososVigentes()
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

        private void FormMorososVigentes_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1 && !Proveedor.formMain.Visible) Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(!ckbCategoriaB.Checked &&  !ckbCategoriaC.Checked && !ckbCategoriaD.Checked && !ckbCategoriaF.Checked)
            {
                MessageBox.Show("Selecciona una o más categorías", "Error en el ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tblResultado.DataSource = DatosTacticos.morososVigentes(ckbCategoriaB.Checked, ckbCategoriaC.Checked, ckbCategoriaD.Checked, ckbCategoriaF.Checked);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            Reportes.Reportes.ExcelDG(tblResultado, "Morosos vigentes");
            formEspera.Close();
        }

        private void btnWordDoc_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            Reportes.Reportes.morososVigentes(tblResultado, "27/06/2018", Proveedor.usuario.nombre, 00, "word", "23", "Marvin", 34, 23, 23, 12, "A, B");
            formEspera.Close();
        }

        private void btnPDFDoc_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            Reportes.Reportes.morososVigentes(tblResultado, "27/06/2018", Proveedor.usuario.nombre, 00, "pdf", "23", "Marvin", 34, 23, 23, 12, "A, B");
            formEspera.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            Reportes.Reportes.morososVigentes(tblResultado, "asdad", Proveedor.usuario.nombre, 4324, "print", "23", "Marvin", 34, 23, 23, 12, "A, B");
            formEspera.Close();
        }
    }
}
