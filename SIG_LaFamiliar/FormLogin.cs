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
            Form form;

            switch (txtNombre.Text)
            {
                case "t":
                    form = new Forms.Tactico.FormInicioTactico();
                    break;
                case "e":
                    form = new Forms.Estrategico.FormInicioEstrategico();
                    break;
                default:
                    form = new Forms.Admin.FormInicioAdmin();
                    break;
            }

            form.Show();
            this.Hide();
        }
    }
}
