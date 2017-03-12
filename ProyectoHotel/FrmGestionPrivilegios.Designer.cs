namespace ProyectoHotel
{
    partial class FrmGestionPrivilegios
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEmpleados = new System.Windows.Forms.ComboBox();
            this.cConsultar = new System.Windows.Forms.CheckBox();
            this.cEditar = new System.Windows.Forms.CheckBox();
            this.cDarOfertas = new System.Windows.Forms.CheckBox();
            this.cImprimir = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado";
            // 
            // cbxEmpleados
            // 
            this.cbxEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmpleados.FormattingEnabled = true;
            this.cbxEmpleados.Location = new System.Drawing.Point(87, 20);
            this.cbxEmpleados.Name = "cbxEmpleados";
            this.cbxEmpleados.Size = new System.Drawing.Size(121, 21);
            this.cbxEmpleados.TabIndex = 2;
            this.cbxEmpleados.SelectedIndexChanged += new System.EventHandler(this.cbxEmpleados_SelectedIndexChanged);
            // 
            // cConsultar
            // 
            this.cConsultar.AutoSize = true;
            this.cConsultar.Location = new System.Drawing.Point(12, 84);
            this.cConsultar.Name = "cConsultar";
            this.cConsultar.Size = new System.Drawing.Size(70, 17);
            this.cConsultar.TabIndex = 3;
            this.cConsultar.Text = "Consultar";
            this.cConsultar.UseVisualStyleBackColor = true;
            // 
            // cEditar
            // 
            this.cEditar.AutoSize = true;
            this.cEditar.Location = new System.Drawing.Point(12, 118);
            this.cEditar.Name = "cEditar";
            this.cEditar.Size = new System.Drawing.Size(53, 17);
            this.cEditar.TabIndex = 4;
            this.cEditar.Text = "Editar";
            this.cEditar.UseVisualStyleBackColor = true;
            // 
            // cDarOfertas
            // 
            this.cDarOfertas.AutoSize = true;
            this.cDarOfertas.Location = new System.Drawing.Point(158, 118);
            this.cDarOfertas.Name = "cDarOfertas";
            this.cDarOfertas.Size = new System.Drawing.Size(80, 17);
            this.cDarOfertas.TabIndex = 5;
            this.cDarOfertas.Text = "Dar Ofertas";
            this.cDarOfertas.UseVisualStyleBackColor = true;
            // 
            // cImprimir
            // 
            this.cImprimir.AutoSize = true;
            this.cImprimir.Location = new System.Drawing.Point(158, 84);
            this.cImprimir.Name = "cImprimir";
            this.cImprimir.Size = new System.Drawing.Size(61, 17);
            this.cImprimir.TabIndex = 6;
            this.cImprimir.Text = "Imprimir";
            this.cImprimir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Este Empleado Puede:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Confirmar Privilegio";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmGestionPrivilegios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 204);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cImprimir);
            this.Controls.Add(this.cDarOfertas);
            this.Controls.Add(this.cEditar);
            this.Controls.Add(this.cConsultar);
            this.Controls.Add(this.cbxEmpleados);
            this.Controls.Add(this.label1);
            this.Name = "FrmGestionPrivilegios";
            this.Text = "Gestión de Privilegios";
            this.Load += new System.EventHandler(this.FrmGestionPrivilegios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEmpleados;
        private System.Windows.Forms.CheckBox cConsultar;
        private System.Windows.Forms.CheckBox cEditar;
        private System.Windows.Forms.CheckBox cDarOfertas;
        private System.Windows.Forms.CheckBox cImprimir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}