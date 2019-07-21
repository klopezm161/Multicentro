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

        public string getNombre()
        {
            return txtNombreProductoBusqueda.Text;
        }

        public string getCodigo()
        {
            return txtCodigoProductoBusqueda.Text;
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

        private void BtnBuscarProductoBusqueda_Click(object sender, EventArgs e)
        {
            IBuscarElementoPorCodigoYNombre busqueda = new ProductosBusquedaBD();
            //String elementoABuscar;
            if (getNombre().Length == 0 && getCodigo().Length == 0)
            {
                MessageBox.Show("No ingresó ningún valor. Indique el código o nombre que desea buscar.");
            }
            else if (getNombre().Length > 0)
            {
                busqueda.BuscarPorNombre(getNombre(), dataGridView1);

            }
            else if (getCodigo().Length > 0)
            {
                busqueda.BuscarPorCodigo(getCodigo(), dataGridView1);
            }
            txtCodigoProductoBusqueda.Clear();
            txtNombreProductoBusqueda.Clear();

        }
    }
}
