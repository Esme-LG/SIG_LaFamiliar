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

namespace SIG_LaFamiliar.Forms.Estrategico
{
    public partial class FormInicioEstrategico : MaterialForm
    {
        public FormInicioEstrategico()
        {
            InitializeComponent();

            Proveedor.AddStyle(this);
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

        private void FormInicioEstrategico_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1 && !Proveedor.formMain.Visible) Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
