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
    public partial class FacturarCrear : Form
    {
        public FacturarCrear()
        {
            InitializeComponent();
            FacturacionBusquedaBD busqueda = new FacturacionBusquedaBD();
            busqueda.BuscarTodo(dgvFacturaNueva);
        }
        public string GetFecha()
        {
            // return Convert.ToDateTime(dtpFechaFactura.Value.ToString("MM/dd/yyyy"), System.Globalization.CultureInfo.GetCultureInfo("en-US").DateTimeFormat);
            //  return DateTime.ParseExact(dtpFechaFactura.Text.ToString(), @"yyyy/MM/dd HH/mm/ss tt", System.Globalization.CultureInfo.InvariantCulture);
            return dtpFechaFactura.Value.ToString("yyyyMMdd");
        }
     
        public string GetNumFactura()
        {
            return txtNumFacturaFacturarCrear.Text;
        }
        public string GetNombreCliente()
        {
            return txtNombreClienteFacturarCrear.Text;
        }
        public string GetServicio()
        {
            return CBoxServicioFacturarCrear.Text;
        }

        public DataGridView GetDataView()
        {
            return dgvFacturaNueva;
        }

        private void BtnMenuPrincipalEnFacturarCrear_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalPrograma = new MenuPrincipal();
            menuPrincipalPrograma.Show();
            this.Dispose();
        }

        private void BtnSalirFacturarCrear_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FacturarCrear_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnAceptarFacturarCrear_Click_1(object sender, EventArgs e)
        {
           FacturacionAgregarBD facturacion = new FacturacionAgregarBD();
            facturacion.Agregar();
           
            txtNombreClienteFacturarCrear.Clear();
            txtNumFacturaFacturarCrear.Clear();
        }

        private void txtNumFacturaFacturarCrear_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
