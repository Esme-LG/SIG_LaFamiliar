namespace SIG_LaFamiliar.Forms.Admin
{
    partial class frmInicioAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioAdmin));
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLista = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnUsuarios = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnInicio = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.btnNuevo);
            this.pnlOpciones.Controls.Add(this.btnLista);
            this.pnlOpciones.Location = new System.Drawing.Point(103, 117);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(200, 68);
            this.pnlOpciones.TabIndex = 28;
            this.pnlOpciones.MouseLeave += new System.EventHandler(this.pnlOpciones_MouseLeave);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(3, 35);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(195, 30);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo usuario";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnLista
            // 
            this.btnLista.Depth = 0;
            this.btnLista.Location = new System.Drawing.Point(3, 5);
            this.btnLista.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLista.Name = "btnLista";
            this.btnLista.Primary = true;
            this.btnLista.Size = new System.Drawing.Size(195, 28);
            this.btnLista.TabIndex = 0;
            this.btnLista.Text = "Lista de usuarios";
            this.btnLista.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1060, 70);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 49);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSalir.TabIndex = 27;
            this.btnSalir.TabStop = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Depth = 0;
            this.btnUsuarios.Font = new System.Drawing.Font("Bradley Hand ITC", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(103, 71);
            this.btnUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Primary = true;
            this.btnUsuarios.Size = new System.Drawing.Size(146, 49);
            this.btnUsuarios.TabIndex = 25;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.MouseEnter += new System.EventHandler(this.btnUsuarios_MouseEnter);
            // 
            // btnInicio
            // 
            this.btnInicio.Depth = 0;
            this.btnInicio.Font = new System.Drawing.Font("Bradley Hand ITC", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(0, 72);
            this.btnInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Primary = true;
            this.btnInicio.Size = new System.Drawing.Size(104, 49);
            this.btnInicio.TabIndex = 24;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(1108, 36);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(92, 84);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 23;
            this.pcbLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.panel1.Location = new System.Drawing.Point(243, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 50);
            this.panel1.TabIndex = 29;
            // 
            // frmInicioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.pcbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "frmInicioAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Información Gerencial para el Apoyo al Análisis de la Morosidad";
            this.pnlOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpciones;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnLista;
        private System.Windows.Forms.PictureBox btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnUsuarios;
        private MaterialSkin.Controls.MaterialRaisedButton btnInicio;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Panel panel1;
    }
}