namespace ProyectoHotel
{
    partial class FrmGerenteTI
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
            this.LogOff = new System.Windows.Forms.Button();
            this.grInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreCompleto = new System.Windows.Forms.Label();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxEmpleado = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmpleadoCD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogOff
            // 
            this.LogOff.Location = new System.Drawing.Point(6, 102);
            this.LogOff.Name = "LogOff";
            this.LogOff.Size = new System.Drawing.Size(82, 23);
            this.LogOff.TabIndex = 10;
            this.LogOff.Text = "Desconectar";
            this.LogOff.UseVisualStyleBackColor = true;
            this.LogOff.Click += new System.EventHandler(this.LogOff_Click);
            // 
            // grInfo
            // 
            this.grInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grInfo.Controls.Add(this.label2);
            this.grInfo.Controls.Add(this.label1);
            this.grInfo.Controls.Add(this.NombreCompleto);
            this.grInfo.Location = new System.Drawing.Point(1, 9);
            this.grInfo.Name = "grInfo";
            this.grInfo.Size = new System.Drawing.Size(282, 91);
            this.grInfo.TabIndex = 8;
            this.grInfo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Función: Administrar el módulo de seguridad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Administrador del Sistema";
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.AutoSize = true;
            this.NombreCompleto.Location = new System.Drawing.Point(6, 16);
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.Size = new System.Drawing.Size(88, 13);
            this.NombreCompleto.TabIndex = 1;
            this.NombreCompleto.Text = "NombreCompleto";
            // 
            // cbxRol
            // 
            this.cbxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Location = new System.Drawing.Point(104, 59);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(121, 21);
            this.cbxRol.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cambiar Rol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Empleado";
            // 
            // cbxEmpleado
            // 
            this.cbxEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmpleado.FormattingEnabled = true;
            this.cbxEmpleado.Location = new System.Drawing.Point(104, 27);
            this.cbxEmpleado.Name = "cbxEmpleado";
            this.cbxEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cbxEmpleado.TabIndex = 14;
            this.cbxEmpleado.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.EmpleadoCD);
            this.groupBox1.Controls.Add(this.LogOff);
            this.groupBox1.Controls.Add(this.cbxEmpleado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxRol);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(7, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 145);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambio de Rol";
            // 
            // EmpleadoCD
            // 
            this.EmpleadoCD.Location = new System.Drawing.Point(188, 102);
            this.EmpleadoCD.Name = "EmpleadoCD";
            this.EmpleadoCD.Size = new System.Drawing.Size(82, 23);
            this.EmpleadoCD.TabIndex = 15;
            this.EmpleadoCD.Text = "Gestión";
            this.EmpleadoCD.UseVisualStyleBackColor = true;
            this.EmpleadoCD.Click += new System.EventHandler(this.EmpleadoCD_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cambiar Rol Empleado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmGerenteTI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.grInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGerenteTI";
            this.Text = "Administrador del Sistema";
            this.Load += new System.EventHandler(this.FrmGerenteTI_Load);
            this.grInfo.ResumeLayout(false);
            this.grInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogOff;
        private System.Windows.Forms.GroupBox grInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NombreCompleto;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EmpleadoCD;
        private System.Windows.Forms.Button button1;
    }
}