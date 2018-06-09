namespace SIG_LaFamiliar.Forms.Estrategico
{
    partial class FrmInicioEstrategico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioEstrategico));
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnRecuperacion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnMorosos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPerdidas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnIndice = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnInicio = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlEspacio = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1, 570);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(211, 55);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSalir.TabIndex = 29;
            this.btnSalir.TabStop = false;
            // 
            // btnRecuperacion
            // 
            this.btnRecuperacion.Depth = 0;
            this.btnRecuperacion.Font = new System.Drawing.Font("Bradley Hand ITC", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperacion.Location = new System.Drawing.Point(0, 518);
            this.btnRecuperacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRecuperacion.Name = "btnRecuperacion";
            this.btnRecuperacion.Primary = true;
            this.btnRecuperacion.Size = new System.Drawing.Size(212, 55);
            this.btnRecuperacion.TabIndex = 28;
            this.btnRecuperacion.Text = "Recuperación";
            this.btnRecuperacion.UseVisualStyleBackColor = true;
            // 
            // btnMorosos
            // 
            this.btnMorosos.Depth = 0;
            this.btnMorosos.Font = new System.Drawing.Font("Bradley Hand ITC", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorosos.Location = new System.Drawing.Point(0, 462);
            this.btnMorosos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMorosos.Name = "btnMorosos";
            this.btnMorosos.Primary = true;
            this.btnMorosos.Size = new System.Drawing.Size(212, 55);
            this.btnMorosos.TabIndex = 27;
            this.btnMorosos.Text = "Morosos por cuota";
            this.btnMorosos.UseVisualStyleBackColor = true;
            // 
            // btnPerdidas
            // 
            this.btnPerdidas.Depth = 0;
            this.btnPerdidas.Font = new System.Drawing.Font("Bradley Hand ITC", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerdidas.Location = new System.Drawing.Point(0, 350);
            this.btnPerdidas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPerdidas.Name = "btnPerdidas";
            this.btnPerdidas.Primary = true;
            this.btnPerdidas.Size = new System.Drawing.Size(212, 55);
            this.btnPerdidas.TabIndex = 26;
            this.btnPerdidas.Text = "Perdidas por falta de cobro";
            this.btnPerdidas.UseVisualStyleBackColor = true;
            // 
            // btnIndice
            // 
            this.btnIndice.Depth = 0;
            this.btnIndice.Font = new System.Drawing.Font("Bradley Hand ITC", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndice.Location = new System.Drawing.Point(0, 293);
            this.btnIndice.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIndice.Name = "btnIndice";
            this.btnIndice.Primary = true;
            this.btnIndice.Size = new System.Drawing.Size(212, 55);
            this.btnIndice.TabIndex = 25;
            this.btnIndice.Text = "índice de morosidad";
            this.btnIndice.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            this.btnInicio.Depth = 0;
            this.btnInicio.Font = new System.Drawing.Font("Bradley Hand ITC", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(0, 236);
            this.btnInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Primary = true;
            this.btnInicio.Size = new System.Drawing.Size(212, 55);
            this.btnInicio.TabIndex = 24;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(0, 79);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(211, 155);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 23;
            this.pcbLogo.TabStop = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Font = new System.Drawing.Font("Bradley Hand ITC", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton1.Location = new System.Drawing.Point(0, 406);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(212, 55);
            this.materialRaisedButton1.TabIndex = 31;
            this.materialRaisedButton1.Text = "Perdidas por asociados";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // pnlEspacio
            // 
            this.pnlEspacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.pnlEspacio.Location = new System.Drawing.Point(1, 627);
            this.pnlEspacio.Name = "pnlEspacio";
            this.pnlEspacio.Size = new System.Drawing.Size(211, 174);
            this.pnlEspacio.TabIndex = 32;
            // 
            // FrmInicioEstrategico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnlEspacio);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRecuperacion);
            this.Controls.Add(this.btnMorosos);
            this.Controls.Add(this.btnPerdidas);
            this.Controls.Add(this.btnIndice);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.pcbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "FrmInicioEstrategico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Información Gerencial para el Apoyo al Análisis de la Morosidad";
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnRecuperacion;
        private MaterialSkin.Controls.MaterialRaisedButton btnMorosos;
        private MaterialSkin.Controls.MaterialRaisedButton btnPerdidas;
        private MaterialSkin.Controls.MaterialRaisedButton btnIndice;
        private MaterialSkin.Controls.MaterialRaisedButton btnInicio;
        private System.Windows.Forms.PictureBox pcbLogo;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Panel pnlEspacio;
    }
}