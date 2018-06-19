namespace SIG_LaFamiliar.Forms.Estrategico
{
    partial class FormPerdidasAsociados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerdidasAsociados));
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnRecuperacion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnMorosos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPerdidas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnIndice = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnInicio = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.btnPerdidasAsociados = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlEspacio = new System.Windows.Forms.Panel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnWordDoc = new System.Windows.Forms.Button();
            this.btnPDFDoc = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pnlParams = new System.Windows.Forms.Panel();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.pnlParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(0, 468);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(158, 45);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSalir.TabIndex = 29;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRecuperacion
            // 
            this.btnRecuperacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecuperacion.Depth = 0;
            this.btnRecuperacion.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperacion.Location = new System.Drawing.Point(0, 422);
            this.btnRecuperacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecuperacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRecuperacion.Name = "btnRecuperacion";
            this.btnRecuperacion.Primary = true;
            this.btnRecuperacion.Size = new System.Drawing.Size(159, 45);
            this.btnRecuperacion.TabIndex = 28;
            this.btnRecuperacion.TabStop = false;
            this.btnRecuperacion.Text = "Recuperación";
            this.btnRecuperacion.UseVisualStyleBackColor = true;
            this.btnRecuperacion.Click += new System.EventHandler(this.btnRecuperacion_Click);
            // 
            // btnMorosos
            // 
            this.btnMorosos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMorosos.Depth = 0;
            this.btnMorosos.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorosos.Location = new System.Drawing.Point(0, 376);
            this.btnMorosos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMorosos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMorosos.Name = "btnMorosos";
            this.btnMorosos.Primary = true;
            this.btnMorosos.Size = new System.Drawing.Size(159, 45);
            this.btnMorosos.TabIndex = 27;
            this.btnMorosos.TabStop = false;
            this.btnMorosos.Text = "Morosos por cuota";
            this.btnMorosos.UseVisualStyleBackColor = true;
            this.btnMorosos.Click += new System.EventHandler(this.btnMorosos_Click);
            // 
            // btnPerdidas
            // 
            this.btnPerdidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerdidas.Depth = 0;
            this.btnPerdidas.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerdidas.Location = new System.Drawing.Point(0, 284);
            this.btnPerdidas.Margin = new System.Windows.Forms.Padding(2);
            this.btnPerdidas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPerdidas.Name = "btnPerdidas";
            this.btnPerdidas.Primary = true;
            this.btnPerdidas.Size = new System.Drawing.Size(159, 45);
            this.btnPerdidas.TabIndex = 26;
            this.btnPerdidas.TabStop = false;
            this.btnPerdidas.Text = "Perdidas por falta de cobro";
            this.btnPerdidas.UseVisualStyleBackColor = true;
            this.btnPerdidas.Click += new System.EventHandler(this.btnPerdidas_Click);
            // 
            // btnIndice
            // 
            this.btnIndice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIndice.Depth = 0;
            this.btnIndice.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndice.Location = new System.Drawing.Point(0, 238);
            this.btnIndice.Margin = new System.Windows.Forms.Padding(2);
            this.btnIndice.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIndice.Name = "btnIndice";
            this.btnIndice.Primary = true;
            this.btnIndice.Size = new System.Drawing.Size(159, 45);
            this.btnIndice.TabIndex = 25;
            this.btnIndice.TabStop = false;
            this.btnIndice.Text = "índice de morosidad";
            this.btnIndice.UseVisualStyleBackColor = true;
            this.btnIndice.Click += new System.EventHandler(this.btnIndice_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Depth = 0;
            this.btnInicio.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(0, 192);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Primary = true;
            this.btnInicio.Size = new System.Drawing.Size(159, 45);
            this.btnInicio.TabIndex = 24;
            this.btnInicio.TabStop = false;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(0, 64);
            this.pcbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(158, 126);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 23;
            this.pcbLogo.TabStop = false;
            // 
            // btnPerdidasAsociados
            // 
            this.btnPerdidasAsociados.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPerdidasAsociados.Depth = 0;
            this.btnPerdidasAsociados.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerdidasAsociados.Location = new System.Drawing.Point(0, 330);
            this.btnPerdidasAsociados.Margin = new System.Windows.Forms.Padding(2);
            this.btnPerdidasAsociados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPerdidasAsociados.Name = "btnPerdidasAsociados";
            this.btnPerdidasAsociados.Primary = true;
            this.btnPerdidasAsociados.Size = new System.Drawing.Size(159, 45);
            this.btnPerdidasAsociados.TabIndex = 31;
            this.btnPerdidasAsociados.TabStop = false;
            this.btnPerdidasAsociados.Text = "Perdidas por asociados";
            this.btnPerdidasAsociados.UseVisualStyleBackColor = true;
            // 
            // pnlEspacio
            // 
            this.pnlEspacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.pnlEspacio.Location = new System.Drawing.Point(0, 514);
            this.pnlEspacio.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEspacio.Name = "pnlEspacio";
            this.pnlEspacio.Size = new System.Drawing.Size(158, 126);
            this.pnlEspacio.TabIndex = 32;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPrincipal.Controls.Add(this.btnExcel);
            this.pnlPrincipal.Controls.Add(this.btnWordDoc);
            this.pnlPrincipal.Controls.Add(this.btnPDFDoc);
            this.pnlPrincipal.Controls.Add(this.btnImprimir);
            this.pnlPrincipal.Location = new System.Drawing.Point(176, 218);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(703, 391);
            this.pnlPrincipal.TabIndex = 56;
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = global::SIG_LaFamiliar.Properties.Resources.excel;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.Location = new System.Drawing.Point(549, 11);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(30, 32);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnWordDoc
            // 
            this.btnWordDoc.BackgroundImage = global::SIG_LaFamiliar.Properties.Resources.word;
            this.btnWordDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWordDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWordDoc.Location = new System.Drawing.Point(584, 11);
            this.btnWordDoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnWordDoc.Name = "btnWordDoc";
            this.btnWordDoc.Size = new System.Drawing.Size(30, 32);
            this.btnWordDoc.TabIndex = 5;
            this.btnWordDoc.UseVisualStyleBackColor = true;
            // 
            // btnPDFDoc
            // 
            this.btnPDFDoc.BackgroundImage = global::SIG_LaFamiliar.Properties.Resources.pdf;
            this.btnPDFDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPDFDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDFDoc.Location = new System.Drawing.Point(618, 11);
            this.btnPDFDoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnPDFDoc.Name = "btnPDFDoc";
            this.btnPDFDoc.Size = new System.Drawing.Size(30, 32);
            this.btnPDFDoc.TabIndex = 5;
            this.btnPDFDoc.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = global::SIG_LaFamiliar.Properties.Resources.print;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Location = new System.Drawing.Point(652, 11);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(30, 32);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // pnlParams
            // 
            this.pnlParams.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlParams.Controls.Add(this.cmbMes);
            this.pnlParams.Controls.Add(this.btnBuscar);
            this.pnlParams.Controls.Add(this.cmbAnio);
            this.pnlParams.Controls.Add(this.lblPeriodo);
            this.pnlParams.Controls.Add(this.lblTitulo);
            this.pnlParams.Location = new System.Drawing.Point(176, 64);
            this.pnlParams.Margin = new System.Windows.Forms.Padding(2);
            this.pnlParams.Name = "pnlParams";
            this.pnlParams.Size = new System.Drawing.Size(703, 126);
            this.pnlParams.TabIndex = 55;
            // 
            // cmbMes
            // 
            this.cmbMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(404, 65);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(135, 27);
            this.cmbMes.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.BackgroundImage = global::SIG_LaFamiliar.Properties.Resources.magnifier;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(605, 62);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(30, 32);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // cmbAnio
            // 
            this.cmbAnio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnio.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(287, 65);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(95, 27);
            this.cmbAnio.TabIndex = 1;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(123, 68);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(158, 19);
            this.lblPeriodo.TabIndex = 64;
            this.lblPeriodo.Text = "Seleccione el periodo:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(205, 15);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(294, 23);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "Pérdidas por asociados morosos";
            // 
            // FormPerdidasAsociados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlParams);
            this.Controls.Add(this.pnlEspacio);
            this.Controls.Add(this.btnPerdidasAsociados);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRecuperacion);
            this.Controls.Add(this.btnMorosos);
            this.Controls.Add(this.btnPerdidas);
            this.Controls.Add(this.btnIndice);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.pcbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 640);
            this.MinimumSize = new System.Drawing.Size(900, 640);
            this.Name = "FormPerdidasAsociados";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Información Gerencial para el Apoyo al Análisis de la Morosidad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPerdidasAsociados_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlParams.ResumeLayout(false);
            this.pnlParams.PerformLayout();
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
        private MaterialSkin.Controls.MaterialRaisedButton btnPerdidasAsociados;
        private System.Windows.Forms.Panel pnlEspacio;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnWordDoc;
        private System.Windows.Forms.Button btnPDFDoc;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel pnlParams;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbAnio;
        private System.Windows.Forms.Label lblPeriodo;
    }
}