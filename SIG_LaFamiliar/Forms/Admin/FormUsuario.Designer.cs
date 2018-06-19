namespace SIG_LaFamiliar.Forms.Admin
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnUsuarios = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnInicio = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.pnlEspacio = new System.Windows.Forms.Panel();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBitacora = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(0, 376);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(159, 45);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSalir.TabIndex = 27;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Depth = 0;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(0, 238);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Primary = true;
            this.btnUsuarios.Size = new System.Drawing.Size(159, 45);
            this.btnUsuarios.TabIndex = 8;
            this.btnUsuarios.TabStop = false;
            this.btnUsuarios.Text = "Ver usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Depth = 0;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(0, 192);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Primary = true;
            this.btnInicio.Size = new System.Drawing.Size(159, 45);
            this.btnInicio.TabIndex = 7;
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
            // pnlEspacio
            // 
            this.pnlEspacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(179)))), ((int)(((byte)(66)))));
            this.pnlEspacio.Location = new System.Drawing.Point(0, 422);
            this.pnlEspacio.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEspacio.Name = "pnlEspacio";
            this.pnlEspacio.Size = new System.Drawing.Size(159, 218);
            this.pnlEspacio.TabIndex = 29;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(0, 284);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(159, 45);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.TabStop = false;
            this.btnNuevo.Text = "Nuevo usuario";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnBitacora
            // 
            this.btnBitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBitacora.Depth = 0;
            this.btnBitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBitacora.Location = new System.Drawing.Point(0, 330);
            this.btnBitacora.Margin = new System.Windows.Forms.Padding(2);
            this.btnBitacora.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Primary = true;
            this.btnBitacora.Size = new System.Drawing.Size(159, 45);
            this.btnBitacora.TabIndex = 10;
            this.btnBitacora.TabStop = false;
            this.btnBitacora.Text = "Bitácora";
            this.btnBitacora.UseVisualStyleBackColor = true;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPrincipal.Controls.Add(this.lblRol);
            this.pnlPrincipal.Controls.Add(this.lblContra);
            this.pnlPrincipal.Controls.Add(this.lblCorreo);
            this.pnlPrincipal.Controls.Add(this.btnGuardar);
            this.pnlPrincipal.Controls.Add(this.btnCancelar);
            this.pnlPrincipal.Controls.Add(this.cmbRol);
            this.pnlPrincipal.Controls.Add(this.txtContra);
            this.pnlPrincipal.Controls.Add(this.txtCorreo);
            this.pnlPrincipal.Controls.Add(this.txtNombre);
            this.pnlPrincipal.Controls.Add(this.lblNombre);
            this.pnlPrincipal.Controls.Add(this.lblTitulo);
            this.pnlPrincipal.Location = new System.Drawing.Point(176, 64);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(703, 265);
            this.pnlPrincipal.TabIndex = 58;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(442, 79);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(35, 19);
            this.lblRol.TabIndex = 39;
            this.lblRol.Text = "Rol:";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.Location = new System.Drawing.Point(387, 128);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(90, 19);
            this.lblContra.TabIndex = 38;
            this.lblContra.Text = "Contraseña:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(23, 125);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(143, 19);
            this.lblCorreo.TabIndex = 37;
            this.lblCorreo.Text = "Correo electrónico: ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(402, 203);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 29);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(252, 203);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 29);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cmbRol
            // 
            this.cmbRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Seleccionar..."});
            this.cmbRol.Location = new System.Drawing.Point(483, 76);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(155, 27);
            this.cmbRol.TabIndex = 2;
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(483, 125);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(186, 26);
            this.txtContra.TabIndex = 4;
            this.txtContra.UseSystemPasswordChar = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(172, 122);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(196, 26);
            this.txtCorreo.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(172, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(21, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(145, 19);
            this.lblNombre.TabIndex = 30;
            this.lblNombre.Text = "Nombre del usuario:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(284, 15);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(135, 23);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "Nuevo usuario";
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.btnBitacora);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pnlEspacio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.pcbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 640);
            this.MinimumSize = new System.Drawing.Size(900, 640);
            this.Name = "FormUsuario";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Información Gerencial para el Apoyo al Análisis de la Morosidad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormInicioAdmin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnUsuarios;
        private MaterialSkin.Controls.MaterialRaisedButton btnInicio;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Panel pnlEspacio;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnBitacora;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
    }
}