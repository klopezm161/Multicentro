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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void BtnSalirMenuProductos_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMenuPrincipalEnMenuProductos_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalPrograma = new MenuPrincipal();
            menuPrincipalPrograma.Show();
            this.Dispose();
        }

        private void BtnIngresarMenuProductos_Click(object sender, EventArgs e)
        {
            ProductoIngreso productoIngresar = new ProductoIngreso();
            productoIngresar.Show();
            this.Dispose();
        }

        private void BtnBuscarMenuProductos_Click(object sender, EventArgs e)
        {
            ProductoBusqueda productoBuscar = new ProductoBusqueda();
            productoBuscar.Show();
            this.Dispose();
        }

        private void BtnActualizarMenProductos_Click(object sender, EventArgs e)
        {
            ProductoActualizacion productoActualizar = new ProductoActualizacion();
            productoActualizar.Show();
            this.Dispose();
        }

        private void Productos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
