namespace SIG_LaFamiliar.Forms.Tactico
{
    partial class FormProyeccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProyeccion));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantidadNueva = new MaterialSkin.Controls.MaterialLabel();
            this.lblNuevaCuota = new MaterialSkin.Controls.MaterialLabel();
            this.lblCuotaActual = new MaterialSkin.Controls.MaterialLabel();
            this.lblPagosActual = new MaterialSkin.Controls.MaterialLabel();
            this.lblMora = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCuota = new System.Windows.Forms.Label();
            this.lblPagos = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblPMora = new System.Windows.Forms.Label();
            this.lblPAsociado = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnWordDoc = new System.Windows.Forms.Button();
            this.btnPDFDoc = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbPlazo = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbCuota = new MaterialSkin.Controls.MaterialRadioButton();
            this.nudPlazo = new System.Windows.Forms.NumericUpDown();
            this.nudCuota = new System.Windows.Forms.NumericUpDown();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblCredito = new MaterialSkin.Controls.MaterialLabel();
            this.lblProyeccion = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlazo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblCantidadNueva);
            this.panel2.Controls.Add(this.lblNuevaCuota);
            this.panel2.Controls.Add(this.lblCuotaActual);
            this.panel2.Controls.Add(this.lblPagosActual);
            this.panel2.Controls.Add(this.lblMora);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblCuota);
            this.panel2.Controls.Add(this.lblPagos);
            this.panel2.Controls.Add(this.lblPlan);
            this.panel2.Controls.Add(this.lblPMora);
            this.panel2.Controls.Add(this.lblPAsociado);
            this.panel2.Controls.Add(this.btnExcel);
            this.panel2.Controls.Add(this.btnWordDoc);
            this.panel2.Controls.Add(this.btnPDFDoc);
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(178, 295);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 336);
            this.panel2.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Cuota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Cantidad de pagos restantes:";
            // 
            // lblCantidadNueva
            // 
            this.lblCantidadNueva.AutoSize = true;
            this.lblCantidadNueva.Depth = 0;
            this.lblCantidadNueva.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCantidadNueva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCantidadNueva.Location = new System.Drawing.Point(566, 232);
            this.lblCantidadNueva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadNueva.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCantidadNueva.Name = "lblCantidadNueva";
            this.lblCantidadNueva.Size = new System.Drawing.Size(108, 19);
            this.lblCantidadNueva.TabIndex = 61;
            this.lblCantidadNueva.Text = "materialLabel7";
            // 
            // lblNuevaCuota
            // 
            this.lblNuevaCuota.AutoSize = true;
            this.lblNuevaCuota.Depth = 0;
            this.lblNuevaCuota.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNuevaCuota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNuevaCuota.Location = new System.Drawing.Point(416, 196);
            this.lblNuevaCuota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNuevaCuota.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNuevaCuota.Name = "lblNuevaCuota";
            this.lblNuevaCuota.Size = new System.Drawing.Size(108, 19);
            this.lblNuevaCuota.TabIndex = 60;
            this.lblNuevaCuota.Text = "materialLabel6";
            // 
            // lblCuotaActual
            // 
            this.lblCuotaActual.AutoSize = true;
            this.lblCuotaActual.Depth = 0;
            this.lblCuotaActual.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCuotaActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCuotaActual.Location = new System.Drawing.Point(109, 196);
            this.lblCuotaActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuotaActual.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCuotaActual.Name = "lblCuotaActual";
            this.lblCuotaActual.Size = new System.Drawing.Size(108, 19);
            this.lblCuotaActual.TabIndex = 59;
            this.lblCuotaActual.Text = "materialLabel5";
            // 
            // lblPagosActual
            // 
            this.lblPagosActual.AutoSize = true;
            this.lblPagosActual.Depth = 0;
            this.lblPagosActual.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPagosActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPagosActual.Location = new System.Drawing.Point(252, 232);
            this.lblPagosActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPagosActual.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPagosActual.Name = "lblPagosActual";
            this.lblPagosActual.Size = new System.Drawing.Size(108, 19);
            this.lblPagosActual.TabIndex = 58;
            this.lblPagosActual.Text = "materialLabel4";
            // 
            // lblMora
            // 
            this.lblMora.AutoSize = true;
            this.lblMora.Depth = 0;
            this.lblMora.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMora.Location = new System.Drawing.Point(120, 83);
            this.lblMora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMora.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMora.Name = "lblMora";
            this.lblMora.Size = new System.Drawing.Size(108, 19);
            this.lblMora.TabIndex = 57;
            this.lblMora.Text = "materialLabel2";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(120, 45);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 19);
            this.materialLabel1.TabIndex = 56;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(430, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Nuevo plan";
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuota.Location = new System.Drawing.Point(46, 196);
            this.lblCuota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(50, 17);
            this.lblCuota.TabIndex = 52;
            this.lblCuota.Text = "Cuota:";
            // 
            // lblPagos
            // 
            this.lblPagos.AutoSize = true;
            this.lblPagos.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagos.Location = new System.Drawing.Point(364, 232);
            this.lblPagos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPagos.Name = "lblPagos";
            this.lblPagos.Size = new System.Drawing.Size(195, 17);
            this.lblPagos.TabIndex = 51;
            this.lblPagos.Text = "Cantidad de pagos restantes:";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlan.Location = new System.Drawing.Point(90, 150);
            this.lblPlan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(80, 17);
            this.lblPlan.TabIndex = 50;
            this.lblPlan.Text = "Plan actual";
            // 
            // lblPMora
            // 
            this.lblPMora.AutoSize = true;
            this.lblPMora.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMora.Location = new System.Drawing.Point(39, 83);
            this.lblPMora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPMora.Name = "lblPMora";
            this.lblPMora.Size = new System.Drawing.Size(45, 17);
            this.lblPMora.TabIndex = 49;
            this.lblPMora.Text = "Mora:";
            // 
            // lblPAsociado
            // 
            this.lblPAsociado.AutoSize = true;
            this.lblPAsociado.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPAsociado.Location = new System.Drawing.Point(39, 45);
            this.lblPAsociado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPAsociado.Name = "lblPAsociado";
            this.lblPAsociado.Size = new System.Drawing.Size(71, 17);
            this.lblPAsociado.TabIndex = 48;
            this.lblPAsociado.Text = "Asociado:";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.rdbPlazo);
            this.panel1.Controls.Add(this.rdbCuota);
            this.panel1.Controls.Add(this.nudPlazo);
            this.panel1.Controls.Add(this.nudCuota);
            this.panel1.Controls.Add(this.txtCredito);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.lblCredito);
            this.panel1.Controls.Add(this.lblProyeccion);
            this.panel1.Location = new System.Drawing.Point(178, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 204);
            this.panel1.TabIndex = 51;
            // 
            // rdbPlazo
            // 
            this.rdbPlazo.AutoSize = true;
            this.rdbPlazo.Depth = 0;
            this.rdbPlazo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbPlazo.Location = new System.Drawing.Point(155, 145);
            this.rdbPlazo.Margin = new System.Windows.Forms.Padding(0);
            this.rdbPlazo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbPlazo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbPlazo.Name = "rdbPlazo";
            this.rdbPlazo.Ripple = true;
            this.rdbPlazo.Size = new System.Drawing.Size(187, 30);
            this.rdbPlazo.TabIndex = 49;
            this.rdbPlazo.TabStop = true;
            this.rdbPlazo.Text = "Plazo restante propuesto:";
            this.rdbPlazo.UseVisualStyleBackColor = true;
            // 
            // rdbCuota
            // 
            this.rdbCuota.AutoSize = true;
            this.rdbCuota.Depth = 0;
            this.rdbCuota.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbCuota.Location = new System.Drawing.Point(155, 102);
            this.rdbCuota.Margin = new System.Windows.Forms.Padding(0);
            this.rdbCuota.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbCuota.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbCuota.Name = "rdbCuota";
            this.rdbCuota.Ripple = true;
            this.rdbCuota.Size = new System.Drawing.Size(135, 30);
            this.rdbCuota.TabIndex = 48;
            this.rdbCuota.TabStop = true;
            this.rdbCuota.Text = "Cuota propuesta:";
            this.rdbCuota.UseVisualStyleBackColor = true;
            // 
            // nudPlazo
            // 
            this.nudPlazo.DecimalPlaces = 2;
            this.nudPlazo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPlazo.Location = new System.Drawing.Point(346, 145);
            this.nudPlazo.Margin = new System.Windows.Forms.Padding(2);
            this.nudPlazo.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.nudPlazo.Name = "nudPlazo";
            this.nudPlazo.Size = new System.Drawing.Size(70, 26);
            this.nudPlazo.TabIndex = 47;
            // 
            // nudCuota
            // 
            this.nudCuota.DecimalPlaces = 2;
            this.nudCuota.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCuota.Location = new System.Drawing.Point(346, 102);
            this.nudCuota.Margin = new System.Windows.Forms.Padding(2);
            this.nudCuota.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.nudCuota.Name = "nudCuota";
            this.nudCuota.Size = new System.Drawing.Size(70, 26);
            this.nudCuota.TabIndex = 46;
            // 
            // txtCredito
            // 
            this.txtCredito.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredito.Location = new System.Drawing.Point(346, 59);
            this.txtCredito.Margin = new System.Windows.Forms.Padding(2);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(122, 26);
            this.txtCredito.TabIndex = 44;
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
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(10, 153);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(0, 19);
            this.materialLabel3.TabIndex = 32;
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Depth = 0;
            this.lblCredito.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCredito.Location = new System.Drawing.Point(220, 64);
            this.lblCredito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCredito.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(62, 19);
            this.lblCredito.TabIndex = 30;
            this.lblCredito.Text = "Crédito:";
            // 
            // lblProyeccion
            // 
            this.lblProyeccion.AutoSize = true;
            this.lblProyeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyeccion.Location = new System.Drawing.Point(271, 15);
            this.lblProyeccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProyeccion.Name = "lblProyeccion";
            this.lblProyeccion.Size = new System.Drawing.Size(208, 24);
            this.lblProyeccion.TabIndex = 29;
            this.lblProyeccion.Text = "Proyección de pagos";
            // 
            // pnlEspacio
            // 
            this.pnlEspacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.pnlEspacio.Location = new System.Drawing.Point(0, 559);
            this.pnlEspacio.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEspacio.Name = "pnlEspacio";
            this.pnlEspacio.Size = new System.Drawing.Size(158, 81);
            this.pnlEspacio.TabIndex = 73;
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
            this.btnMorososTipo.TabIndex = 72;
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
            this.btnMorososHistoricos.TabIndex = 71;
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
            this.pcbLogo.TabIndex = 64;
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
            this.btnSalir.TabIndex = 70;
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
            this.btnInicio.TabIndex = 65;
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
            this.btnCreditos.TabIndex = 69;
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
            this.btnMorososVigentes.TabIndex = 66;
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
            this.btnAsociados.TabIndex = 68;
            this.btnAsociados.Text = "Asociados por categoría";
            this.btnAsociados.UseVisualStyleBackColor = true;
            this.btnAsociados.Click += new System.EventHandler(this.btnAsociados_Click);
            // 
            // btnProyeccion
            // 
            this.btnProyeccion.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnProyeccion.Depth = 0;
            this.btnProyeccion.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyeccion.Location = new System.Drawing.Point(0, 375);
            this.btnProyeccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnProyeccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProyeccion.Name = "btnProyeccion";
            this.btnProyeccion.Primary = true;
            this.btnProyeccion.Size = new System.Drawing.Size(159, 45);
            this.btnProyeccion.TabIndex = 67;
            this.btnProyeccion.Text = "Proyección de pagos";
            this.btnProyeccion.UseVisualStyleBackColor = true;
            // 
            // FormProyeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.pnlEspacio);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnMorososTipo);
            this.Controls.Add(this.panel1);
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
            this.Name = "FormProyeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Información Gerencial para el Apoyo al Análisis de la Morosidad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProyeccion_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlazo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuota)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRadioButton rdbPlazo;
        private MaterialSkin.Controls.MaterialRadioButton rdbCuota;
        private System.Windows.Forms.NumericUpDown nudPlazo;
        private System.Windows.Forms.NumericUpDown nudCuota;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.Button btnBuscar;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblCredito;
        private System.Windows.Forms.Label lblProyeccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.Label lblPagos;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblPMora;
        private System.Windows.Forms.Label lblPAsociado;
        private MaterialSkin.Controls.MaterialLabel lblCantidadNueva;
        private MaterialSkin.Controls.MaterialLabel lblNuevaCuota;
        private MaterialSkin.Controls.MaterialLabel lblCuotaActual;
        private MaterialSkin.Controls.MaterialLabel lblPagosActual;
        private MaterialSkin.Controls.MaterialLabel lblMora;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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