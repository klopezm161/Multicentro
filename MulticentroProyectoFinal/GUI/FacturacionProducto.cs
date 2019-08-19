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
        private void getcbProductoFactura()
        {
            FacturacionJoinBD facturacionJoin = new FacturacionJoinBD();
            
                cbProductoFacturaCrear.DataSource = facturacionJoin.ProductosTable();
                cbProductoFacturaCrear.DisplayMember = "nombre";
                cbProductoFacturaCrear.ValueMember = "codigoproducto";
            
          

        }
        private void FacturacionProducto_Load(object sender, EventArgs e)
        {
            getcbProductoFactura();
           
        }

        private void btnAceptarFacturarCrear_Click(object sender, EventArgs e)
        {
            FacturacionAgregarBD facturacion = new FacturacionAgregarBD();
            facturacion.Agregar();
            label7.Text = cbProductoFacturaCrear.SelectedValue.ToString();
            txtCantidadFacturaProduc.Clear();
        }
    }
}
