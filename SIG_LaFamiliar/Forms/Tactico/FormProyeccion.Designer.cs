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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.lblPCuotaNueva = new System.Windows.Forms.Label();
            this.lblPPagosNuevo = new System.Windows.Forms.Label();
            this.lblPagosNuevo = new MaterialSkin.Controls.MaterialLabel();
            this.lblCuotaNueva = new MaterialSkin.Controls.MaterialLabel();
            this.lblCuotaActual = new MaterialSkin.Controls.MaterialLabel();
            this.lblPagosActual = new MaterialSkin.Controls.MaterialLabel();
            this.lblMora = new MaterialSkin.Controls.MaterialLabel();
            this.lblAsociado = new MaterialSkin.Controls.MaterialLabel();
            this.lblNuevoPlan = new System.Windows.Forms.Label();
            this.lblPCuotaActual = new System.Windows.Forms.Label();
            this.lblPPagosActual = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblPMora = new System.Windows.Forms.Label();
            this.lblPAsociado = new System.Windows.Forms.Label();
            this.pnlParams = new System.Windows.Forms.Panel();
            this.rdbPlazo = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbCuota = new MaterialSkin.Controls.MaterialRadioButton();
            this.nudPlazo = new System.Windows.Forms.NumericUpDown();
            this.nudCuota = new System.Windows.Forms.NumericUpDown();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblCredito = new MaterialSkin.Controls.MaterialLabel();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudPlazo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPrincipal.Controls.Add(this.lblPCuotaNueva);
            this.pnlPrincipal.Controls.Add(this.lblPPagosNuevo);
            this.pnlPrincipal.Controls.Add(this.lblPagosNuevo);
            this.pnlPrincipal.Controls.Add(this.lblCuotaNueva);
            this.pnlPrincipal.Controls.Add(this.lblCuotaActual);
            this.pnlPrincipal.Controls.Add(this.lblPagosActual);
            this.pnlPrincipal.Controls.Add(this.lblMora);
            this.pnlPrincipal.Controls.Add(this.lblAsociado);
            this.pnlPrincipal.Controls.Add(this.lblNuevoPlan);
            this.pnlPrincipal.Controls.Add(this.lblPCuotaActual);
            this.pnlPrincipal.Controls.Add(this.lblPPagosActual);
            this.pnlPrincipal.Controls.Add(this.lblPlan);
            this.pnlPrincipal.Controls.Add(this.lblPMora);
            this.pnlPrincipal.Controls.Add(this.lblPAsociado);
            this.pnlPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPrincipal.Location = new System.Drawing.Point(178, 295);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(703, 336);
            this.pnlPrincipal.TabIndex = 52;
            // 
            // lblPCuotaNueva
            // 
            this.lblPCuotaNueva.AutoSize = true;
            this.lblPCuotaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCuotaNueva.Location = new System.Drawing.Point(509, 200);
            this.lblPCuotaNueva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPCuotaNueva.Name = "lblPCuotaNueva";
            this.lblPCuotaNueva.Size = new System.Drawing.Size(55, 17);
            this.lblPCuotaNueva.TabIndex = 63;
            this.lblPCuotaNueva.Text = "Cuota:";
            // 
            // lblPPagosNuevo
            // 
            this.lblPPagosNuevo.AutoSize = true;
            this.lblPPagosNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPagosNuevo.Location = new System.Drawing.Point(364, 234);
            this.lblPPagosNuevo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPPagosNuevo.Name = "lblPPagosNuevo";
            this.lblPPagosNuevo.Size = new System.Drawing.Size(222, 17);
            this.lblPPagosNuevo.TabIndex = 62;
            this.lblPPagosNuevo.Text = "Cantidad de pagos restantes:";
            // 
            // lblPagosNuevo
            // 
            this.lblPagosNuevo.AutoSize = true;
            this.lblPagosNuevo.Depth = 0;
            this.lblPagosNuevo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPagosNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPagosNuevo.Location = new System.Drawing.Point(590, 232);
            this.lblPagosNuevo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPagosNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPagosNuevo.Name = "lblPagosNuevo";
            this.lblPagosNuevo.Size = new System.Drawing.Size(61, 19);
            this.lblPagosNuevo.TabIndex = 61;
            this.lblPagosNuevo.Text = "-------------";
            // 
            // lblCuotaNueva
            // 
            this.lblCuotaNueva.AutoSize = true;
            this.lblCuotaNueva.Depth = 0;
            this.lblCuotaNueva.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCuotaNueva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCuotaNueva.Location = new System.Drawing.Point(563, 198);
            this.lblCuotaNueva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuotaNueva.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCuotaNueva.Name = "lblCuotaNueva";
            this.lblCuotaNueva.Size = new System.Drawing.Size(37, 19);
            this.lblCuotaNueva.TabIndex = 60;
            this.lblCuotaNueva.Text = "$--.--";
            // 
            // lblCuotaActual
            // 
            this.lblCuotaActual.AutoSize = true;
            this.lblCuotaActual.Depth = 0;
            this.lblCuotaActual.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCuotaActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCuotaActual.Location = new System.Drawing.Point(237, 199);
            this.lblCuotaActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuotaActual.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCuotaActual.Name = "lblCuotaActual";
            this.lblCuotaActual.Size = new System.Drawing.Size(37, 19);
            this.lblCuotaActual.TabIndex = 59;
            this.lblCuotaActual.Text = "$--.--";
            // 
            // lblPagosActual
            // 
            this.lblPagosActual.AutoSize = true;
            this.lblPagosActual.Depth = 0;
            this.lblPagosActual.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPagosActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPagosActual.Location = new System.Drawing.Point(237, 233);
            this.lblPagosActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPagosActual.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPagosActual.Name = "lblPagosActual";
            this.lblPagosActual.Size = new System.Drawing.Size(53, 19);
            this.lblPagosActual.TabIndex = 58;
            this.lblPagosActual.Text = "-----------";
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
            this.lblMora.Size = new System.Drawing.Size(37, 19);
            this.lblMora.TabIndex = 57;
            this.lblMora.Text = "$--.--";
            // 
            // lblAsociado
            // 
            this.lblAsociado.AutoSize = true;
            this.lblAsociado.Depth = 0;
            this.lblAsociado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAsociado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAsociado.Location = new System.Drawing.Point(120, 45);
            this.lblAsociado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsociado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAsociado.Name = "lblAsociado";
            this.lblAsociado.Size = new System.Drawing.Size(212, 19);
            this.lblAsociado.TabIndex = 56;
            this.lblAsociado.Text = "------------------------------, -------------------";
            // 
            // lblNuevoPlan
            // 
            this.lblNuevoPlan.AutoSize = true;
            this.lblNuevoPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoPlan.Location = new System.Drawing.Point(512, 154);
            this.lblNuevoPlan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNuevoPlan.Name = "lblNuevoPlan";
            this.lblNuevoPlan.Size = new System.Drawing.Size(90, 17);
            this.lblNuevoPlan.TabIndex = 53;
            this.lblNuevoPlan.Text = "Nuevo plan";
            // 
            // lblPCuotaActual
            // 
            this.lblPCuotaActual.AutoSize = true;
            this.lblPCuotaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCuotaActual.Location = new System.Drawing.Point(156, 196);
            this.lblPCuotaActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPCuotaActual.Name = "lblPCuotaActual";
            this.lblPCuotaActual.Size = new System.Drawing.Size(55, 17);
            this.lblPCuotaActual.TabIndex = 52;
            this.lblPCuotaActual.Text = "Cuota:";
            // 
            // lblPPagosActual
            // 
            this.lblPPagosActual.AutoSize = true;
            this.lblPPagosActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPagosActual.Location = new System.Drawing.Point(11, 234);
            this.lblPPagosActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPPagosActual.Name = "lblPPagosActual";
            this.lblPPagosActual.Size = new System.Drawing.Size(222, 17);
            this.lblPPagosActual.TabIndex = 51;
            this.lblPPagosActual.Text = "Cantidad de pagos restantes:";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlan.Location = new System.Drawing.Point(166, 154);
            this.lblPlan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(89, 17);
            this.lblPlan.TabIndex = 50;
            this.lblPlan.Text = "Plan actual";
            // 
            // lblPMora
            // 
            this.lblPMora.AutoSize = true;
            this.lblPMora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMora.Location = new System.Drawing.Point(65, 85);
            this.lblPMora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPMora.Name = "lblPMora";
            this.lblPMora.Size = new System.Drawing.Size(49, 17);
            this.lblPMora.TabIndex = 49;
            this.lblPMora.Text = "Mora:";
            // 
            // lblPAsociado
            // 
            this.lblPAsociado.AutoSize = true;
            this.lblPAsociado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPAsociado.Location = new System.Drawing.Point(39, 45);
            this.lblPAsociado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPAsociado.Name = "lblPAsociado";
            this.lblPAsociado.Size = new System.Drawing.Size(79, 17);
            this.lblPAsociado.TabIndex = 48;
            this.lblPAsociado.Text = "Asociado:";
            // 
            // pnlParams
            // 
            this.pnlParams.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlParams.Controls.Add(this.rdbPlazo);
            this.pnlParams.Controls.Add(this.rdbCuota);
            this.pnlParams.Controls.Add(this.nudPlazo);
            this.pnlParams.Controls.Add(this.nudCuota);
            this.pnlParams.Controls.Add(this.txtCredito);
            this.pnlParams.Controls.Add(this.btnBuscar);
            this.pnlParams.Controls.Add(this.materialLabel3);
            this.pnlParams.Controls.Add(this.lblCredito);
            this.pnlParams.Controls.Add(this.lblTitulo);
            this.pnlParams.Location = new System.Drawing.Point(178, 64);
            this.pnlParams.Margin = new System.Windows.Forms.Padding(2);
            this.pnlParams.Name = "pnlParams";
            this.pnlParams.Size = new System.Drawing.Size(703, 204);
            this.pnlParams.TabIndex = 51;
            // 
            // rdbPlazo
            // 
            this.rdbPlazo.AutoSize = true;
            this.rdbPlazo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbPlazo.Depth = 0;
            this.rdbPlazo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbPlazo.Location = new System.Drawing.Point(155, 145);
            this.rdbPlazo.Margin = new System.Windows.Forms.Padding(0);
            this.rdbPlazo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbPlazo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbPlazo.Name = "rdbPlazo";
            this.rdbPlazo.Ripple = true;
            this.rdbPlazo.Size = new System.Drawing.Size(187, 30);
            this.rdbPlazo.TabIndex = 4;
            this.rdbPlazo.Text = "Plazo restante propuesto:";
            this.rdbPlazo.UseVisualStyleBackColor = true;
            this.rdbPlazo.CheckedChanged += new System.EventHandler(this.rdbPlazo_CheckedChanged);
            // 
            // rdbCuota
            // 
            this.rdbCuota.AutoSize = true;
            this.rdbCuota.Checked = true;
            this.rdbCuota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbCuota.Depth = 0;
            this.rdbCuota.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbCuota.Location = new System.Drawing.Point(155, 102);
            this.rdbCuota.Margin = new System.Windows.Forms.Padding(0);
            this.rdbCuota.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbCuota.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbCuota.Name = "rdbCuota";
            this.rdbCuota.Ripple = true;
            this.rdbCuota.Size = new System.Drawing.Size(135, 30);
            this.rdbCuota.TabIndex = 2;
            this.rdbCuota.TabStop = true;
            this.rdbCuota.Text = "Cuota propuesta:";
            this.rdbCuota.UseVisualStyleBackColor = true;
            this.rdbCuota.CheckedChanged += new System.EventHandler(this.rdbCuota_CheckedChanged);
            // 
            // nudPlazo
            // 
            this.nudPlazo.Enabled = false;
            this.nudPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPlazo.Location = new System.Drawing.Point(367, 143);
            this.nudPlazo.Margin = new System.Windows.Forms.Padding(2);
            this.nudPlazo.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudPlazo.Name = "nudPlazo";
            this.nudPlazo.Size = new System.Drawing.Size(70, 24);
            this.nudPlazo.TabIndex = 5;
            // 
            // nudCuota
            // 
            this.nudCuota.DecimalPlaces = 2;
            this.nudCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCuota.Location = new System.Drawing.Point(367, 102);
            this.nudCuota.Margin = new System.Windows.Forms.Padding(2);
            this.nudCuota.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.nudCuota.Name = "nudCuota";
            this.nudCuota.Size = new System.Drawing.Size(70, 24);
            this.nudCuota.TabIndex = 3;
            // 
            // txtCredito
            // 
            this.txtCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredito.Location = new System.Drawing.Point(346, 59);
            this.txtCredito.Margin = new System.Windows.Forms.Padding(2);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(122, 24);
            this.txtCredito.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.BackgroundImage = global::SIG_LaFamiliar.Properties.Resources.magnifier;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(529, 139);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(30, 32);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(256, 15);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(208, 24);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "Proyección de pagos";
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
            this.btnMorososTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorososTipo.Location = new System.Drawing.Point(0, 329);
            this.btnMorososTipo.Margin = new System.Windows.Forms.Padding(2);
            this.btnMorososTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMorososTipo.Name = "btnMorososTipo";
            this.btnMorososTipo.Primary = true;
            this.btnMorososTipo.Size = new System.Drawing.Size(159, 45);
            this.btnMorososTipo.TabIndex = 72;
            this.btnMorososTipo.TabStop = false;
            this.btnMorososTipo.Text = "Morosos por tipo de crédito";
            this.btnMorososTipo.UseVisualStyleBackColor = true;
            this.btnMorososTipo.Click += new System.EventHandler(this.btnMorososTipo_Click);
            // 
            // btnMorososHistoricos
            // 
            this.btnMorososHistoricos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMorososHistoricos.Depth = 0;
            this.btnMorososHistoricos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorososHistoricos.Location = new System.Drawing.Point(0, 283);
            this.btnMorososHistoricos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMorososHistoricos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMorososHistoricos.Name = "btnMorososHistoricos";
            this.btnMorososHistoricos.Primary = true;
            this.btnMorososHistoricos.Size = new System.Drawing.Size(159, 45);
            this.btnMorososHistoricos.TabIndex = 71;
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
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(0, 191);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Primary = true;
            this.btnInicio.Size = new System.Drawing.Size(159, 45);
            this.btnInicio.TabIndex = 65;
            this.btnInicio.TabStop = false;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnCreditos
            // 
            this.btnCreditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreditos.Depth = 0;
            this.btnCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditos.Location = new System.Drawing.Point(0, 467);
            this.btnCreditos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreditos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Primary = true;
            this.btnCreditos.Size = new System.Drawing.Size(159, 45);
            this.btnCreditos.TabIndex = 69;
            this.btnCreditos.TabStop = false;
            this.btnCreditos.Text = "Créditos morosos completados";
            this.btnCreditos.UseVisualStyleBackColor = true;
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // btnMorososVigentes
            // 
            this.btnMorososVigentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMorososVigentes.Depth = 0;
            this.btnMorososVigentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorososVigentes.Location = new System.Drawing.Point(0, 237);
            this.btnMorososVigentes.Margin = new System.Windows.Forms.Padding(2);
            this.btnMorososVigentes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMorososVigentes.Name = "btnMorososVigentes";
            this.btnMorososVigentes.Primary = true;
            this.btnMorososVigentes.Size = new System.Drawing.Size(159, 45);
            this.btnMorososVigentes.TabIndex = 66;
            this.btnMorososVigentes.TabStop = false;
            this.btnMorososVigentes.Text = "Morosos vigentes";
            this.btnMorososVigentes.UseVisualStyleBackColor = true;
            this.btnMorososVigentes.Click += new System.EventHandler(this.btnMorososVigentes_Click);
            // 
            // btnAsociados
            // 
            this.btnAsociados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsociados.Depth = 0;
            this.btnAsociados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsociados.Location = new System.Drawing.Point(0, 421);
            this.btnAsociados.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsociados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAsociados.Name = "btnAsociados";
            this.btnAsociados.Primary = true;
            this.btnAsociados.Size = new System.Drawing.Size(159, 45);
            this.btnAsociados.TabIndex = 68;
            this.btnAsociados.TabStop = false;
            this.btnAsociados.Text = "Asociados por categoría";
            this.btnAsociados.UseVisualStyleBackColor = true;
            this.btnAsociados.Click += new System.EventHandler(this.btnAsociados_Click);
            // 
            // btnProyeccion
            // 
            this.btnProyeccion.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnProyeccion.Depth = 0;
            this.btnProyeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyeccion.Location = new System.Drawing.Point(0, 375);
            this.btnProyeccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnProyeccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProyeccion.Name = "btnProyeccion";
            this.btnProyeccion.Primary = true;
            this.btnProyeccion.Size = new System.Drawing.Size(159, 45);
            this.btnProyeccion.TabIndex = 67;
            this.btnProyeccion.TabStop = false;
            this.btnProyeccion.Text = "Proyección de pagos";
            this.btnProyeccion.UseVisualStyleBackColor = true;
            // 
            // FormProyeccion
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
            this.Name = "FormProyeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Información Gerencial para el Apoyo al Análisis de la Morosidad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProyeccion_FormClosed);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlParams.ResumeLayout(false);
            this.pnlParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlazo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlParams;
        private MaterialSkin.Controls.MaterialRadioButton rdbPlazo;
        private MaterialSkin.Controls.MaterialRadioButton rdbCuota;
        private System.Windows.Forms.NumericUpDown nudPlazo;
        private System.Windows.Forms.NumericUpDown nudCuota;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.Button btnBuscar;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblCredito;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNuevoPlan;
        private System.Windows.Forms.Label lblPCuotaActual;
        private System.Windows.Forms.Label lblPPagosActual;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblPMora;
        private System.Windows.Forms.Label lblPAsociado;
        private MaterialSkin.Controls.MaterialLabel lblPagosNuevo;
        private MaterialSkin.Controls.MaterialLabel lblCuotaNueva;
        private MaterialSkin.Controls.MaterialLabel lblCuotaActual;
        private MaterialSkin.Controls.MaterialLabel lblPagosActual;
        private MaterialSkin.Controls.MaterialLabel lblMora;
        private MaterialSkin.Controls.MaterialLabel lblAsociado;
        private System.Windows.Forms.Label lblPCuotaNueva;
        private System.Windows.Forms.Label lblPPagosNuevo;
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