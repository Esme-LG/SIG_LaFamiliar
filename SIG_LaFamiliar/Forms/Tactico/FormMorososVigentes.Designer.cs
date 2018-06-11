namespace SIG_LaFamiliar.Forms.Tactico
{
    partial class FormMorososVigentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMorososVigentes));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudMaxMora = new System.Windows.Forms.NumericUpDown();
            this.nudMinMora = new System.Windows.Forms.NumericUpDown();
            this.nudMaxCredito = new System.Windows.Forms.NumericUpDown();
            this.nudMinCredito = new System.Windows.Forms.NumericUpDown();
            this.txtAsociado = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.ckbCategoriaE = new MaterialSkin.Controls.MaterialCheckBox();
            this.ckbCategoriaD = new MaterialSkin.Controls.MaterialCheckBox();
            this.ckbCategoriaC = new MaterialSkin.Controls.MaterialCheckBox();
            this.ckbCategoriaB = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lblAsociado = new MaterialSkin.Controls.MaterialLabel();
            this.frmMorososVigentes = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblID = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnWordDoc = new System.Windows.Forms.Button();
            this.btnPDFDoc = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dgvVigentes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asociado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoría = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valoractual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEspacio = new System.Windows.Forms.Panel();
            this.btnMorososTipo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnMorososHistoricos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCreditosCompletos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAsociadosCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnProyeccion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnMorososVigentes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcbSalir = new System.Windows.Forms.PictureBox();
            this.btnInicio = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxMora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinMora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinCredito)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVigentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Morosos vigentes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.nudMaxMora);
            this.panel1.Controls.Add(this.nudMinMora);
            this.panel1.Controls.Add(this.nudMaxCredito);
            this.panel1.Controls.Add(this.nudMinCredito);
            this.panel1.Controls.Add(this.txtAsociado);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.ckbCategoriaE);
            this.panel1.Controls.Add(this.ckbCategoriaD);
            this.panel1.Controls.Add(this.ckbCategoriaC);
            this.panel1.Controls.Add(this.ckbCategoriaB);
            this.panel1.Controls.Add(this.materialLabel8);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.lblAsociado);
            this.panel1.Controls.Add(this.frmMorososVigentes);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(176, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 204);
            this.panel1.TabIndex = 30;
            // 
            // nudMaxMora
            // 
            this.nudMaxMora.DecimalPlaces = 2;
            this.nudMaxMora.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaxMora.Location = new System.Drawing.Point(382, 170);
            this.nudMaxMora.Margin = new System.Windows.Forms.Padding(2);
            this.nudMaxMora.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.nudMaxMora.Name = "nudMaxMora";
            this.nudMaxMora.Size = new System.Drawing.Size(92, 26);
            this.nudMaxMora.TabIndex = 49;
            // 
            // nudMinMora
            // 
            this.nudMinMora.DecimalPlaces = 2;
            this.nudMinMora.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinMora.Location = new System.Drawing.Point(382, 139);
            this.nudMinMora.Margin = new System.Windows.Forms.Padding(2);
            this.nudMinMora.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.nudMinMora.Name = "nudMinMora";
            this.nudMinMora.Size = new System.Drawing.Size(92, 26);
            this.nudMinMora.TabIndex = 48;
            // 
            // nudMaxCredito
            // 
            this.nudMaxCredito.DecimalPlaces = 2;
            this.nudMaxCredito.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaxCredito.Location = new System.Drawing.Point(110, 170);
            this.nudMaxCredito.Margin = new System.Windows.Forms.Padding(2);
            this.nudMaxCredito.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.nudMaxCredito.Name = "nudMaxCredito";
            this.nudMaxCredito.Size = new System.Drawing.Size(90, 26);
            this.nudMaxCredito.TabIndex = 47;
            // 
            // nudMinCredito
            // 
            this.nudMinCredito.DecimalPlaces = 2;
            this.nudMinCredito.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinCredito.Location = new System.Drawing.Point(110, 139);
            this.nudMinCredito.Margin = new System.Windows.Forms.Padding(2);
            this.nudMinCredito.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.nudMinCredito.Name = "nudMinCredito";
            this.nudMinCredito.Size = new System.Drawing.Size(90, 26);
            this.nudMinCredito.TabIndex = 46;
            // 
            // txtAsociado
            // 
            this.txtAsociado.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsociado.Location = new System.Drawing.Point(394, 66);
            this.txtAsociado.Margin = new System.Windows.Forms.Padding(2);
            this.txtAsociado.Name = "txtAsociado";
            this.txtAsociado.Size = new System.Drawing.Size(298, 26);
            this.txtAsociado.TabIndex = 45;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(115, 66);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(92, 26);
            this.txtID.TabIndex = 44;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.BackgroundImage = global::SIG_LaFamiliar.Properties.Resources.magnifier;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(652, 142);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(30, 32);
            this.btnBuscar.TabIndex = 43;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // ckbCategoriaE
            // 
            this.ckbCategoriaE.AutoSize = true;
            this.ckbCategoriaE.Depth = 0;
            this.ckbCategoriaE.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckbCategoriaE.Location = new System.Drawing.Point(576, 166);
            this.ckbCategoriaE.Margin = new System.Windows.Forms.Padding(0);
            this.ckbCategoriaE.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbCategoriaE.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbCategoriaE.Name = "ckbCategoriaE";
            this.ckbCategoriaE.Ripple = true;
            this.ckbCategoriaE.Size = new System.Drawing.Size(38, 30);
            this.ckbCategoriaE.TabIndex = 42;
            this.ckbCategoriaE.Text = "E";
            this.ckbCategoriaE.UseVisualStyleBackColor = true;
            // 
            // ckbCategoriaD
            // 
            this.ckbCategoriaD.AutoSize = true;
            this.ckbCategoriaD.Depth = 0;
            this.ckbCategoriaD.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckbCategoriaD.Location = new System.Drawing.Point(575, 135);
            this.ckbCategoriaD.Margin = new System.Windows.Forms.Padding(0);
            this.ckbCategoriaD.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbCategoriaD.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbCategoriaD.Name = "ckbCategoriaD";
            this.ckbCategoriaD.Ripple = true;
            this.ckbCategoriaD.Size = new System.Drawing.Size(39, 30);
            this.ckbCategoriaD.TabIndex = 41;
            this.ckbCategoriaD.Text = "D";
            this.ckbCategoriaD.UseVisualStyleBackColor = true;
            // 
            // ckbCategoriaC
            // 
            this.ckbCategoriaC.AutoSize = true;
            this.ckbCategoriaC.Depth = 0;
            this.ckbCategoriaC.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckbCategoriaC.Location = new System.Drawing.Point(523, 166);
            this.ckbCategoriaC.Margin = new System.Windows.Forms.Padding(0);
            this.ckbCategoriaC.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbCategoriaC.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbCategoriaC.Name = "ckbCategoriaC";
            this.ckbCategoriaC.Ripple = true;
            this.ckbCategoriaC.Size = new System.Drawing.Size(39, 30);
            this.ckbCategoriaC.TabIndex = 40;
            this.ckbCategoriaC.Text = "C";
            this.ckbCategoriaC.UseVisualStyleBackColor = true;
            // 
            // ckbCategoriaB
            // 
            this.ckbCategoriaB.AutoSize = true;
            this.ckbCategoriaB.Depth = 0;
            this.ckbCategoriaB.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckbCategoriaB.Location = new System.Drawing.Point(523, 133);
            this.ckbCategoriaB.Margin = new System.Windows.Forms.Padding(0);
            this.ckbCategoriaB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbCategoriaB.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbCategoriaB.Name = "ckbCategoriaB";
            this.ckbCategoriaB.Ripple = true;
            this.ckbCategoriaB.Size = new System.Drawing.Size(39, 30);
            this.ckbCategoriaB.TabIndex = 39;
            this.ckbCategoriaB.Text = "B";
            this.ckbCategoriaB.UseVisualStyleBackColor = true;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(531, 107);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(82, 19);
            this.materialLabel8.TabIndex = 38;
            this.materialLabel8.Text = "Categoría: ";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(315, 172);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(63, 19);
            this.materialLabel6.TabIndex = 37;
            this.materialLabel6.Text = "Máx.($):";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(322, 144);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(56, 19);
            this.materialLabel7.TabIndex = 36;
            this.materialLabel7.Text = "Min($):";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(350, 106);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(124, 19);
            this.materialLabel5.TabIndex = 35;
            this.materialLabel5.Text = "Valor de la mora:";
            // 
            // lblAsociado
            // 
            this.lblAsociado.AutoSize = true;
            this.lblAsociado.CausesValidation = false;
            this.lblAsociado.Depth = 0;
            this.lblAsociado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAsociado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAsociado.Location = new System.Drawing.Point(256, 64);
            this.lblAsociado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsociado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAsociado.Name = "lblAsociado";
            this.lblAsociado.Size = new System.Drawing.Size(133, 19);
            this.lblAsociado.TabIndex = 34;
            this.lblAsociado.Text = "Nombre asociado:";
            // 
            // frmMorososVigentes
            // 
            this.frmMorososVigentes.AutoSize = true;
            this.frmMorososVigentes.Depth = 0;
            this.frmMorososVigentes.Font = new System.Drawing.Font("Roboto", 11F);
            this.frmMorososVigentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.frmMorososVigentes.Location = new System.Drawing.Point(43, 172);
            this.frmMorososVigentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.frmMorososVigentes.MouseState = MaterialSkin.MouseState.HOVER;
            this.frmMorososVigentes.Name = "frmMorososVigentes";
            this.frmMorososVigentes.Size = new System.Drawing.Size(63, 19);
            this.frmMorososVigentes.TabIndex = 33;
            this.frmMorososVigentes.Text = "Máx.($):";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(50, 144);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(56, 19);
            this.materialLabel3.TabIndex = 32;
            this.materialLabel3.Text = "Min($):";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(76, 106);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(124, 19);
            this.materialLabel2.TabIndex = 31;
            this.materialLabel2.Text = "Valor del crédito:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Depth = 0;
            this.lblID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblID.Location = new System.Drawing.Point(24, 64);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(93, 19);
            this.lblID.TabIndex = 30;
            this.lblID.Text = "ID asociado:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnExcel);
            this.panel2.Controls.Add(this.btnWordDoc);
            this.panel2.Controls.Add(this.btnPDFDoc);
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Controls.Add(this.dgvVigentes);
            this.panel2.Location = new System.Drawing.Point(176, 304);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 336);
            this.panel2.TabIndex = 50;
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = global::SIG_LaFamiliar.Properties.Resources.excel;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcel.Location = new System.Drawing.Point(549, 11);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(30, 32);
            this.btnExcel.TabIndex = 47;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnWordDoc
            // 
            this.btnWordDoc.BackgroundImage = global::SIG_LaFamiliar.Properties.Resources.word;
            this.btnWordDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWordDoc.Location = new System.Drawing.Point(584, 11);
            this.btnWordDoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnWordDoc.Name = "btnWordDoc";
            this.btnWordDoc.Size = new System.Drawing.Size(30, 32);
            this.btnWordDoc.TabIndex = 46;
            this.btnWordDoc.UseVisualStyleBackColor = true;
            this.btnWordDoc.Click += new System.EventHandler(this.btnWordDoc_Click);
            // 
            // btnPDFDoc
            // 
            this.btnPDFDoc.BackgroundImage = global::SIG_LaFamiliar.Properties.Resources.pdf;
            this.btnPDFDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPDFDoc.Location = new System.Drawing.Point(618, 11);
            this.btnPDFDoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnPDFDoc.Name = "btnPDFDoc";
            this.btnPDFDoc.Size = new System.Drawing.Size(30, 32);
            this.btnPDFDoc.TabIndex = 45;
            this.btnPDFDoc.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = global::SIG_LaFamiliar.Properties.Resources.print;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Location = new System.Drawing.Point(652, 11);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(30, 32);
            this.btnImprimir.TabIndex = 44;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // dgvVigentes
            // 
            this.dgvVigentes.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.dgvVigentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVigentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVigentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Asociado,
            this.Categoría,
            this.Valoractual,
            this.Categoria});
            this.dgvVigentes.Location = new System.Drawing.Point(20, 63);
            this.dgvVigentes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVigentes.Name = "dgvVigentes";
            this.dgvVigentes.RowHeadersVisible = false;
            this.dgvVigentes.RowTemplate.Height = 24;
            this.dgvVigentes.Size = new System.Drawing.Size(670, 252);
            this.dgvVigentes.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Asociado
            // 
            this.Asociado.HeaderText = "Asociado";
            this.Asociado.Name = "Asociado";
            // 
            // Categoría
            // 
            this.Categoría.HeaderText = "Categoría";
            this.Categoría.Name = "Categoría";
            // 
            // Valoractual
            // 
            this.Valoractual.HeaderText = "Valor actual";
            this.Valoractual.Name = "Valoractual";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Mora";
            this.Categoria.Name = "Categoria";
            // 
            // pnlEspacio
            // 
            this.pnlEspacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.pnlEspacio.Location = new System.Drawing.Point(1, 556);
            this.pnlEspacio.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEspacio.Name = "pnlEspacio";
            this.pnlEspacio.Size = new System.Drawing.Size(158, 94);
            this.pnlEspacio.TabIndex = 58;
            // 
            // btnMorososTipo
            // 
            this.btnMorososTipo.Depth = 0;
            this.btnMorososTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorososTipo.Location = new System.Drawing.Point(0, 328);
            this.btnMorososTipo.Margin = new System.Windows.Forms.Padding(2);
            this.btnMorososTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMorososTipo.Name = "btnMorososTipo";
            this.btnMorososTipo.Primary = true;
            this.btnMorososTipo.Size = new System.Drawing.Size(159, 45);
            this.btnMorososTipo.TabIndex = 57;
            this.btnMorososTipo.Text = "Morosos por tipo de crédito";
            this.btnMorososTipo.UseVisualStyleBackColor = true;
            this.btnMorososTipo.Click += new System.EventHandler(this.btnMorososTipo_Click);
            // 
            // btnMorososHistoricos
            // 
            this.btnMorososHistoricos.Depth = 0;
            this.btnMorososHistoricos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorososHistoricos.Location = new System.Drawing.Point(0, 283);
            this.btnMorososHistoricos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMorososHistoricos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMorososHistoricos.Name = "btnMorososHistoricos";
            this.btnMorososHistoricos.Primary = true;
            this.btnMorososHistoricos.Size = new System.Drawing.Size(159, 45);
            this.btnMorososHistoricos.TabIndex = 56;
            this.btnMorososHistoricos.Text = "Morosos históricos";
            this.btnMorososHistoricos.UseVisualStyleBackColor = true;
            this.btnMorososHistoricos.Click += new System.EventHandler(this.btnMorososHistoricos_Click);
            // 
            // btnCreditosCompletos
            // 
            this.btnCreditosCompletos.Depth = 0;
            this.btnCreditosCompletos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditosCompletos.Location = new System.Drawing.Point(0, 465);
            this.btnCreditosCompletos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreditosCompletos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreditosCompletos.Name = "btnCreditosCompletos";
            this.btnCreditosCompletos.Primary = true;
            this.btnCreditosCompletos.Size = new System.Drawing.Size(159, 45);
            this.btnCreditosCompletos.TabIndex = 54;
            this.btnCreditosCompletos.Text = "Créditos morosos completados";
            this.btnCreditosCompletos.UseVisualStyleBackColor = true;
            this.btnCreditosCompletos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // btnAsociadosCategoria
            // 
            this.btnAsociadosCategoria.Depth = 0;
            this.btnAsociadosCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsociadosCategoria.Location = new System.Drawing.Point(0, 419);
            this.btnAsociadosCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsociadosCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAsociadosCategoria.Name = "btnAsociadosCategoria";
            this.btnAsociadosCategoria.Primary = true;
            this.btnAsociadosCategoria.Size = new System.Drawing.Size(159, 45);
            this.btnAsociadosCategoria.TabIndex = 53;
            this.btnAsociadosCategoria.Text = "Asociados por categoría";
            this.btnAsociadosCategoria.UseVisualStyleBackColor = true;
            this.btnAsociadosCategoria.Click += new System.EventHandler(this.btnAsociados_Click);
            // 
            // btnProyeccion
            // 
            this.btnProyeccion.Depth = 0;
            this.btnProyeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyeccion.Location = new System.Drawing.Point(0, 374);
            this.btnProyeccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnProyeccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProyeccion.Name = "btnProyeccion";
            this.btnProyeccion.Primary = true;
            this.btnProyeccion.Size = new System.Drawing.Size(159, 45);
            this.btnProyeccion.TabIndex = 52;
            this.btnProyeccion.Text = "Proyección de pagos";
            this.btnProyeccion.UseVisualStyleBackColor = true;
            this.btnProyeccion.Click += new System.EventHandler(this.btnProyeccion_Click);
            // 
            // btnMorososVigentes
            // 
            this.btnMorososVigentes.Depth = 0;
            this.btnMorososVigentes.Enabled = false;
            this.btnMorososVigentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorososVigentes.Location = new System.Drawing.Point(0, 237);
            this.btnMorososVigentes.Margin = new System.Windows.Forms.Padding(2);
            this.btnMorososVigentes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMorososVigentes.Name = "btnMorososVigentes";
            this.btnMorososVigentes.Primary = true;
            this.btnMorososVigentes.Size = new System.Drawing.Size(159, 45);
            this.btnMorososVigentes.TabIndex = 51;
            this.btnMorososVigentes.Text = "Morosos vigentes";
            this.btnMorososVigentes.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 64);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            // 
            // pcbSalir
            // 
            this.pcbSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.pcbSalir.Image = ((System.Drawing.Image)(resources.GetObject("pcbSalir.Image")));
            this.pcbSalir.Location = new System.Drawing.Point(1, 511);
            this.pcbSalir.Margin = new System.Windows.Forms.Padding(2);
            this.pcbSalir.Name = "pcbSalir";
            this.pcbSalir.Size = new System.Drawing.Size(158, 44);
            this.pcbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbSalir.TabIndex = 55;
            this.pcbSalir.TabStop = false;
            // 
            // btnInicio
            // 
            this.btnInicio.Depth = 0;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(0, 192);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Primary = true;
            this.btnInicio.Size = new System.Drawing.Size(159, 45);
            this.btnInicio.TabIndex = 60;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // FormMorososVigentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnlEspacio);
            this.Controls.Add(this.btnMorososTipo);
            this.Controls.Add(this.btnMorososHistoricos);
            this.Controls.Add(this.pcbSalir);
            this.Controls.Add(this.btnCreditosCompletos);
            this.Controls.Add(this.btnAsociadosCategoria);
            this.Controls.Add(this.btnProyeccion);
            this.Controls.Add(this.btnMorososVigentes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 640);
            this.MinimumSize = new System.Drawing.Size(900, 640);
            this.Name = "FormMorososVigentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Información Gerencial para el Apoyo al Análisis de la Morosidad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMorososVigentes_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxMora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinMora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinCredito)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVigentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel frmMorososVigentes;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblID;
        private MaterialSkin.Controls.MaterialCheckBox ckbCategoriaE;
        private MaterialSkin.Controls.MaterialCheckBox ckbCategoriaD;
        private MaterialSkin.Controls.MaterialCheckBox ckbCategoriaC;
        private MaterialSkin.Controls.MaterialCheckBox ckbCategoriaB;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel lblAsociado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridView dgvVigentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asociado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoría;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valoractual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.Panel pnlEspacio;
        private MaterialSkin.Controls.MaterialRaisedButton btnMorososTipo;
        private MaterialSkin.Controls.MaterialRaisedButton btnMorososHistoricos;
        private System.Windows.Forms.PictureBox pcbSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnCreditosCompletos;
        private MaterialSkin.Controls.MaterialRaisedButton btnAsociadosCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btnProyeccion;
        private MaterialSkin.Controls.MaterialRaisedButton btnMorososVigentes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown nudMaxMora;
        private System.Windows.Forms.NumericUpDown nudMinMora;
        private System.Windows.Forms.NumericUpDown nudMaxCredito;
        private System.Windows.Forms.NumericUpDown nudMinCredito;
        private System.Windows.Forms.TextBox txtAsociado;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnWordDoc;
        private System.Windows.Forms.Button btnPDFDoc;
        private System.Windows.Forms.Button btnExcel;
        private MaterialSkin.Controls.MaterialRaisedButton btnInicio;
    }
}