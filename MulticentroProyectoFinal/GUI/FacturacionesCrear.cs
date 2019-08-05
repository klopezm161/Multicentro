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
        }
        public String GetFecha()
        {
            return txtFechaEmisionFacturarCrear.Text;
        }
        public String GetNumFactura()
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
            txtFechaEmisionFacturarCrear.Clear();
            txtNombreClienteFacturarCrear.Clear();
            txtNumFacturaFacturarCrear.Clear();
        }
    }
}
