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

namespace MulticentroProyectoFinal
{
    public partial class Login : Form
    {
        ConexionesBasicasAbrirCerrarBD con;
        public Login()
        {
            InitializeComponent();
            con = new ConexionesBasicasAbrirCerrarBD();
        }

        private void BtnSalirLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresarLogin_Click(object sender, EventArgs e)
        {
            string userid = txtUsuarioLogin.Text;
            string password = txtPasswordLogin.Text;

            con.AbrirConexion();

            SqlCommand cmd = new SqlCommand("SELECT empleadoid FROM empleado WHERE userid = '" + userid + "' AND password = '" + password + "'",con.GetSqlConnection());
            cmd.Parameters.AddWithValue("@UserName", userid);
            cmd.Parameters.AddWithValue("@Password", password);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            
            DataTable dt = new DataTable();

            var x = cmd.Connection.DataSource;

            da.Fill(dt);

            con.CerrarConexion(); 

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login invalido por favor revise su usuario o su contraseña");
            }
            else
            {   
                this.Hide();
                MenuPrincipal menuPrincipalPrograma = new MenuPrincipal();
                menuPrincipalPrograma.Show();
            }



        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
