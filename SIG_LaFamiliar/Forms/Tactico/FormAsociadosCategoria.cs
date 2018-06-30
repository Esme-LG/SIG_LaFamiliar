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
    public partial class FormAsociadosCategoria : MaterialForm
    {
        public FormAsociadosCategoria()
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

        private void btnProyeccion_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Tactico.FormProyeccion();
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

        private void FormAsociadosCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1 && !Proveedor.formMain.Visible) Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tblResultado.DataSource = DatosTacticos.asociadosCategoria(ckbOpcionA.Checked, ckbOpcionB.Checked, ckbOpcionC.Checked, ckbOpcionD.Checked, ckbOpcionF.Checked);
        }
    
        private void btnExcel_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            Reportes.Reportes.ExcelDG(tblResultado, "Asociados por categoría");
            formEspera.Close();
        }

        private void btnWordDoc_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            Reportes.Reportes.asociadosCategoria(tblResultado, "27/06/2018", Proveedor.usuario.nombre, 23423, "word", "23", "123", "324");
            formEspera.Close();
        }

        private void btnPDFDoc_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show(); 

            Reportes.Reportes.asociadosCategoria(tblResultado, "27/06/2018", Proveedor.usuario.nombre, 23423, "pdf", "23", "123", "324");
            formEspera.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            Reportes.Reportes.asociadosCategoria(tblResultado, "asdasd", Proveedor.usuario.nombre, 23423, "print", "23", "123", "324");
            formEspera.Close();
        }


    }
}
