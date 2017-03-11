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
    public partial class FrmContabilidad : Form
    {
        public string nombre { get; set; }
        public string CS { get; set; }
        public FrmContabilidad()
        {
            InitializeComponent();
        }

        private void FrmContabilidad_Load(object sender, EventArgs e)
        {
            NombreCompleto.Text = nombre;
        }

        private void LogOff_Click(object sender, EventArgs e)
        {
            FrmLogIn login = new FrmLogIn();
            this.Hide();
            login.ShowDialog();
        }

        
    }
}
