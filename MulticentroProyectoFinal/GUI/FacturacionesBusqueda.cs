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
    public partial class FacturacionesBusquesda : Form
    {
        private DataGridView dgvFacturacionBusqueda;
        public FacturacionesBusquesda()
        {
            InitializeComponent();
        }

        public string GetIdFactura()
        {
            return txtNumFacturaFacturacionesBusqueda.Text;
        }


        public DataGridView GetDataView()
        {
            return dgvFacturacionBusqueda;
        }
        private void BtnSalirFacturacionesBusqueda_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMenuPrincipalFacturacionesBusqueda_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalPrograma = new MenuPrincipal();
            menuPrincipalPrograma.Show();
            this.Dispose();
        }

        private void FacturacionesBusquesa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptarFacturacionesBusqueda_Click(object sender, EventArgs e)
        {
            FacturacionBusquedaBD facturacion = new FacturacionBusquedaBD();
            facturacion.BuscarPorCodigo(GetIdFactura(), GetDataView());
        }
    }
}
