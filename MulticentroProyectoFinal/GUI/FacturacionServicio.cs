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
        }
        public string getServicio()
        {
            return cbServicioFacturaCrear.SelectedValue.ToString();
        }
        public string getCantidad()
        {
            return txtServicioFacturaCrear.Text;
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
                cbServicioFacturaCrear.DataSource = facturacionJoin.ServiciosTable();
                cbServicioFacturaCrear.DisplayMember = "nombre";
                cbServicioFacturaCrear.ValueMember = "codigoservicio ";
                
            }
            catch (Exception e)
            {

            }

        }

        private void FacturacionProductoServicio_Load(object sender, EventArgs e)
        {
            getcbServiciosFactura();
        }
    }
}
