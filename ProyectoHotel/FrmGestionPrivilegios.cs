using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHotel
{
    public partial class FrmGestionPrivilegios : Form
    {
        public string CS { get; set; }
        public FrmGestionPrivilegios()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmGestionPrivilegios_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CS;
            con.Open();

            SqlCommand cmd = new SqlCommand("select NombreCompleto from Empleado", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbxEmpleados.Items.Add(reader["NombreCompleto"].ToString());
            }
            con.Close();
        }

        private void cbxEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            cConsultar.Checked = false;
            cEditar.Checked = false;
            cDarOfertas.Checked = false;
            cImprimir.Checked = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CS;
            con.Open();
            SqlCommand cmd = new SqlCommand("select idRol from Empleado where NombreCompleto = '" + cbxEmpleados.Text + "'", con);
            string idrol = cmd.ExecuteScalar().ToString();

            SqlCommand cmd2 = new SqlCommand("select Consultar from Funciones where idRol = '"+idrol+"'", con);
            SqlCommand cmd3 = new SqlCommand("select Imprimir  from Funciones where idRol = '" + idrol + "'", con);
            SqlCommand cmd4 = new SqlCommand("select Editar from Funciones where idRol = '" + idrol + "'", con);
            SqlCommand cmd5 = new SqlCommand("select DarOfertas from Funciones where idRol = '" + idrol + "'", con);

            switch (cmd2.ExecuteScalar().ToString()) {
                case "1":
                    cConsultar.Checked = true;
                    break;
            }
            switch (cmd3.ExecuteScalar().ToString()) {
                case "1":
                    cImprimir.Checked = true;
                    break;
            }
            switch (cmd4.ExecuteScalar().ToString())
            {
                case "1":
                    cEditar.Checked = true;
                    break;
            }
            switch (cmd5.ExecuteScalar().ToString())
            {
                case "1":
                    cDarOfertas.Checked = true;
                    break;
            }
        }
    }
}
