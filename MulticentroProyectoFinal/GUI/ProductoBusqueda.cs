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
    public partial class ProductoBusqueda : Form
    {
        public ProductoBusqueda()
        {
            InitializeComponent();
        }

        private void BtnSalirProductoBusqueda_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMenuPrincipalProductoBusqueda_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalPrograma = new MenuPrincipal();
            menuPrincipalPrograma.Show();
            this.Dispose();
        }

        private void ProductoBusqueda_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
