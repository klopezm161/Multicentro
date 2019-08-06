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
using MulticentroProyectoFinal;

namespace MulticentroProyectoFinal
{
    public partial class ProductoIngreso : Form
    {
        public ProductoIngreso()
        {
            InitializeComponent();
            ProductosBusquedaBD busqueda = new ProductosBusquedaBD();
            busqueda.BuscarTodo(dataGridViewProductoNuevo);
        }
        public string GetNombre()
        {
            return txtNombreProductoNuevo.Text;
        }

        public string GetCodigo()
        {
            return txtCodigoProductoNuevo.Text;
        }

        public string GetPrecio()
        {
            return txtPrecioProductoNuevo.Text;
        }
        public string GetCantidad()
        {
            return txtCantidadProductoNuevo.Text;
        }
        public DataGridView GetDataView()
        {
            return dataGridViewProductoNuevo;
        }
        private void BtnSalirProductoNuevo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMenuPrincipalProductoNuevo_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalPrograma = new MenuPrincipal();
            menuPrincipalPrograma.Show();
            this.Close();
        }

        private void BtnAceptarProductoNuevo_Click(object sender, EventArgs e)
        {
            ProductosIngresoBD productoIngreso = new ProductosIngresoBD();
            productoIngreso.Agregar();

            txtNombreProductoNuevo.Clear();
            txtCodigoProductoNuevo.Clear();
            txtPrecioProductoNuevo.Clear();
            txtCantidadProductoNuevo.Clear();
        }
    }
}
