namespace SIG_LaFamiliar
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.lblContra = new MaterialSkin.Controls.MaterialLabel();
            this.txtContra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTitleLogin = new System.Windows.Forms.Label();
            this.btnEntrar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::SIG_LaFamiliar.Properties.Resources.Logo;
            this.pcbLogo.Location = new System.Drawing.Point(32, 116);
            this.pcbLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(150, 162);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(261, 132);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(141, 19);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre de usuario:";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Depth = 0;
            this.lblContra.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblContra.Location = new System.Drawing.Point(261, 202);
            this.lblContra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContra.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(90, 19);
            this.lblContra.TabIndex = 3;
            this.lblContra.Text = "Contraseña:";
            // 
            // txtContra
            // 
            this.txtContra.Depth = 0;
            this.txtContra.Hint = "";
            this.txtContra.Location = new System.Drawing.Point(230, 233);
            this.txtContra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.SelectedText = "";
            this.txtContra.SelectionLength = 0;
            this.txtContra.SelectionStart = 0;
            this.txtContra.Size = new System.Drawing.Size(415, 23);
            this.txtContra.TabIndex = 4;
            this.txtContra.UseSystemPasswordChar = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "";
            this.txtNombre.Location = new System.Drawing.Point(230, 163);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(415, 23);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // lblTitleLogin
            // 
            this.lblTitleLogin.AutoSize = true;
            this.lblTitleLogin.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleLogin.Location = new System.Drawing.Point(226, 71);
            this.lblTitleLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleLogin.Name = "lblTitleLogin";
            this.lblTitleLogin.Size = new System.Drawing.Size(128, 23);
            this.lblTitleLogin.TabIndex = 6;
            this.lblTitleLogin.Text = "Iniciar Sesión";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Depth = 0;
            this.btnEntrar.Location = new System.Drawing.Point(410, 275);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Primary = true;
            this.btnEntrar.Size = new System.Drawing.Size(144, 28);
            this.btnEntrar.TabIndex = 7;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 325);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblTitleLogin);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pcbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 325);
            this.MinimumSize = new System.Drawing.Size(600, 325);
            this.Name = "FormLogin";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Información Gerencial para el Apoyo al Análisis de la Morosidad";
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLogo;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialLabel lblContra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private System.Windows.Forms.Label lblTitleLogin;
        private MaterialSkin.Controls.MaterialRaisedButton btnEntrar;
    }
}

