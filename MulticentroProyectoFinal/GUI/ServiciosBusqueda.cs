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
    public partial class ServiciosBusqueda : Form
    {
        public ServiciosBusqueda()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Servicios frm = new Servicios();
            frm.Show();

        }

        private void BtnSalirEnBusquedaServicio_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMenuPrincipalEnBusquedaServicio_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalPrograma = new MenuPrincipal();
            menuPrincipalPrograma.Show();
            this.Dispose();
        }

        private void ServiciosBusqueda_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
