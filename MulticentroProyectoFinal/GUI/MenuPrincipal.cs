using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MulticentroProyectoFinal
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void BtnProductosMenuPrincipal_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            this.Dispose();
        }

        private void BtnSalirMenuPrincipal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRegresarMenuPrincipal_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Dispose();
        }

        private void BtnServiciosMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Servicios servicios = new Servicios();
            servicios.Show();
        }

        private void BtnFacturacionMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Facturaciones facturar = new Facturaciones();
            facturar.Show();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
