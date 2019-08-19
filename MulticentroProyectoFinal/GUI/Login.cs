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
                SqlDataAdapter adaptador;
                con.AbrirConexion();
                string query = "SELECT * FROM dbo.empleado where userID = '" + userid + "' AND password = '"+ password + "'";
                adaptador = new SqlDataAdapter(query, con.GetSqlConnection());
                con.CerrarConexion();
                DataSet DS = new DataSet();
                adaptador.Fill(DS);
               if (DS.Tables[0].Rows.Count == 1)
                {
                this.Hide();
                MenuPrincipal menuPrincipalPrograma = new MenuPrincipal();
                menuPrincipalPrograma.Show();
            }
                else
                {
                MessageBox.Show("Login invalido por favor revise su usuario o su contraseña");
                }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
