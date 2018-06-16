﻿namespace SIG_LaFamiliar.Forms.Tactico
{
    partial class FormAsociadosCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsociadosCategoria));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnWordDoc = new System.Windows.Forms.Button();
            this.btnPDFDoc = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.tblCategoría = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asociado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoría = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbOpcionF = new MaterialSkin.Controls.MaterialCheckBox();
            this.ckbOpcionD = new MaterialSkin.Controls.MaterialCheckBox();
            this.ckbOpcionC = new MaterialSkin.Controls.MaterialCheckBox();
            this.ckbOpcionB = new MaterialSkin.Controls.MaterialCheckBox();
            this.ckbOpcionA = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.lblAsociado = new MaterialSkin.Controls.MaterialLabel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblAsociados = new System.Windows.Forms.Label();
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoría)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnExcel);
            this.panel2.Controls.Add(this.btnWordDoc);
            this.panel2.Controls.Add(this.btnPDFDoc);
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Controls.Add(this.tblCategoría);
            this.panel2.Location = new System.Drawing.Point(172, 259);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 367);
            this.panel2.TabIndex = 54;
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
            // tblCategoría
            // 
            this.tblCategoría.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.tblCategoría.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblCategoría.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblCategoría.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCategoría.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Asociado,
            this.Categoría});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblCategoría.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblCategoría.Location = new System.Drawing.Point(20, 63);
            this.tblCategoría.Margin = new System.Windows.Forms.Padding(2);
            this.tblCategoría.Name = "tblCategoría";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblCategoría.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblCategoría.RowHeadersVisible = false;
            this.tblCategoría.RowTemplate.Height = 24;
            this.tblCategoría.Size = new System.Drawing.Size(670, 252);
            this.tblCategoría.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Asociado
            // 
            this.Asociado.HeaderText = "Nombre";
            this.Asociado.Name = "Asociado";
            // 
            // Categoría
            // 
            this.Categoría.HeaderText = "Categoría";
            this.Categoría.Name = "Categoría";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.ckbOpcionF);
            this.panel1.Controls.Add(this.ckbOpcionD);
            this.panel1.Controls.Add(this.ckbOpcionC);
            this.panel1.Controls.Add(this.ckbOpcionB);
            this.panel1.Controls.Add(this.ckbOpcionA);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblAsociado);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.lblAsociados);
            this.panel1.Location = new System.Drawing.Point(172, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 171);
            this.panel1.TabIndex = 53;
            // 
            // ckbOpcionF
            // 
            this.ckbOpcionF.AutoSize = true;
            this.ckbOpcionF.Depth = 0;
            this.ckbOpcionF.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbOpcionF.Location = new System.Drawing.Point(410, 110);
            this.ckbOpcionF.Margin = new System.Windows.Forms.Padding(0);
            this.ckbOpcionF.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbOpcionF.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbOpcionF.Name = "ckbOpcionF";
            this.ckbOpcionF.Ripple = true;
            this.ckbOpcionF.Size = new System.Drawing.Size(37, 30);
            this.ckbOpcionF.TabIndex = 53;
            this.ckbOpcionF.Text = "F";
            this.ckbOpcionF.UseVisualStyleBackColor = true;
            // 
            // ckbOpcionD
            // 
            this.ckbOpcionD.AutoSize = true;
            this.ckbOpcionD.Depth = 0;
            this.ckbOpcionD.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbOpcionD.Location = new System.Drawing.Point(360, 110);
            this.ckbOpcionD.Margin = new System.Windows.Forms.Padding(0);
            this.ckbOpcionD.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbOpcionD.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbOpcionD.Name = "ckbOpcionD";
            this.ckbOpcionD.Ripple = true;
            this.ckbOpcionD.Size = new System.Drawing.Size(39, 30);
            this.ckbOpcionD.TabIndex = 52;
            this.ckbOpcionD.Text = "D";
            this.ckbOpcionD.UseVisualStyleBackColor = true;
            // 
            // ckbOpcionC
            // 
            this.ckbOpcionC.AutoSize = true;
            this.ckbOpcionC.Depth = 0;
            this.ckbOpcionC.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbOpcionC.Location = new System.Drawing.Point(310, 110);
            this.ckbOpcionC.Margin = new System.Windows.Forms.Padding(0);
            this.ckbOpcionC.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbOpcionC.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbOpcionC.Name = "ckbOpcionC";
            this.ckbOpcionC.Ripple = true;
            this.ckbOpcionC.Size = new System.Drawing.Size(39, 30);
            this.ckbOpcionC.TabIndex = 51;
            this.ckbOpcionC.Text = "C";
            this.ckbOpcionC.UseVisualStyleBackColor = true;
            // 
            // ckbOpcionB
            // 
            this.ckbOpcionB.AutoSize = true;
            this.ckbOpcionB.Depth = 0;
            this.ckbOpcionB.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbOpcionB.Location = new System.Drawing.Point(260, 110);
            this.ckbOpcionB.Margin = new System.Windows.Forms.Padding(0);
            this.ckbOpcionB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbOpcionB.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbOpcionB.Name = "ckbOpcionB";
            this.ckbOpcionB.Ripple = true;
            this.ckbOpcionB.Size = new System.Drawing.Size(39, 30);
            this.ckbOpcionB.TabIndex = 50;
            this.ckbOpcionB.Text = "B";
            this.ckbOpcionB.UseVisualStyleBackColor = true;
            // 
            // ckbOpcionA
            // 
            this.ckbOpcionA.AutoSize = true;
            this.ckbOpcionA.Depth = 0;
            this.ckbOpcionA.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbOpcionA.Location = new System.Drawing.Point(210, 110);
            this.ckbOpcionA.Margin = new System.Windows.Forms.Padding(0);
            this.ckbOpcionA.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbOpcionA.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbOpcionA.Name = "ckbOpcionA";
            this.ckbOpcionA.Ripple = true;
            this.ckbOpcionA.Size = new System.Drawing.Size(39, 30);
            this.ckbOpcionA.TabIndex = 49;
            this.ckbOpcionA.Text = "A";
            this.ckbOpcionA.UseVisualStyleBackColor = true;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Depth = 0;
            this.lblCategoria.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategoria.Location = new System.Drawing.Point(131, 115);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(78, 19);
            this.lblCategoria.TabIndex = 48;
            this.lblCategoria.Text = "Categoría:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(467, 63);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 26);
            this.txtNombre.TabIndex = 47;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(195, 63);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(108, 26);
            this.txtID.TabIndex = 46;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(330, 66);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(133, 19);
            this.lblNombre.TabIndex = 45;
            this.lblNombre.Text = "Nombre asociado:";
            // 
            // lblAsociado
            // 
            this.lblAsociado.AutoSize = true;
            this.lblAsociado.Depth = 0;
            this.lblAsociado.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsociado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAsociado.Location = new System.Drawing.Point(87, 66);
            this.lblAsociado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsociado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAsociado.Name = "lblAsociado";
            this.lblAsociado.Size = new System.Drawing.Size(93, 19);
            this.lblAsociado.TabIndex = 44;
            this.lblAsociado.Text = "ID asociado:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.BackgroundImage = global::SIG_LaFamiliar.Properties.Resources.magnifier;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(549, 109);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(30, 32);
            this.btnBuscar.TabIndex = 43;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblAsociados
            // 
            this.lblAsociados.AutoSize = true;
            this.lblAsociados.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsociados.Location = new System.Drawing.Point(243, 15);
            this.lblAsociados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsociados.Name = "lblAsociados";
            this.lblAsociados.Size = new System.Drawing.Size(220, 23);
            this.lblAsociados.TabIndex = 29;
            this.lblAsociados.Text = "Asociados por categoría";
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
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnCreditos
            // 
            this.btnCreditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreditos.Depth = 0;
            this.btnCreditos.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditos.Location = new System.Drawing.Point(0, 467);
            this.btnCreditos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreditos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Primary = true;
            this.btnCreditos.Size = new System.Drawing.Size(159, 45);
            this.btnCreditos.TabIndex = 63;
            this.btnCreditos.Text = "Créditos morosos completados";
            this.btnCreditos.UseVisualStyleBackColor = true;
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
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
            this.btnMorososVigentes.Text = "Morosos vigentes";
            this.btnMorososVigentes.UseVisualStyleBackColor = true;
            this.btnMorososVigentes.Click += new System.EventHandler(this.btnMorososVigentes_Click);
            // 
            // btnAsociados
            // 
            this.btnAsociados.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAsociados.Depth = 0;
            this.btnAsociados.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsociados.Location = new System.Drawing.Point(0, 421);
            this.btnAsociados.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsociados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAsociados.Name = "btnAsociados";
            this.btnAsociados.Primary = true;
            this.btnAsociados.Size = new System.Drawing.Size(159, 45);
            this.btnAsociados.TabIndex = 62;
            this.btnAsociados.Text = "Asociados por categoría";
            this.btnAsociados.UseVisualStyleBackColor = true;
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
            this.btnProyeccion.Text = "Proyección de pagos";
            this.btnProyeccion.UseVisualStyleBackColor = true;
            this.btnProyeccion.Click += new System.EventHandler(this.btnProyeccion_Click);
            // 
            // FormAsociadosCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.pnlEspacio);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnMorososTipo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMorososHistoricos);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.btnProyeccion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAsociados);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnMorososVigentes);
            this.Controls.Add(this.btnCreditos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 640);
            this.MinimumSize = new System.Drawing.Size(900, 590);
            this.Name = "FormAsociadosCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Información Gerencial para el Apoyo al Análisis de la Morosidad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAsociadosCategoria_FormClosed);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoría)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnWordDoc;
        private System.Windows.Forms.Button btnPDFDoc;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridView tblCategoría;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialCheckBox ckbOpcionF;
        private MaterialSkin.Controls.MaterialCheckBox ckbOpcionD;
        private MaterialSkin.Controls.MaterialCheckBox ckbOpcionC;
        private MaterialSkin.Controls.MaterialCheckBox ckbOpcionB;
        private MaterialSkin.Controls.MaterialCheckBox ckbOpcionA;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialLabel lblAsociado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblAsociados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asociado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoría;
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