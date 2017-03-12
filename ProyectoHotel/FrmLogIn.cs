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
    public partial class FrmLogIn : Form
    {
        public string CS = "Data Source=abel-pc;Initial Catalog=Hotel;Integrated Security=True";
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void btnAccesar_Click(object sender, EventArgs e)
        {
            Loguear();
        }

        private void Loguear()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CS;

                con.Open();

                string query = "select CedulaEmpleado from LogIn where Cuenta = @a and Clave = @b";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@a", txtUsuario.Text));
                cmd.Parameters.Add(new SqlParameter("@b", txtPassword.Text));

                var cedul = cmd.ExecuteScalar();
                string cedula = cedul.ToString();

                if (string.IsNullOrEmpty(cedula))
                {
                    MessageBox.Show("Usuario o Contraseña no válidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Text = "";
                    txtUsuario.Text = "";
                }
                else
                {
                    string query2 = "select idRol from Empleado where Cedula = @a";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    cmd2.Parameters.Add(new SqlParameter("@a", cedula));

                    var idrol = cmd2.ExecuteScalar();
                    string IdRol = idrol.ToString();

                    SqlCommand cmd3 = new SqlCommand("select Rol from rol where id = @a", con);
                    cmd3.Parameters.Add(new SqlParameter("@a", IdRol));

                    string query4 = "select NombreCompleto from Empleado where Cedula = @cedula";
                    SqlCommand cmd4 = new SqlCommand(query4, con);
                    cmd4.Parameters.Add(new SqlParameter("@cedula", cedula));

                    string nombre = cmd4.ExecuteScalar().ToString();

                    MessageBox.Show("Bienvenido " + nombre);

                    string rol = cmd3.ExecuteScalar().ToString();
                    switch (rol)
                    {
                        case "System Manager":
                            FrmGerenteTI gerente = new FrmGerenteTI();
                            gerente.nombre = nombre;
                            gerente.CS = CS;
                            gerente.rol = rol;
                            this.Hide();
                            gerente.ShowDialog();
                            break;
                        case "Contable":
                            FrmContabilidad contabilidad = new FrmContabilidad();
                            contabilidad.nombre = nombre;
                            contabilidad.CS = CS;
                            this.Hide();
                            contabilidad.Show();
                            break;
                        case "Recepcionista":
                            FrmRecepcion conserje = new FrmRecepcion();
                            conserje.nombre = nombre;
                            conserje.CS = CS;
                            conserje.rol = "Recepcionista";
                            this.Hide();
                            conserje.Show();
                            break;
                        case "Gerente de Recepción":
                            FrmRecepcion alo = new FrmRecepcion();
                            alo.nombre = nombre;
                            alo.CS = CS;
                            alo.rol = "Gerente de Recepción";
                            this.Hide();
                            alo.Show();
                            break;
                    }
                }
            } catch(Exception e)
            {
                MessageBox.Show("" + e);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                Loguear();
            }
        }
    }
}
