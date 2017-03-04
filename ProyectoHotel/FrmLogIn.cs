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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CS;

            con.Open();

            string query = "select count(CuentaEmpleado) from Empleado where CuentaEmpleado = @a and ClaveEmpleado = @b";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@a", txtUsuario.Text));
            cmd.Parameters.Add(new SqlParameter("@b", txtPassword.Text));

            if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
            {
                MessageBox.Show("Usuario o Contraseña no válidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Text = "";
                txtUsuario.Text = "";
            }
            else
            {
                SqlCommand cmd3 = new SqlCommand("select IDRol from Empleado where CuentaEmpleado = @a", con);
                cmd3.Parameters.Add(new SqlParameter("@a", txtUsuario.Text));

                string query2 = "select NombreCompleto from Empleado where CuentaEmpleado = @a";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.Parameters.Add(new SqlParameter("@a", txtUsuario.Text));
                string nombre = cmd2.ExecuteScalar().ToString();

                MessageBox.Show("Bienvenido "+nombre);

                switch (Convert.ToInt32(cmd3.ExecuteScalar())) {
                    case 1:
                        FrmGerenteTI gerente = new FrmGerenteTI();
                        gerente.CS = CS;
                        this.Hide();
                        gerente.Show();
                        break;
                    case 2:
                        FrmSoporteTI soporte = new FrmSoporteTI();
                        soporte.CS = CS;
                        this.Hide();
                        soporte.Show();
                        break;
                    case 3:
                        FrmGerenteCustomeS GerenteSC = new FrmGerenteCustomeS();
                        GerenteSC.CS = CS;
                        this.Hide();
                        GerenteSC.Show();
                        break;
                    case 4:
                        FrmRecepcionCustomerS recepcion = new FrmRecepcionCustomerS();
                        recepcion.CS = CS;
                        this.Hide();
                        recepcion.Show();
                        break;
                    case 5:
                        FrmSubGerente sub = new FrmSubGerente();
                        sub.CS = CS;
                        this.Hide();
                        sub.Show();
                        break;
                    case 6:
                        FrmContabilidad contabilidad = new FrmContabilidad();
                        contabilidad.CS = CS;
                        this.Hide();
                        contabilidad.Show();
                        break;
                    case 7:
                        FrmConserjeria conserje = new FrmConserjeria();
                        conserje.Nombre = nombre;
                        conserje.CS = CS;
                        this.Hide();
                        conserje.Show();
                        break;
                    case 8:
                        FrmRRHH humanos = new FrmRRHH();
                        humanos.CS = CS;
                        this.Hide();
                        humanos.Show();
                        break;
                } 
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
