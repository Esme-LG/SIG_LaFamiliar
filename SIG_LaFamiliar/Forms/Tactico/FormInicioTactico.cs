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

namespace SIG_LaFamiliar.Forms.Tactico
{
    public partial class FormInicioTactico : MaterialForm
    {
        public FormInicioTactico()
        {
            InitializeComponent();

            // Crear un administrador de tema material y agregar el form a manejar (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configurar esquema de color
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.LightGreen600, Primary.LightGreen800,
                Primary.LightGreen200, Accent.LightGreen200,
                TextShade.WHITE
            );

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

        private void FormInicioTactico_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1 && !Proveedor.formMain.Visible) Application.Exit();
        }
        
    }
}
