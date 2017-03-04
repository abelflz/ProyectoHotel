namespace ProyectoHotel
{
    partial class FrmLogIn
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
            this.btnAccesar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.Bienvenido = new System.Windows.Forms.Label();
            this.gLogIn = new System.Windows.Forms.GroupBox();
            this.gLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAccesar
            // 
            this.btnAccesar.Location = new System.Drawing.Point(59, 58);
            this.btnAccesar.Name = "btnAccesar";
            this.btnAccesar.Size = new System.Drawing.Size(75, 23);
            this.btnAccesar.TabIndex = 2;
            this.btnAccesar.Text = "Accesar";
            this.btnAccesar.UseVisualStyleBackColor = true;
            this.btnAccesar.Click += new System.EventHandler(this.btnAccesar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(69, 32);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(127, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(69, 9);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(127, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(6, 35);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(61, 13);
            this.LabelPassword.TabIndex = 3;
            this.LabelPassword.Text = "Contraseña";
            // 
            // Bienvenido
            // 
            this.Bienvenido.AutoSize = true;
            this.Bienvenido.Location = new System.Drawing.Point(20, 12);
            this.Bienvenido.Name = "Bienvenido";
            this.Bienvenido.Size = new System.Drawing.Size(43, 13);
            this.Bienvenido.TabIndex = 2;
            this.Bienvenido.Text = "Usuario";
            // 
            // gLogIn
            // 
            this.gLogIn.Controls.Add(this.btnAccesar);
            this.gLogIn.Controls.Add(this.Bienvenido);
            this.gLogIn.Controls.Add(this.LabelPassword);
            this.gLogIn.Controls.Add(this.txtPassword);
            this.gLogIn.Controls.Add(this.txtUsuario);
            this.gLogIn.Location = new System.Drawing.Point(12, 12);
            this.gLogIn.Name = "gLogIn";
            this.gLogIn.Size = new System.Drawing.Size(202, 90);
            this.gLogIn.TabIndex = 3;
            this.gLogIn.TabStop = false;
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 116);
            this.Controls.Add(this.gLogIn);
            this.Name = "FrmLogIn";
            this.Text = "Módulo Seguridad";
            this.gLogIn.ResumeLayout(false);
            this.gLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label Bienvenido;
        private System.Windows.Forms.Button btnAccesar;
        public System.Windows.Forms.GroupBox gLogIn;
    }
}

