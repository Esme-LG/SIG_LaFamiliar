namespace SIG_LaFamiliar.Forms.Tactico
{
    partial class frmInicioTactico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioTactico));
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.btnPorTipoCredito = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnHistoricos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVigentes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnCreditos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAsociados = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnProyeccion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnMorosos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnInicio = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.btnPorTipoCredito);
            this.pnlOpciones.Controls.Add(this.btnHistoricos);
            this.pnlOpciones.Controls.Add(this.btnVigentes);
            this.pnlOpciones.Location = new System.Drawing.Point(73, 123);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(200, 100);
            this.pnlOpciones.TabIndex = 22;
            this.pnlOpciones.MouseEnter += new System.EventHandler(this.pnlOpciones_MouseEnter);
            this.pnlOpciones.MouseLeave += new System.EventHandler(this.pnlOpciones_MouseLeave);
            // 
            // btnPorTipoCredito
            // 
            this.btnPorTipoCredito.Depth = 0;
            this.btnPorTipoCredito.Location = new System.Drawing.Point(3, 67);
            this.btnPorTipoCredito.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPorTipoCredito.Name = "btnPorTipoCredito";
            this.btnPorTipoCredito.Primary = true;
            this.btnPorTipoCredito.Size = new System.Drawing.Size(195, 30);
            this.btnPorTipoCredito.TabIndex = 2;
            this.btnPorTipoCredito.Text = "Por tipo de crédito";
            this.btnPorTipoCredito.UseVisualStyleBackColor = true;
            this.btnPorTipoCredito.MouseEnter += new System.EventHandler(this.btnPorTipoCredito_MouseEnter);
            // 
            // btnHistoricos
            // 
            this.btnHistoricos.Depth = 0;
            this.btnHistoricos.Location = new System.Drawing.Point(3, 35);
            this.btnHistoricos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHistoricos.Name = "btnHistoricos";
            this.btnHistoricos.Primary = true;
            this.btnHistoricos.Size = new System.Drawing.Size(195, 30);
            this.btnHistoricos.TabIndex = 1;
            this.btnHistoricos.Text = "Históricos";
            this.btnHistoricos.UseVisualStyleBackColor = true;
            this.btnHistoricos.MouseEnter += new System.EventHandler(this.btnHistoricos_MouseEnter);
            // 
            // btnVigentes
            // 
            this.btnVigentes.Depth = 0;
            this.btnVigentes.Location = new System.Drawing.Point(3, 3);
            this.btnVigentes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVigentes.Name = "btnVigentes";
            this.btnVigentes.Primary = true;
            this.btnVigentes.Size = new System.Drawing.Size(195, 30);
            this.btnVigentes.TabIndex = 0;
            this.btnVigentes.Text = "Vigentes";
            this.btnVigentes.UseVisualStyleBackColor = true;
            this.btnVigentes.MouseEnter += new System.EventHandler(this.btnVigentes_MouseEnter);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1060, 72);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 49);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSalir.TabIndex = 21;
            this.btnSalir.TabStop = false;
            // 
            // btnCreditos
            // 
            this.btnCreditos.Depth = 0;
            this.btnCreditos.Font = new System.Drawing.Font("Bradley Hand ITC", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditos.Location = new System.Drawing.Point(716, 72);
            this.btnCreditos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Primary = true;
            this.btnCreditos.Size = new System.Drawing.Size(344, 49);
            this.btnCreditos.TabIndex = 20;
            this.btnCreditos.Text = "Créditos morosos completados";
            this.btnCreditos.UseVisualStyleBackColor = true;
            // 
            // btnAsociados
            // 
            this.btnAsociados.Depth = 0;
            this.btnAsociados.Font = new System.Drawing.Font("Bradley Hand ITC", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsociados.Location = new System.Drawing.Point(434, 72);
            this.btnAsociados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAsociados.Name = "btnAsociados";
            this.btnAsociados.Primary = true;
            this.btnAsociados.Size = new System.Drawing.Size(283, 49);
            this.btnAsociados.TabIndex = 19;
            this.btnAsociados.Text = "Asociados por categoría";
            this.btnAsociados.UseVisualStyleBackColor = true;
            // 
            // btnProyeccion
            // 
            this.btnProyeccion.Depth = 0;
            this.btnProyeccion.Font = new System.Drawing.Font("Bradley Hand ITC", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyeccion.Location = new System.Drawing.Point(193, 72);
            this.btnProyeccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProyeccion.Name = "btnProyeccion";
            this.btnProyeccion.Primary = true;
            this.btnProyeccion.Size = new System.Drawing.Size(242, 49);
            this.btnProyeccion.TabIndex = 18;
            this.btnProyeccion.Text = "Proyección de pagos";
            this.btnProyeccion.UseVisualStyleBackColor = true;
            // 
            // btnMorosos
            // 
            this.btnMorosos.Depth = 0;
            this.btnMorosos.Font = new System.Drawing.Font("Bradley Hand ITC", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorosos.Location = new System.Drawing.Point(73, 72);
            this.btnMorosos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMorosos.Name = "btnMorosos";
            this.btnMorosos.Primary = true;
            this.btnMorosos.Size = new System.Drawing.Size(121, 49);
            this.btnMorosos.TabIndex = 17;
            this.btnMorosos.Text = "Morosos";
            this.btnMorosos.UseVisualStyleBackColor = true;
            this.btnMorosos.MouseEnter += new System.EventHandler(this.btnMorosos_MouseEnter);
            // 
            // btnInicio
            // 
            this.btnInicio.Depth = 0;
            this.btnInicio.Font = new System.Drawing.Font("Bradley Hand ITC", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(0, 72);
            this.btnInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Primary = true;
            this.btnInicio.Size = new System.Drawing.Size(74, 49);
            this.btnInicio.TabIndex = 16;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(1108, 37);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(92, 84);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 15;
            this.pcbLogo.TabStop = false;
            // 
            // frmInicioTactico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCreditos);
            this.Controls.Add(this.btnAsociados);
            this.Controls.Add(this.btnProyeccion);
            this.Controls.Add(this.btnMorosos);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.pcbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "frmInicioTactico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Información Gerencial para el Apoyo al Análisis de la Morosidad";
            this.pnlOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpciones;
        private MaterialSkin.Controls.MaterialRaisedButton btnPorTipoCredito;
        private MaterialSkin.Controls.MaterialRaisedButton btnHistoricos;
        private MaterialSkin.Controls.MaterialRaisedButton btnVigentes;
        private System.Windows.Forms.PictureBox btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnCreditos;
        private MaterialSkin.Controls.MaterialRaisedButton btnAsociados;
        private MaterialSkin.Controls.MaterialRaisedButton btnProyeccion;
        private MaterialSkin.Controls.MaterialRaisedButton btnMorosos;
        private MaterialSkin.Controls.MaterialRaisedButton btnInicio;
        private System.Windows.Forms.PictureBox pcbLogo;
    }
}