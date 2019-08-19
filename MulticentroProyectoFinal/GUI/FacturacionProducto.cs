using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MulticentroProyectoFinal.Facturacion;

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
        public string GetCodigo()
        {
            return txtCodigo.Text;
        }
       
        public DataGridView GetDataView()
        {
            return dgvFacturaProducto;
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
            else if (GetCodigo().Length > 0 & getCantidad().Length > 0)
            {
                busqueda.BuscarPorCodigo(GetCodigo(), dgvFacturaProducto);
                AgregarServiciosYProductosFactura agregarProducto = new AgregarServiciosYProductosFactura();
                agregarProducto.Agregar();

            }
            else
                MessageBox.Show("Verifique los datos ingresados");

            //FacturacionAgregarBD facturacion = new FacturacionAgregarBD();
            //facturacion.Agregar();
            //label7.Text = cbProductoFacturaCrear.SelectedValue.ToString();
            //txtCantidadFacturaProduc.Clear();

        }

        private void BtnMenuPrincipalEnFacturarCrear_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            IBuscarElementoPorCodigoYNombre busqueda = new ProductosBusquedaBD();
            //String elementoABuscar;
            if (GetCodigo().Length ==0)
            {
                MessageBox.Show("No ingresó ningún valor. Indique el código  que desea buscar.");
            }
            else if (GetCodigo().Length > 0)
            {
                busqueda.BuscarPorCodigo(GetCodigo(), dgvFacturaProducto);
            }
            

        }
    }
    }

