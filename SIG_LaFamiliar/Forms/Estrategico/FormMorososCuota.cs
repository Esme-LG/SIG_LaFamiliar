﻿using System;
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
    public partial class FormMorososCuota : MaterialForm
    {
        public FormMorososCuota()
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

        private void btnPerdidas_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Estrategico.FormPerdidasCobro();
            form.Show();
            this.Close();
        }

        private void btnPerdidasAsociados_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Estrategico.FormPerdidasAsociados();
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

        private void FormMorososCuota_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1 && !Proveedor.formMain.Visible) Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tblResultado.DataSource = DatosEstrategicos.morosidadCuota(dtpInicio.Value.Month + 44, dtpFinal.Value.Month + 44);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            Reportes.Reportes.ExcelDG(tblResultado, "Morosos por cuota");
            formEspera.Close();
        }

        private void btnWordDoc_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            Reportes.Reportes.docGeneralEstrategico(tblResultado, "Morosos por cuota", dtpInicio.Value.Month + 44 + " " + dtpFinal.Value.Month + 44, Proveedor.usuario.nombre, 123, "word");
            formEspera.Close();
        }

        private void btnPDFDoc_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            Reportes.Reportes.docGeneralEstrategico(tblResultado, "Morosos por cuota", dtpInicio.Value.Month + 44+" "+ dtpFinal.Value.Month + 44, Proveedor.usuario.nombre, 123, "pdf");
            formEspera.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Form formEspera = new FormEspera();
            formEspera.Show();

            Reportes.Reportes.docGeneralEstrategico(tblResultado, "Morosos por cuota", "Junio - 2014", "Juan", 123, "print");
            formEspera.Close();
        }
    }
}
