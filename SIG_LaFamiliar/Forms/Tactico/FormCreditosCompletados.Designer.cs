namespace SIG_LaFamiliar.Forms.Tactico
{
    partial class FormCreditosCompletados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreditosCompletados));
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnWordDoc = new System.Windows.Forms.Button();
            this.btnPDFDoc = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pnlParams = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.rdbIguales = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbCambios = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbTodos = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlEspacio = new System.Windows.Forms.Panel();
            this.btnMorososTipo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnMorososHistoricos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnInicio = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCreditos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnMorososVigentes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAsociados = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnProyeccion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlPrincipal.SuspendLayout();
            this.pnlParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPrincipal.Controls.Add(this.btnExcel);
            this.pnlPrincipal.Controls.Add(this.btnWordDoc);
            this.pnlPrincipal.Controls.Add(this.btnPDFDoc);
            this.pnlPrincipal.Controls.Add(this.btnImprimir);
            this.pnlPrincipal.Location = new System.Drawing.Point(173, 259);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(703, 367);
            this.pnlPrincipal.TabIndex = 54;
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
            this.btnExcel.TabIndex = 5;
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
            this.btnWordDoc.TabIndex = 6;
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
            this.btnPDFDoc.TabIndex = 7;
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
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // pnlParams
            // 
            this.pnlParams.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlParams.Controls.Add(this.materialLabel1);
            this.pnlParams.Controls.Add(this.rdbIguales);
            this.pnlParams.Controls.Add(this.rdbCambios);
            this.pnlParams.Controls.Add(this.rdbTodos);
            this.pnlParams.Controls.Add(this.btnBuscar);
            this.pnlParams.Controls.Add(this.lblTitulo);
            this.pnlParams.Location = new System.Drawing.Point(173, 64);
            this.pnlParams.Margin = new System.Windows.Forms.Padding(2);
            this.pnlParams.Name = "pnlParams";
            this.pnlParams.Size = new System.Drawing.Size(703, 171);
            this.pnlParams.TabIndex = 53;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(126, 64);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 19);
            this.materialLabel1.TabIndex = 47;
            this.materialLabel1.Text = "Incluir:";
            // 
            // rdbIguales
            // 
            this.rdbIguales.AutoSize = true;
            this.rdbIguales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbIguales.Depth = 0;
            this.rdbIguales.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbIguales.Location = new System.Drawing.Point(218, 119);
            this.rdbIguales.Margin = new System.Windows.Forms.Padding(0);
            this.rdbIguales.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbIguales.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbIguales.Name = "rdbIguales";
            this.rdbIguales.Ripple = true;
            this.rdbIguales.Size = new System.Drawing.Size(335, 30);
            this.rdbIguales.TabIndex = 3;
            this.rdbIguales.TabStop = true;
            this.rdbIguales.Text = "Solo los créditos que no cambiaron plan de pagos";
            this.rdbIguales.UseVisualStyleBackColor = true;
            // 
            // rdbCambios
            // 
            this.rdbCambios.AutoSize = true;
            this.rdbCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbCambios.Depth = 0;
            this.rdbCambios.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbCambios.Location = new System.Drawing.Point(218, 89);
            this.rdbCambios.Margin = new System.Windows.Forms.Padding(0);
            this.rdbCambios.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbCambios.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbCambios.Name = "rdbCambios";
            this.rdbCambios.Ripple = true;
            this.rdbCambios.Size = new System.Drawing.Size(316, 30);
            this.rdbCambios.TabIndex = 2;
            this.rdbCambios.TabStop = true;
            this.rdbCambios.Text = "Solo los créditos que cambiaron plan de pagos";
            this.rdbCambios.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbTodos.Depth = 0;
            this.rdbTodos.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbTodos.Location = new System.Drawing.Point(218, 59);
            this.rdbTodos.Margin = new System.Windows.Forms.Padding(0);
            this.rdbTodos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbTodos.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Ripple = true;
            this.rdbTodos.Size = new System.Drawing.Size(227, 30);
            this.rdbTodos.TabIndex = 1;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos los créditos completados";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.BackgroundImage = global::SIG_LaFamiliar.Properties.Resources.magnifier;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(618, 117);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(30, 32);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(212, 15);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(279, 23);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "Créditos morosos completados";
            // 
            // pnlEspacio
            // 
            this.pnlEspacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.pnlEspacio.Location = new System.Drawing.Point(0, 559);
            this.pnlEspacio.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEspacio.Name = "pnlEspacio";
            this.pnlEspacio.Size = new System.Drawing.Size(158, 81);
            this.pnlEspacio.TabIndex = 67;
            // 
            // btnMorososTipo
            // 
            this.btnMorososTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMorososTipo.Depth = 0;
            this.btnMorososTipo.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorososTipo.Location = new System.Drawing.Point(0, 329);
            this.btnMorososTipo.Margin = new System.Windows.Forms.Padding(2);
            this.btnMorososTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMorososTipo.Name = "btnMorososTipo";
            this.btnMorososTipo.Primary = true;
            this.btnMorososTipo.Size = new System.Drawing.Size(159, 45);
            this.btnMorososTipo.TabIndex = 66;
            this.btnMorososTipo.TabStop = false;
            this.btnMorososTipo.Text = "Morosos por tipo de crédito";
            this.btnMorososTipo.UseVisualStyleBackColor = true;
            this.btnMorososTipo.Click += new System.EventHandler(this.btnMorososTipo_Click);
            // 
            // btnMorososHistoricos
            // 
            this.btnMorososHistoricos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMorososHistoricos.Depth = 0;
            this.btnMorososHistoricos.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorososHistoricos.Location = new System.Drawing.Point(0, 283);
            this.btnMorososHistoricos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMorososHistoricos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMorososHistoricos.Name = "btnMorososHistoricos";
            this.btnMorososHistoricos.Primary = true;
            this.btnMorososHistoricos.Size = new System.Drawing.Size(159, 45);
            this.btnMorososHistoricos.TabIndex = 65;
            this.btnMorososHistoricos.TabStop = false;
            this.btnMorososHistoricos.Text = "Morosos históricos";
            this.btnMorososHistoricos.UseVisualStyleBackColor = true;
            this.btnMorososHistoricos.Click += new System.EventHandler(this.btnMorososHistoricos_Click);
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
            this.pcbLogo.TabIndex = 58;
            this.pcbLogo.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(0, 513);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(158, 44);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSalir.TabIndex = 64;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Depth = 0;
            this.btnInicio.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(0, 191);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Primary = true;
            this.btnInicio.Size = new System.Drawing.Size(159, 45);
            this.btnInicio.TabIndex = 59;
            this.btnInicio.TabStop = false;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnCreditos
            // 
            this.btnCreditos.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCreditos.Depth = 0;
            this.btnCreditos.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditos.Location = new System.Drawing.Point(0, 467);
            this.btnCreditos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreditos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Primary = true;
            this.btnCreditos.Size = new System.Drawing.Size(159, 45);
            this.btnCreditos.TabIndex = 63;
            this.btnCreditos.TabStop = false;
            this.btnCreditos.Text = "Créditos morosos completados";
            this.btnCreditos.UseVisualStyleBackColor = true;
            // 
            // btnMorososVigentes
            // 
            this.btnMorososVigentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMorososVigentes.Depth = 0;
            this.btnMorososVigentes.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorososVigentes.Location = new System.Drawing.Point(0, 237);
            this.btnMorososVigentes.Margin = new System.Windows.Forms.Padding(2);
            this.btnMorososVigentes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMorososVigentes.Name = "btnMorososVigentes";
            this.btnMorososVigentes.Primary = true;
            this.btnMorososVigentes.Size = new System.Drawing.Size(159, 45);
            this.btnMorososVigentes.TabIndex = 60;
            this.btnMorososVigentes.TabStop = false;
            this.btnMorososVigentes.Text = "Morosos vigentes";
            this.btnMorososVigentes.UseVisualStyleBackColor = true;
            this.btnMorososVigentes.Click += new System.EventHandler(this.btnMorososVigentes_Click);
            // 
            // btnAsociados
            // 
            this.btnAsociados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsociados.Depth = 0;
            this.btnAsociados.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsociados.Location = new System.Drawing.Point(0, 421);
            this.btnAsociados.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsociados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAsociados.Name = "btnAsociados";
            this.btnAsociados.Primary = true;
            this.btnAsociados.Size = new System.Drawing.Size(159, 45);
            this.btnAsociados.TabIndex = 62;
            this.btnAsociados.TabStop = false;
            this.btnAsociados.Text = "Asociados por categoría";
            this.btnAsociados.UseVisualStyleBackColor = true;
            this.btnAsociados.Click += new System.EventHandler(this.btnAsociados_Click);
            // 
            // btnProyeccion
            // 
            this.btnProyeccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProyeccion.Depth = 0;
            this.btnProyeccion.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyeccion.Location = new System.Drawing.Point(0, 375);
            this.btnProyeccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnProyeccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProyeccion.Name = "btnProyeccion";
            this.btnProyeccion.Primary = true;
            this.btnProyeccion.Size = new System.Drawing.Size(159, 45);
            this.btnProyeccion.TabIndex = 61;
            this.btnProyeccion.TabStop = false;
            this.btnProyeccion.Text = "Proyección de pagos";
            this.btnProyeccion.UseVisualStyleBackColor = true;
            this.btnProyeccion.Click += new System.EventHandler(this.btnProyeccion_Click);
            // 
            // FormCreditosCompletados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.pnlEspacio);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.btnMorososTipo);
            this.Controls.Add(this.pnlParams);
            this.Controls.Add(this.btnMorososHistoricos);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.btnProyeccion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAsociados);
            this.Controls.Add(this.btnMorososVigentes);
            this.Controls.Add(this.btnCreditos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 640);
            this.MinimumSize = new System.Drawing.Size(900, 590);
            this.Name = "FormCreditosCompletados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Información Gerencial para el Apoyo al Análisis de la Morosidad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCreditosCompletados_FormClosed);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlParams.ResumeLayout(false);
            this.pnlParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnWordDoc;
        private System.Windows.Forms.Button btnPDFDoc;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel pnlParams;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton rdbIguales;
        private MaterialSkin.Controls.MaterialRadioButton rdbCambios;
        private MaterialSkin.Controls.MaterialRadioButton rdbTodos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlEspacio;
        private MaterialSkin.Controls.MaterialRaisedButton btnMorososTipo;
        private MaterialSkin.Controls.MaterialRaisedButton btnMorososHistoricos;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.PictureBox btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnInicio;
        private MaterialSkin.Controls.MaterialRaisedButton btnCreditos;
        private MaterialSkin.Controls.MaterialRaisedButton btnMorososVigentes;
        private MaterialSkin.Controls.MaterialRaisedButton btnAsociados;
        private MaterialSkin.Controls.MaterialRaisedButton btnProyeccion;
    }
}