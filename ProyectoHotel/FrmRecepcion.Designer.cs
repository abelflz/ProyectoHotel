namespace ProyectoHotel
{
    partial class FrmRecepcion
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
            this.grInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreCompleto = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.LogOff = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grInfo
            // 
            this.grInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grInfo.Controls.Add(this.label2);
            this.grInfo.Controls.Add(this.label1);
            this.grInfo.Controls.Add(this.NombreCompleto);
            this.grInfo.Location = new System.Drawing.Point(12, 12);
            this.grInfo.Name = "grInfo";
            this.grInfo.Size = new System.Drawing.Size(395, 91);
            this.grInfo.TabIndex = 0;
            this.grInfo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Función: Recibe a los huespedes del hotel, encargado del checkin y checkout.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recepcionista";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(387, 100);
            this.dataGridView1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Habitaciones disponibles para limpiar.";
            // 
            // LogOff
            // 
            this.LogOff.Location = new System.Drawing.Point(100, 232);
            this.LogOff.Name = "LogOff";
            this.LogOff.Size = new System.Drawing.Size(82, 23);
            this.LogOff.TabIndex = 3;
            this.LogOff.Text = "Desconectar";
            this.LogOff.UseVisualStyleBackColor = true;
            this.LogOff.Click += new System.EventHandler(this.LogOff_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Editar Oferta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // FrmRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogOff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grInfo);
            this.Name = "FrmRecepcion";
            this.Text = "Conserjería";
            this.Load += new System.EventHandler(this.FrmConserjeria_Load);
            this.grInfo.ResumeLayout(false);
            this.grInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NombreCompleto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LogOff;
        private System.Windows.Forms.Button button1;
    }
}