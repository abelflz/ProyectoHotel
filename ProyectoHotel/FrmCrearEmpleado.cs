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
    public partial class FrmCrearEmpleado : Form
    {
        public string nombre { get; set; }
        public string CS { get; set; }

        public FrmCrearEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmCrearEmpleado_Load(object sender, EventArgs e)
        {
            llenarEmpleado();
            llenarRol();
            dgvEmpleado();
            dgvaRol();
        }
        public void dgvaRol() {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CS;
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("select * from rol order by id", con);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dgvRol.DataSource = table;
            dgvRol.AutoResizeRows();
            dgvRol.AutoResizeRows();
            dgvRol.Refresh();
            dgvRol.Update();
        }
        public void dgvEmpleado() {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CS;
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("select * from Empleado order by NombreCompleto", con);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dgvEmpleados.DataSource = table;
            dgvEmpleados.AutoResizeRows();
            dgvEmpleados.AutoResizeRows();
            dgvEmpleados.Refresh();
            dgvEmpleados.Update();

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
                    cbxEmpleadoEliminar.Items.Add(reader["NombreCompleto"].ToString());
                }

                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show("" + es);
            }
        }

        public void llenarRol()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CS;
                con.Open();
                SqlCommand cmd = new SqlCommand("select Rol from rol", con);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbxEliminarRol.Items.Add(reader["Rol"].ToString());
                    cbxRolEmpleado.Items.Add(reader["Rol"].ToString());
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("" + es);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CS;
            con.Open();

            SqlCommand cmd = new SqlCommand("delete from Empleado where NombreCompleto = @a", con);
            cmd.Parameters.Add(new SqlParameter("@a", cbxEmpleadoEliminar.Text));

            MessageBox.Show(cmd.ExecuteNonQuery() + " Empleado fue eliminado");
            cbxEmpleadoEliminar.SelectedIndex = -1;
            dgvEmpleado();
            cbxEmpleadoEliminar.Items.Clear();
            llenarEmpleado();
            con.Close();
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            try {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CS;
                con.Open();

                SqlCommand cmd = new SqlCommand("delete from rol where Rol = @a", con);
                cmd.Parameters.Add(new SqlParameter("@a", cbxEliminarRol.Text));

                MessageBox.Show(cmd.ExecuteNonQuery() + " Rol fue eliminado");
                cbxEliminarRol.SelectedIndex = -1;
                dgvaRol();
                cbxEliminarRol.Items.Clear();
                cbxRolEmpleado.Items.Clear();
                llenarRol();
                con.Close();
            } catch (Exception)
            {
                MessageBox.Show("No debe tener ningún Empleado asociado");
            }
        }

        private void btnRolCrear_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CS;
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into rol values(@a, @b)", con);
            cmd.Parameters.Add(new SqlParameter("@a", txtRol.Text));
            cmd.Parameters.Add(new SqlParameter("@b", txtRolDesc.Text));

            MessageBox.Show(cmd.ExecuteNonQuery() + " Rol ha sido agregado");
            txtRol.Text = "";
            txtRolDesc.Text = "";
            dgvaRol();
            llenarRol();
            con.Close();
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CS;
            con.Open();

            SqlCommand cmd2 = new SqlCommand("select id from rol where Rol = @a", con);
            cmd2.Parameters.Add(new SqlParameter("@a", cbxRolEmpleado.Text));
            string id = cmd2.ExecuteScalar().ToString();

            SqlCommand cmd = new SqlCommand("insert into Empleado values(@a, @b, @c)", con);
            cmd.Parameters.Add(new SqlParameter("@a", txtCedula.Text));
            cmd.Parameters.Add(new SqlParameter("@b", txtNombreEmpleado.Text));
            cmd.Parameters.Add(new SqlParameter("@c", id));

            MessageBox.Show(cmd.ExecuteNonQuery() + " Empleado registrado satisfactoriamente");
            cbxEmpleadoEliminar.Items.Clear();
            llenarEmpleado();
            dgvEmpleado();

            txtCedula.Text = "";
            txtNombreEmpleado.Text = "";
            id = "";
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            FrmGerenteTI gerente = new FrmGerenteTI();
            gerente.nombre = nombre;
            gerente.CS = CS;
            this.Hide();
            gerente.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmGestionPrivilegios privilegio = new FrmGestionPrivilegios();
            privilegio.CS = CS;
            this.Hide();
            privilegio.ShowDialog();
        }
    }
}
