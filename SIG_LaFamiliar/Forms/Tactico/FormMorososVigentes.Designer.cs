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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlParams = new System.Windows.Forms.Panel();
            this.nudMaxMora = new System.Windows.Forms.NumericUpDown();
            this.nudMinMora = new System.Windows.Forms.NumericUpDown();
            this.nudMaxCredito = new System.Windows.Forms.NumericUpDown();
            this.nudMinCredito = new System.Windows.Forms.NumericUpDown();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.ckbCategoriaF = new MaterialSkin.Controls.MaterialCheckBox();
            this.ckbCategoriaD = new MaterialSkin.Controls.MaterialCheckBox();
            this.ckbCategoriaC = new MaterialSkin.Controls.MaterialCheckBox();
            this.ckbCategoriaB = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.lblMoraMax = new MaterialSkin.Controls.MaterialLabel();
            this.lblMoraMin = new MaterialSkin.Controls.MaterialLabel();
            this.lblMora = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.lblValorMax = new MaterialSkin.Controls.MaterialLabel();
            this.lblValorMin = new MaterialSkin.Controls.MaterialLabel();
            this.lblValor = new MaterialSkin.Controls.MaterialLabel();
            this.lblID = new MaterialSkin.Controls.MaterialLabel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnWordDoc = new System.Windows.Forms.Button();
            this.btnPDFDoc = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pnlEspacio = new System.Windows.Forms.Panel();
            this.btnMorososTipo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnMorososHistoricos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnCreditos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAsociados = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnProyeccion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnMorososVigentes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnInicio = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.pnlParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxMora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinMora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinCredito)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(269, 15);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(165, 23);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "Morosos vigentes";
            // 
            // pnlParams
            // 
            this.pnlParams.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlParams.Controls.Add(this.nudMaxMora);
            this.pnlParams.Controls.Add(this.nudMinMora);
            this.pnlParams.Controls.Add(this.nudMaxCredito);
            this.pnlParams.Controls.Add(this.nudMinCredito);
            this.pnlParams.Controls.Add(this.txtNombre);
            this.pnlParams.Controls.Add(this.txtId);
            this.pnlParams.Controls.Add(this.btnBuscar);
            this.pnlParams.Controls.Add(this.ckbCategoriaF);
            this.pnlParams.Controls.Add(this.ckbCategoriaD);
            this.pnlParams.Controls.Add(this.ckbCategoriaC);
            this.pnlParams.Controls.Add(this.ckbCategoriaB);
            this.pnlParams.Controls.Add(this.lblCategoria);
            this.pnlParams.Controls.Add(this.lblMoraMax);
            this.pnlParams.Controls.Add(this.lblMoraMin);
            this.pnlParams.Controls.Add(this.lblMora);
            this.pnlParams.Controls.Add(this.lblNombre);
            this.pnlParams.Controls.Add(this.lblValorMax);
            this.pnlParams.Controls.Add(this.lblValorMin);
            this.pnlParams.Controls.Add(this.lblValor);
            this.pnlParams.Controls.Add(this.lblID);
            this.pnlParams.Controls.Add(this.lblTitulo);
            this.pnlParams.Location = new System.Drawing.Point(176, 64);
            this.pnlParams.Margin = new System.Windows.Forms.Padding(2);
            this.pnlParams.Name = "pnlParams";
            this.pnlParams.Size = new System.Drawing.Size(703, 204);
            this.pnlParams.TabIndex = 30;
            // 
            // nudMaxMora
            // 
            this.nudMaxMora.DecimalPlaces = 2;
            this.nudMaxMora.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaxMora.Location = new System.Drawing.Point(477, 131);
            this.nudMaxMora.Margin = new System.Windows.Forms.Padding(2);
            this.nudMaxMora.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.nudMaxMora.Name = "nudMaxMora";
            this.nudMaxMora.Size = new System.Drawing.Size(70, 26);
            this.nudMaxMora.TabIndex = 6;
            // 
            // nudMinMora
            // 
            this.nudMinMora.DecimalPlaces = 2;
            this.nudMinMora.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinMora.Location = new System.Drawing.Point(336, 131);
            this.nudMinMora.Margin = new System.Windows.Forms.Padding(2);
            this.nudMinMora.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.nudMinMora.Name = "nudMinMora";
            this.nudMinMora.Size = new System.Drawing.Size(70, 26);
            this.nudMinMora.TabIndex = 5;
            // 
            // nudMaxCredito
            // 
            this.nudMaxCredito.DecimalPlaces = 2;
            this.nudMaxCredito.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaxCredito.Location = new System.Drawing.Point(203, 131);
            this.nudMaxCredito.Margin = new System.Windows.Forms.Padding(2);
            this.nudMaxCredito.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.nudMaxCredito.Name = "nudMaxCredito";
            this.nudMaxCredito.Size = new System.Drawing.Size(70, 26);
            this.nudMaxCredito.TabIndex = 4;
            // 
            // nudMinCredito
            // 
            this.nudMinCredito.DecimalPlaces = 2;
            this.nudMinCredito.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinCredito.Location = new System.Drawing.Point(65, 130);
            this.nudMinCredito.Margin = new System.Windows.Forms.Padding(2);
            this.nudMinCredito.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.nudMinCredito.Name = "nudMinCredito";
            this.nudMinCredito.Size = new System.Drawing.Size(70, 26);
            this.nudMinCredito.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(393, 61);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(298, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(121, 61);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(92, 26);
            this.txtId.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.BackgroundImage = global::SIG_LaFamiliar.Properties.Resources.magnifier;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(661, 128);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(30, 32);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // ckbCategoriaF
            // 
            this.ckbCategoriaF.AutoSize = true;
            this.ckbCategoriaF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbCategoriaF.Depth = 0;
            this.ckbCategoriaF.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckbCategoriaF.Location = new System.Drawing.Point(609, 158);
            this.ckbCategoriaF.Margin = new System.Windows.Forms.Padding(0);
            this.ckbCategoriaF.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbCategoriaF.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbCategoriaF.Name = "ckbCategoriaF";
            this.ckbCategoriaF.Ripple = true;
            this.ckbCategoriaF.Size = new System.Drawing.Size(37, 30);
            this.ckbCategoriaF.TabIndex = 10;
            this.ckbCategoriaF.Text = "F";
            this.ckbCategoriaF.UseVisualStyleBackColor = true;
            // 
            // ckbCategoriaD
            // 
            this.ckbCategoriaD.AutoSize = true;
            this.ckbCategoriaD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbCategoriaD.Depth = 0;
            this.ckbCategoriaD.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckbCategoriaD.Location = new System.Drawing.Point(564, 158);
            this.ckbCategoriaD.Margin = new System.Windows.Forms.Padding(0);
            this.ckbCategoriaD.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbCategoriaD.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbCategoriaD.Name = "ckbCategoriaD";
            this.ckbCategoriaD.Ripple = true;
            this.ckbCategoriaD.Size = new System.Drawing.Size(39, 30);
            this.ckbCategoriaD.TabIndex = 9;
            this.ckbCategoriaD.Text = "D";
            this.ckbCategoriaD.UseVisualStyleBackColor = true;
            // 
            // ckbCategoriaC
            // 
            this.ckbCategoriaC.AutoSize = true;
            this.ckbCategoriaC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbCategoriaC.Depth = 0;
            this.ckbCategoriaC.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckbCategoriaC.Location = new System.Drawing.Point(609, 128);
            this.ckbCategoriaC.Margin = new System.Windows.Forms.Padding(0);
            this.ckbCategoriaC.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbCategoriaC.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbCategoriaC.Name = "ckbCategoriaC";
            this.ckbCategoriaC.Ripple = true;
            this.ckbCategoriaC.Size = new System.Drawing.Size(39, 30);
            this.ckbCategoriaC.TabIndex = 8;
            this.ckbCategoriaC.Text = "C";
            this.ckbCategoriaC.UseVisualStyleBackColor = true;
            // 
            // ckbCategoriaB
            // 
            this.ckbCategoriaB.AutoSize = true;
            this.ckbCategoriaB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbCategoriaB.Depth = 0;
            this.ckbCategoriaB.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckbCategoriaB.Location = new System.Drawing.Point(564, 128);
            this.ckbCategoriaB.Margin = new System.Windows.Forms.Padding(0);
            this.ckbCategoriaB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbCategoriaB.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbCategoriaB.Name = "ckbCategoriaB";
            this.ckbCategoriaB.Ripple = true;
            this.ckbCategoriaB.Size = new System.Drawing.Size(39, 30);
            this.ckbCategoriaB.TabIndex = 7;
            this.ckbCategoriaB.Text = "B";
            this.ckbCategoriaB.UseVisualStyleBackColor = true;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Depth = 0;
            this.lblCategoria.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategoria.Location = new System.Drawing.Point(566, 106);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(82, 19);
            this.lblCategoria.TabIndex = 38;
            this.lblCategoria.Text = "Categoría: ";
            // 
            // lblMoraMax
            // 
            this.lblMoraMax.AutoSize = true;
            this.lblMoraMax.Depth = 0;
            this.lblMoraMax.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMoraMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMoraMax.Location = new System.Drawing.Point(410, 133);
            this.lblMoraMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoraMax.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMoraMax.Name = "lblMoraMax";
            this.lblMoraMax.Size = new System.Drawing.Size(63, 19);
            this.lblMoraMax.TabIndex = 37;
            this.lblMoraMax.Text = "Máx.($):";
            // 
            // lblMoraMin
            // 
            this.lblMoraMin.AutoSize = true;
            this.lblMoraMin.Depth = 0;
            this.lblMoraMin.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMoraMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMoraMin.Location = new System.Drawing.Point(277, 133);
            this.lblMoraMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoraMin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMoraMin.Name = "lblMoraMin";
            this.lblMoraMin.Size = new System.Drawing.Size(56, 19);
            this.lblMoraMin.TabIndex = 36;
            this.lblMoraMin.Text = "Min($):";
            // 
            // lblMora
            // 
            this.lblMora.AutoSize = true;
            this.lblMora.Depth = 0;
            this.lblMora.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMora.Location = new System.Drawing.Point(350, 106);
            this.lblMora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMora.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMora.Name = "lblMora";
            this.lblMora.Size = new System.Drawing.Size(124, 19);
            this.lblMora.TabIndex = 35;
            this.lblMora.Text = "Valor de la mora:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.CausesValidation = false;
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(256, 64);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(133, 19);
            this.lblNombre.TabIndex = 34;
            this.lblNombre.Text = "Nombre asociado:";
            // 
            // lblValorMax
            // 
            this.lblValorMax.AutoSize = true;
            this.lblValorMax.Depth = 0;
            this.lblValorMax.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblValorMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblValorMax.Location = new System.Drawing.Point(139, 134);
            this.lblValorMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorMax.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblValorMax.Name = "lblValorMax";
            this.lblValorMax.Size = new System.Drawing.Size(63, 19);
            this.lblValorMax.TabIndex = 33;
            this.lblValorMax.Text = "Máx.($):";
            // 
            // lblValorMin
            // 
            this.lblValorMin.AutoSize = true;
            this.lblValorMin.Depth = 0;
            this.lblValorMin.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblValorMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblValorMin.Location = new System.Drawing.Point(8, 134);
            this.lblValorMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorMin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblValorMin.Name = "lblValorMin";
            this.lblValorMin.Size = new System.Drawing.Size(56, 19);
            this.lblValorMin.TabIndex = 32;
            this.lblValorMin.Text = "Min($):";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Depth = 0;
            this.lblValor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblValor.Location = new System.Drawing.Point(76, 106);
            this.lblValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(124, 19);
            this.lblValor.TabIndex = 31;
            this.lblValor.Text = "Valor del crédito:";
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
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPrincipal.Controls.Add(this.btnExcel);
            this.pnlPrincipal.Controls.Add(this.btnWordDoc);
            this.pnlPrincipal.Controls.Add(this.btnPDFDoc);
            this.pnlPrincipal.Controls.Add(this.btnImprimir);
            this.pnlPrincipal.Location = new System.Drawing.Point(176, 290);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(703, 336);
            this.pnlPrincipal.TabIndex = 50;
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
            this.btnExcel.TabIndex = 12;
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
            this.btnWordDoc.TabIndex = 13;
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
            this.btnPDFDoc.TabIndex = 14;
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
            this.btnImprimir.TabIndex = 15;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // pnlEspacio
            // 
            this.pnlEspacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.pnlEspacio.Location = new System.Drawing.Point(0, 558);
            this.pnlEspacio.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEspacio.Name = "pnlEspacio";
            this.pnlEspacio.Size = new System.Drawing.Size(158, 81);
            this.pnlEspacio.TabIndex = 57;
            // 
            // btnMorososTipo
            // 
            this.btnMorososTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMorososTipo.Depth = 0;
            this.btnMorososTipo.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorososTipo.Location = new System.Drawing.Point(0, 328);
            this.btnMorososTipo.Margin = new System.Windows.Forms.Padding(2);
            this.btnMorososTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMorososTipo.Name = "btnMorososTipo";
            this.btnMorososTipo.Primary = true;
            this.btnMorososTipo.Size = new System.Drawing.Size(159, 45);
            this.btnMorososTipo.TabIndex = 56;
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
            this.btnMorososHistoricos.Location = new System.Drawing.Point(0, 282);
            this.btnMorososHistoricos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMorososHistoricos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMorososHistoricos.Name = "btnMorososHistoricos";
            this.btnMorososHistoricos.Primary = true;
            this.btnMorososHistoricos.Size = new System.Drawing.Size(159, 45);
            this.btnMorososHistoricos.TabIndex = 55;
            this.btnMorososHistoricos.TabStop = false;
            this.btnMorososHistoricos.Text = "Morosos históricos";
            this.btnMorososHistoricos.UseVisualStyleBackColor = true;
            this.btnMorososHistoricos.Click += new System.EventHandler(this.btnMorososHistoricos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(0, 512);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(158, 44);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSalir.TabIndex = 54;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCreditos
            // 
            this.btnCreditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreditos.Depth = 0;
            this.btnCreditos.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditos.Location = new System.Drawing.Point(0, 466);
            this.btnCreditos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreditos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Primary = true;
            this.btnCreditos.Size = new System.Drawing.Size(159, 45);
            this.btnCreditos.TabIndex = 53;
            this.btnCreditos.TabStop = false;
            this.btnCreditos.Text = "Créditos morosos completados";
            this.btnCreditos.UseVisualStyleBackColor = true;
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // btnAsociados
            // 
            this.btnAsociados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsociados.Depth = 0;
            this.btnAsociados.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsociados.Location = new System.Drawing.Point(0, 420);
            this.btnAsociados.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsociados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAsociados.Name = "btnAsociados";
            this.btnAsociados.Primary = true;
            this.btnAsociados.Size = new System.Drawing.Size(159, 45);
            this.btnAsociados.TabIndex = 52;
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
            this.btnProyeccion.Location = new System.Drawing.Point(0, 374);
            this.btnProyeccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnProyeccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProyeccion.Name = "btnProyeccion";
            this.btnProyeccion.Primary = true;
            this.btnProyeccion.Size = new System.Drawing.Size(159, 45);
            this.btnProyeccion.TabIndex = 51;
            this.btnProyeccion.TabStop = false;
            this.btnProyeccion.Text = "Proyección de pagos";
            this.btnProyeccion.UseVisualStyleBackColor = true;
            this.btnProyeccion.Click += new System.EventHandler(this.btnProyeccion_Click);
            // 
            // btnMorososVigentes
            // 
            this.btnMorososVigentes.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMorososVigentes.Depth = 0;
            this.btnMorososVigentes.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorososVigentes.Location = new System.Drawing.Point(0, 236);
            this.btnMorososVigentes.Margin = new System.Windows.Forms.Padding(2);
            this.btnMorososVigentes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMorososVigentes.Name = "btnMorososVigentes";
            this.btnMorososVigentes.Primary = true;
            this.btnMorososVigentes.Size = new System.Drawing.Size(159, 45);
            this.btnMorososVigentes.TabIndex = 50;
            this.btnMorososVigentes.TabStop = false;
            this.btnMorososVigentes.Text = "Morosos vigentes";
            this.btnMorososVigentes.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Depth = 0;
            this.btnInicio.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(0, 190);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Primary = true;
            this.btnInicio.Size = new System.Drawing.Size(159, 45);
            this.btnInicio.TabIndex = 49;
            this.btnInicio.TabStop = false;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(0, 63);
            this.pcbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(158, 126);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 48;
            this.pcbLogo.TabStop = false;
            // 
            // FormMorososVigentes
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
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.btnCreditos);
            this.Controls.Add(this.btnMorososVigentes);
            this.Controls.Add(this.btnAsociados);
            this.Controls.Add(this.btnProyeccion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 640);
            this.MinimumSize = new System.Drawing.Size(900, 590);
            this.Name = "FormMorososVigentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Información Gerencial para el Apoyo al Análisis de la Morosidad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMorososVigentes_FormClosed);
            this.pnlParams.ResumeLayout(false);
            this.pnlParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxMora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinMora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinCredito)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlParams;
        private MaterialSkin.Controls.MaterialLabel lblValorMax;
        private MaterialSkin.Controls.MaterialLabel lblValorMin;
        private MaterialSkin.Controls.MaterialLabel lblValor;
        private MaterialSkin.Controls.MaterialLabel lblID;
        private MaterialSkin.Controls.MaterialCheckBox ckbCategoriaF;
        private MaterialSkin.Controls.MaterialCheckBox ckbCategoriaD;
        private MaterialSkin.Controls.MaterialCheckBox ckbCategoriaC;
        private MaterialSkin.Controls.MaterialCheckBox ckbCategoriaB;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        private MaterialSkin.Controls.MaterialLabel lblMoraMax;
        private MaterialSkin.Controls.MaterialLabel lblMoraMin;
        private MaterialSkin.Controls.MaterialLabel lblMora;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.NumericUpDown nudMaxMora;
        private System.Windows.Forms.NumericUpDown nudMinMora;
        private System.Windows.Forms.NumericUpDown nudMaxCredito;
        private System.Windows.Forms.NumericUpDown nudMinCredito;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnWordDoc;
        private System.Windows.Forms.Button btnPDFDoc;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Panel pnlEspacio;
        private MaterialSkin.Controls.MaterialRaisedButton btnMorososTipo;
        private MaterialSkin.Controls.MaterialRaisedButton btnMorososHistoricos;
        private System.Windows.Forms.PictureBox btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnCreditos;
        private MaterialSkin.Controls.MaterialRaisedButton btnAsociados;
        private MaterialSkin.Controls.MaterialRaisedButton btnProyeccion;
        private MaterialSkin.Controls.MaterialRaisedButton btnMorososVigentes;
        private MaterialSkin.Controls.MaterialRaisedButton btnInicio;
        private System.Windows.Forms.PictureBox pcbLogo;
    }
}