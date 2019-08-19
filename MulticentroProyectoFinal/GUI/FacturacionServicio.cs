using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MulticentroProyectoFinal.GUI
{
    public partial class FacturacionServicio : Form
    {
        public FacturacionServicio()
        {
            InitializeComponent();
            ServiciosBusquedaBD mostrarTodo = new ServiciosBusquedaBD();
            mostrarTodo.BuscarTodo(dgvFacturaNueva);
        }
        
        public string getCantidad()
        {
            return txtServicioFacturaCrear.Text;
        }
        public string GetCodigo()
        {
            return txtCodigo.Text;
        }
        
        private void btnAceptarFacturarCrear_Click(object sender, EventArgs e)
        {
            FacturacionAgregarBD facturacion = new FacturacionAgregarBD();
            facturacion.Agregar();
            txtServicioFacturaCrear.Clear();
        }

        private void getcbServiciosFactura()
        {
            FacturacionJoinBD facturacionJoin = new FacturacionJoinBD();
            try
            {
               // cbServicioFacturaCrear.DataSource = facturacionJoin.ServiciosTable();
             //   cbServicioFacturaCrear.DisplayMember = "nombre";
               // cbServicioFacturaCrear.ValueMember = "codigoservicio ";
                
            }
            catch (Exception e)
            {

            }

        }

        private void FacturacionProductoServicio_Load(object sender, EventArgs e)
        {
            getcbServiciosFactura();
        }

        private void BtnMenuPrincipalEnFacturarCrear_Click(object sender, EventArgs e)
        {
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            IBuscarElementoPorCodigoYNombre busqueda = new ServiciosBusquedaBD();
            //String elementoABuscar;
            if (GetCodigo().Length == 0)
            {
                MessageBox.Show("No ingresó ningún valor. Indique el código o nombre que desea buscar.");
            }
           
            else if (GetCodigo().Length > 0)
            {
                busqueda.BuscarPorCodigo(GetCodigo(), dgvFacturaNueva);
            }
           // txtCodigo.Clear();
           
        }
    }
}
