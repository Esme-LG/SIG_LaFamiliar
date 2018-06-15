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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudPlazo = new System.Windows.Forms.NumericUpDown();
            this.nudCuota = new System.Windows.Forms.NumericUpDown();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblCredito = new MaterialSkin.Controls.MaterialLabel();
            this.lblProyeccion = new System.Windows.Forms.Label();
            this.rdbCuota = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbPlazo = new MaterialSkin.Controls.MaterialRadioButton();
            this.lblPAsociado = new System.Windows.Forms.Label();
            this.lblPMora = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblPagos = new System.Windows.Forms.Label();
            this.lblCuota = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblMora = new MaterialSkin.Controls.MaterialLabel();
            this.lblPagosActual = new MaterialSkin.Controls.MaterialLabel();
            this.lblCuotaActual = new MaterialSkin.Controls.MaterialLabel();
            this.lblNuevaCuota = new MaterialSkin.Controls.MaterialLabel();
            this.lblCantidadNueva = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlazo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuota)).BeginInit();
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
            this.btnProyeccion.Enabled = false;
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
            this.btnMorososTipo.Click += new System.EventHandler(this.btnMorososTipo_Click);
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
            this.panel2.Location = new System.Drawing.Point(238, 363);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 414);
            this.panel2.TabIndex = 52;
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
            this.panel1.Location = new System.Drawing.Point(238, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 251);
            this.panel1.TabIndex = 51;
            // 
            // nudPlazo
            // 
            this.nudPlazo.DecimalPlaces = 2;
            this.nudPlazo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPlazo.Location = new System.Drawing.Point(461, 178);
            this.nudPlazo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPlazo.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.nudPlazo.Name = "nudPlazo";
            this.nudPlazo.Size = new System.Drawing.Size(93, 30);
            this.nudPlazo.TabIndex = 47;
            // 
            // nudCuota
            // 
            this.nudCuota.DecimalPlaces = 2;
            this.nudCuota.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCuota.Location = new System.Drawing.Point(461, 125);
            this.nudCuota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudCuota.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.nudCuota.Name = "nudCuota";
            this.nudCuota.Size = new System.Drawing.Size(93, 30);
            this.nudCuota.TabIndex = 46;
            // 
            // txtCredito
            // 
            this.txtCredito.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredito.Location = new System.Drawing.Point(461, 73);
            this.txtCredito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(162, 30);
            this.txtCredito.TabIndex = 44;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.BackgroundImage = global::SIG_LaFamiliar.Properties.Resources.magnifier;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(869, 175);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 39);
            this.btnBuscar.TabIndex = 43;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(13, 188);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(0, 24);
            this.materialLabel3.TabIndex = 32;
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Depth = 0;
            this.lblCredito.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCredito.Location = new System.Drawing.Point(293, 79);
            this.lblCredito.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(76, 24);
            this.lblCredito.TabIndex = 30;
            this.lblCredito.Text = "Crédito:";
            // 
            // lblProyeccion
            // 
            this.lblProyeccion.AutoSize = true;
            this.lblProyeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyeccion.Location = new System.Drawing.Point(361, 18);
            this.lblProyeccion.Name = "lblProyeccion";
            this.lblProyeccion.Size = new System.Drawing.Size(259, 29);
            this.lblProyeccion.TabIndex = 29;
            this.lblProyeccion.Text = "Proyección de pagos";
            // 
            // rdbCuota
            // 
            this.rdbCuota.AutoSize = true;
            this.rdbCuota.Depth = 0;
            this.rdbCuota.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbCuota.Location = new System.Drawing.Point(207, 125);
            this.rdbCuota.Margin = new System.Windows.Forms.Padding(0);
            this.rdbCuota.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbCuota.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbCuota.Name = "rdbCuota";
            this.rdbCuota.Ripple = true;
            this.rdbCuota.Size = new System.Drawing.Size(162, 30);
            this.rdbCuota.TabIndex = 48;
            this.rdbCuota.TabStop = true;
            this.rdbCuota.Text = "Cuota propuesta:";
            this.rdbCuota.UseVisualStyleBackColor = true;
            // 
            // rdbPlazo
            // 
            this.rdbPlazo.AutoSize = true;
            this.rdbPlazo.Depth = 0;
            this.rdbPlazo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbPlazo.Location = new System.Drawing.Point(207, 178);
            this.rdbPlazo.Margin = new System.Windows.Forms.Padding(0);
            this.rdbPlazo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbPlazo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbPlazo.Name = "rdbPlazo";
            this.rdbPlazo.Ripple = true;
            this.rdbPlazo.Size = new System.Drawing.Size(228, 30);
            this.rdbPlazo.TabIndex = 49;
            this.rdbPlazo.TabStop = true;
            this.rdbPlazo.Text = "Plazo restante propuesto:";
            this.rdbPlazo.UseVisualStyleBackColor = true;
            // 
            // lblPAsociado
            // 
            this.lblPAsociado.AutoSize = true;
            this.lblPAsociado.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPAsociado.Location = new System.Drawing.Point(52, 55);
            this.lblPAsociado.Name = "lblPAsociado";
            this.lblPAsociado.Size = new System.Drawing.Size(96, 22);
            this.lblPAsociado.TabIndex = 48;
            this.lblPAsociado.Text = "Asociado:";
            // 
            // lblPMora
            // 
            this.lblPMora.AutoSize = true;
            this.lblPMora.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMora.Location = new System.Drawing.Point(52, 102);
            this.lblPMora.Name = "lblPMora";
            this.lblPMora.Size = new System.Drawing.Size(60, 22);
            this.lblPMora.TabIndex = 49;
            this.lblPMora.Text = "Mora:";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlan.Location = new System.Drawing.Point(120, 184);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(104, 22);
            this.lblPlan.TabIndex = 50;
            this.lblPlan.Text = "Plan actual";
            // 
            // lblPagos
            // 
            this.lblPagos.AutoSize = true;
            this.lblPagos.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagos.Location = new System.Drawing.Point(486, 285);
            this.lblPagos.Name = "lblPagos";
            this.lblPagos.Size = new System.Drawing.Size(262, 22);
            this.lblPagos.TabIndex = 51;
            this.lblPagos.Text = "Cantidad de pagos restantes:";
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuota.Location = new System.Drawing.Point(61, 241);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(66, 22);
            this.lblCuota.TabIndex = 52;
            this.lblCuota.Text = "Cuota:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(573, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 22);
            this.label7.TabIndex = 53;
            this.label7.Text = "Nuevo plan";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(160, 55);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(123, 22);
            this.materialLabel1.TabIndex = 56;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // lblMora
            // 
            this.lblMora.AutoSize = true;
            this.lblMora.Depth = 0;
            this.lblMora.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMora.Location = new System.Drawing.Point(160, 102);
            this.lblMora.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMora.Name = "lblMora";
            this.lblMora.Size = new System.Drawing.Size(123, 22);
            this.lblMora.TabIndex = 57;
            this.lblMora.Text = "materialLabel2";
            // 
            // lblPagosActual
            // 
            this.lblPagosActual.AutoSize = true;
            this.lblPagosActual.Depth = 0;
            this.lblPagosActual.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagosActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPagosActual.Location = new System.Drawing.Point(336, 285);
            this.lblPagosActual.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPagosActual.Name = "lblPagosActual";
            this.lblPagosActual.Size = new System.Drawing.Size(123, 22);
            this.lblPagosActual.TabIndex = 58;
            this.lblPagosActual.Text = "materialLabel4";
            // 
            // lblCuotaActual
            // 
            this.lblCuotaActual.AutoSize = true;
            this.lblCuotaActual.Depth = 0;
            this.lblCuotaActual.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotaActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCuotaActual.Location = new System.Drawing.Point(145, 241);
            this.lblCuotaActual.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCuotaActual.Name = "lblCuotaActual";
            this.lblCuotaActual.Size = new System.Drawing.Size(123, 22);
            this.lblCuotaActual.TabIndex = 59;
            this.lblCuotaActual.Text = "materialLabel5";
            // 
            // lblNuevaCuota
            // 
            this.lblNuevaCuota.AutoSize = true;
            this.lblNuevaCuota.Depth = 0;
            this.lblNuevaCuota.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaCuota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNuevaCuota.Location = new System.Drawing.Point(554, 241);
            this.lblNuevaCuota.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNuevaCuota.Name = "lblNuevaCuota";
            this.lblNuevaCuota.Size = new System.Drawing.Size(123, 22);
            this.lblNuevaCuota.TabIndex = 60;
            this.lblNuevaCuota.Text = "materialLabel6";
            // 
            // lblCantidadNueva
            // 
            this.lblCantidadNueva.AutoSize = true;
            this.lblCantidadNueva.Depth = 0;
            this.lblCantidadNueva.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadNueva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCantidadNueva.Location = new System.Drawing.Point(754, 285);
            this.lblCantidadNueva.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCantidadNueva.Name = "lblCantidadNueva";
            this.lblCantidadNueva.Size = new System.Drawing.Size(123, 22);
            this.lblCantidadNueva.TabIndex = 61;
            this.lblCantidadNueva.Text = "materialLabel7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 63;
            this.label1.Text = "Cuota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 22);
            this.label2.TabIndex = 62;
            this.label2.Text = "Cantidad de pagos restantes:";
            // 
            // FormProyeccion
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
            this.Name = "FormProyeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Información Gerencial para el Apoyo al Análisis de la Morosidad";
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlazo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuota)).EndInit();
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
    }
}