using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MulticentroProyectoFinal;

namespace MulticentroProyectoFinal.GUI
{
    public partial class FacturacionProducto : Form
    {
        public FacturacionProducto()
        {
            InitializeComponent();
            ProductosBusquedaBD busqueda = new ProductosBusquedaBD();
            busqueda.BuscarTodo(dgvFacturaProducto);
        }
        public string getCantidad()
        {
            return txtCantidadFacturaProduc.Text;
        }
        public string getProducto()
        {
            return cbProductoFacturaCrear.SelectedValue.ToString();
        }
        public DataGridView GetDataView()
        {
            return dgvFacturaProducto;
        }
        public string GetCodigo()
        {
            return txtFacturacionBuscar.Text;
        }

        private void getcbProductoFactura()
        {
            //FacturacionJoinBD facturacionJoin = new FacturacionJoinBD();
            
            //    cbProductoFacturaCrear.DataSource = facturacionJoin.ProductosTable();
            //    cbProductoFacturaCrear.DisplayMember = "nombre";
            //    cbProductoFacturaCrear.ValueMember = "codigoproducto";
            
          

        }
        private void FacturacionProducto_Load(object sender, EventArgs e)
        {
            getcbProductoFactura();
           
        }

        private void btnAceptarFacturarCrear_Click(object sender, EventArgs e)
        {
            IBuscarElementoPorCodigoYNombre busqueda = new ProductosBusquedaBD();
            if (GetCodigo().Length == 00)
            {
                MessageBox.Show("No ingresó ningún valor. Indique el código o nombre que desea buscar.");
            }
            else if (GetCodigo().Length > 0)
            {
                busqueda.BuscarPorCodigo(GetCodigo(), dgvFacturaProducto);
            }

            //FacturacionAgregarBD facturacion = new FacturacionAgregarBD();
            //facturacion.Agregar();
            //label7.Text = cbProductoFacturaCrear.SelectedValue.ToString();
            //txtCantidadFacturaProduc.Clear();

        }
    }
}
