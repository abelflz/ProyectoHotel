using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoHotel
{
    public partial class FrmGerenteTI : Form
    { 
        public string nombre { get; set; }
        public string CS { get; set; }
        public string rol { get; set; }
        public string desRol { get; set; }
    public FrmGerenteTI()
        {
            InitializeComponent();
        }

        private void FrmGerenteTI_Load(object sender, EventArgs e)
        {
            NombreCompleto.Text = nombre;
            llenarEmpleado();
            llenarRol();            
        }
        public void llenarEmpleado()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CS;
                con.Open();

                SqlCommand cmd = new SqlCommand("select NombreCompleto from Empleado", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbxEmpleado.Items.Add(reader["NombreCompleto"].ToString());
                }

                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show("" + es);
            }
        }

        public void llenarRol() {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CS;
                con.Open();
                SqlCommand cmd = new SqlCommand("select Rol from rol", con);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbxRol.Items.Add(reader["Rol"].ToString());
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("" + es);
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CS;

                con.Open();

                SqlCommand cmd = new SqlCommand("select idRol from Empleado where NombreCompleto = @nombre", con);
                cmd.Parameters.Add(new SqlParameter("@nombre", cbxEmpleado.Text));

                string id = cmd.ExecuteScalar().ToString();

                SqlCommand cmd2 = new SqlCommand("select Rol from rol where id = @id", con);
                cmd2.Parameters.Add(new SqlParameter("@id", id));

                var rol = cmd2.ExecuteScalar();
                string ROL = rol.ToString();
                cbxRol.Text = ROL;

                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show("" + es);
            }
        }

        private void EmpleadoCD_Click(object sender, EventArgs e)
        {
            FrmCrearEmpleado empleado = new FrmCrearEmpleado();
            empleado.nombre = nombre;
            empleado.CS = CS;
            this.Hide();
            empleado.ShowDialog();
        }

        private void LogOff_Click(object sender, EventArgs e)
        {
            FrmLogIn login = new FrmLogIn();
            this.Hide();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CS;
            con.Open();

            string query = "select id from rol where Rol = @rol";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@rol", cbxRol.Text));

            var idrol = cmd.ExecuteScalar();
            string rolID = idrol.ToString();

            string query2 = "update Empleado set idRol = @rolID where NombreCompleto = @nombre";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.Parameters.Add(new SqlParameter("@rolID", rolID));
            cmd2.Parameters.Add(new SqlParameter("@nombre", cbxEmpleado.Text));

            MessageBox.Show(cmd2.ExecuteNonQuery() + " Rol cambiado");
        }
    }
}
