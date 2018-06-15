namespace SIG_LaFamiliar.Forms.Tactico
{
    partial class FormMorososCreditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMorososCreditos));
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnCreditos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAsociados = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnProyeccion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnMorososVigentes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnInicio = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.btnMorososHistoricos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnMorososTipo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlEspacio = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnWordDoc = new System.Windows.Forms.Button();
            this.btnPDFDoc = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.tblMorosidad = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.lblPeriodo = new MaterialSkin.Controls.MaterialLabel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asociado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoría = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMorosidad)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1, 628);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(211, 54);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSalir.TabIndex = 21;
            this.btnSalir.TabStop = false;
            // 
            // btnCreditos
            // 
            this.btnCreditos.Depth = 0;
            this.btnCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditos.Location = new System.Drawing.Point(0, 571);
            this.btnCreditos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreditos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Primary = true;
            this.btnCreditos.Size = new System.Drawing.Size(212, 55);
            this.btnCreditos.TabIndex = 20;
            this.btnCreditos.Text = "Créditos morosos completados";
            this.btnCreditos.UseVisualStyleBackColor = true;
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // btnAsociados
            // 
            this.btnAsociados.Depth = 0;
            this.btnAsociados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsociados.Location = new System.Drawing.Point(0, 514);
            this.btnAsociados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsociados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAsociados.Name = "btnAsociados";
            this.btnAsociados.Primary = true;
            this.btnAsociados.Size = new System.Drawing.Size(212, 55);
            this.btnAsociados.TabIndex = 19;
            this.btnAsociados.Text = "Asociados por categoría";
            this.btnAsociados.UseVisualStyleBackColor = true;
            this.btnAsociados.Click += new System.EventHandler(this.btnAsociados_Click);
            // 
            // btnProyeccion
            // 
            this.btnProyeccion.Depth = 0;
            this.btnProyeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyeccion.Location = new System.Drawing.Point(0, 459);
            this.btnProyeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProyeccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProyeccion.Name = "btnProyeccion";
            this.btnProyeccion.Primary = true;
            this.btnProyeccion.Size = new System.Drawing.Size(212, 55);
            this.btnProyeccion.TabIndex = 18;
            this.btnProyeccion.Text = "Proyección de pagos";
            this.btnProyeccion.UseVisualStyleBackColor = true;
            this.btnProyeccion.Click += new System.EventHandler(this.btnProyeccion_Click);
            // 
            // btnMorososVigentes
            // 
            this.btnMorososVigentes.Depth = 0;
            this.btnMorososVigentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorososVigentes.Location = new System.Drawing.Point(0, 290);
            this.btnMorososVigentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMorososVigentes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMorososVigentes.Name = "btnMorososVigentes";
            this.btnMorososVigentes.Primary = true;
            this.btnMorososVigentes.Size = new System.Drawing.Size(212, 55);
            this.btnMorososVigentes.TabIndex = 17;
            this.btnMorososVigentes.Text = "Morosos vigentes";
            this.btnMorososVigentes.UseVisualStyleBackColor = true;
            this.btnMorososVigentes.Click += new System.EventHandler(this.btnMorososVigentes_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Depth = 0;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(0, 235);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Primary = true;
            this.btnInicio.Size = new System.Drawing.Size(212, 55);
            this.btnInicio.TabIndex = 16;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(0, 79);
            this.pcbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(211, 155);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 15;
            this.pcbLogo.TabStop = false;
            // 
            // btnMorososHistoricos
            // 
            this.btnMorososHistoricos.Depth = 0;
            this.btnMorososHistoricos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorososHistoricos.Location = new System.Drawing.Point(0, 347);
            this.btnMorososHistoricos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMorososHistoricos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMorososHistoricos.Name = "btnMorososHistoricos";
            this.btnMorososHistoricos.Primary = true;
            this.btnMorososHistoricos.Size = new System.Drawing.Size(212, 55);
            this.btnMorososHistoricos.TabIndex = 23;
            this.btnMorososHistoricos.Text = "Morosos históricos";
            this.btnMorososHistoricos.UseVisualStyleBackColor = true;
            this.btnMorososHistoricos.Click += new System.EventHandler(this.btnMorososHistoricos_Click);
            // 
            // btnMorososTipo
            // 
            this.btnMorososTipo.Depth = 0;
            this.btnMorososTipo.Enabled = false;
            this.btnMorososTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorososTipo.Location = new System.Drawing.Point(0, 402);
            this.btnMorososTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMorososTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMorososTipo.Name = "btnMorososTipo";
            this.btnMorososTipo.Primary = true;
            this.btnMorososTipo.Size = new System.Drawing.Size(212, 55);
            this.btnMorososTipo.TabIndex = 24;
            this.btnMorososTipo.Text = "Morosos por tipo de crédito";
            this.btnMorososTipo.UseVisualStyleBackColor = true;
            // 
            // pnlEspacio
            // 
            this.pnlEspacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.pnlEspacio.Location = new System.Drawing.Point(1, 684);
            this.pnlEspacio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEspacio.Name = "pnlEspacio";
            this.pnlEspacio.Size = new System.Drawing.Size(211, 114);
            this.pnlEspacio.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnExcel);
            this.panel2.Controls.Add(this.btnWordDoc);
            this.panel2.Controls.Add(this.btnPDFDoc);
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Controls.Add(this.tblMorosidad);
            this.panel2.Location = new System.Drawing.Point(227, 272);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 499);
            this.panel2.TabIndex = 54;
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = global::SIG_LaFamiliar.Properties.Resources.excel;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcel.Location = new System.Drawing.Point(732, 14);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(40, 39);
            this.btnExcel.TabIndex = 47;
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnWordDoc
            // 
            this.btnWordDoc.BackgroundImage = global::SIG_LaFamiliar.Properties.Resources.word;
            this.btnWordDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWordDoc.Location = new System.Drawing.Point(779, 14);
            this.btnWordDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWordDoc.Name = "btnWordDoc";
            this.btnWordDoc.Size = new System.Drawing.Size(40, 39);
            this.btnWordDoc.TabIndex = 46;
            this.btnWordDoc.UseVisualStyleBackColor = true;
            // 
            // btnPDFDoc
            // 
            this.btnPDFDoc.BackgroundImage = global::SIG_LaFamiliar.Properties.Resources.pdf;
            this.btnPDFDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPDFDoc.Location = new System.Drawing.Point(824, 14);
            this.btnPDFDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPDFDoc.Name = "btnPDFDoc";
            this.btnPDFDoc.Size = new System.Drawing.Size(40, 39);
            this.btnPDFDoc.TabIndex = 45;
            this.btnPDFDoc.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = global::SIG_LaFamiliar.Properties.Resources.print;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Location = new System.Drawing.Point(869, 14);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(40, 39);
            this.btnImprimir.TabIndex = 44;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // tblMorosidad
            // 
            this.tblMorosidad.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.tblMorosidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblMorosidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMorosidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Asociado,
            this.Categoría});
            this.tblMorosidad.Location = new System.Drawing.Point(100, 88);
            this.tblMorosidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblMorosidad.Name = "tblMorosidad";
            this.tblMorosidad.RowHeadersVisible = false;
            this.tblMorosidad.RowTemplate.Height = 24;
            this.tblMorosidad.Size = new System.Drawing.Size(751, 367);
            this.tblMorosidad.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.cmbMes);
            this.panel1.Controls.Add(this.cmbAnio);
            this.panel1.Controls.Add(this.lblPeriodo);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(227, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 164);
            this.panel1.TabIndex = 53;
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril ",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMes.Location = new System.Drawing.Point(560, 101);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(99, 24);
            this.cmbMes.TabIndex = 46;
            // 
            // cmbAnio
            // 
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Items.AddRange(new object[] {
            "2018"});
            this.cmbAnio.Location = new System.Drawing.Point(444, 99);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(99, 24);
            this.cmbAnio.TabIndex = 45;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Depth = 0;
            this.lblPeriodo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPeriodo.Location = new System.Drawing.Point(187, 99);
            this.lblPeriodo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(250, 24);
            this.lblPeriodo.TabIndex = 44;
            this.lblPeriodo.Text = "Seleccione el periodo límite:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.BackgroundImage = global::SIG_LaFamiliar.Properties.Resources.magnifier;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(777, 93);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 39);
            this.btnBuscar.TabIndex = 43;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(365, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(359, 29);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Morosidad por tipo de crédito";
            // 
            // ID
            // 
            this.ID.HeaderText = "Tipo de crédito";
            this.ID.Name = "ID";
            // 
            // Asociado
            // 
            this.Asociado.HeaderText = "Cantidad";
            this.Asociado.Name = "Asociado";
            // 
            // Categoría
            // 
            this.Categoría.HeaderText = "Monto";
            this.Categoría.Name = "Categoría";
            // 
            // FormMorososCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlEspacio);
            this.Controls.Add(this.btnMorososTipo);
            this.Controls.Add(this.btnMorososHistoricos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCreditos);
            this.Controls.Add(this.btnAsociados);
            this.Controls.Add(this.btnProyeccion);
            this.Controls.Add(this.btnMorososVigentes);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.pcbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 788);
            this.MinimumSize = new System.Drawing.Size(1200, 788);
            this.Name = "FormMorososCreditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Información Gerencial para el Apoyo al Análisis de la Morosidad";
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblMorosidad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnCreditos;
        private MaterialSkin.Controls.MaterialRaisedButton btnAsociados;
        private MaterialSkin.Controls.MaterialRaisedButton btnProyeccion;
        private MaterialSkin.Controls.MaterialRaisedButton btnMorososVigentes;
        private MaterialSkin.Controls.MaterialRaisedButton btnInicio;
        private System.Windows.Forms.PictureBox pcbLogo;
        private MaterialSkin.Controls.MaterialRaisedButton btnMorososHistoricos;
        private MaterialSkin.Controls.MaterialRaisedButton btnMorososTipo;
        private System.Windows.Forms.Panel pnlEspacio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnWordDoc;
        private System.Windows.Forms.Button btnPDFDoc;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridView tblMorosidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbAnio;
        private MaterialSkin.Controls.MaterialLabel lblPeriodo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asociado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoría;
    }
}