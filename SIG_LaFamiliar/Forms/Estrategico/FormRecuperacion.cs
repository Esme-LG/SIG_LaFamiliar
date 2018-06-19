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

namespace SIG_LaFamiliar.Forms.Estrategico
{
    public partial class FormRecuperacion : MaterialForm
    {
        public FormRecuperacion()
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

        private void btnMorosos_Click(object sender, EventArgs e)
        {
            Form form = new Forms.Estrategico.FormMorososCuota();
            form.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Proveedor.formMain.Show();
            this.Close();
        }

        private void FormRecuperacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1 && !Proveedor.formMain.Visible) Application.Exit();
        }
    }
}
