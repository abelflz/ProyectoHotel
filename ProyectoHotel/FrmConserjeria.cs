using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHotel
{
    public partial class FrmConserjeria : Form
    {
        public string CS { get; set; }
        public string Nombre { get; set; }
        public FrmConserjeria()
        {
            InitializeComponent();
        }

        private void LogOff_Click(object sender, EventArgs e)
        {
            FrmLogIn login = new FrmLogIn();
            login.CS = CS;
            this.Close();
            login.Show();
        }

        private void FrmConserjeria_Load(object sender, EventArgs e)
        {
            NombreCompleto.Text = Nombre;
        }
    }
}
