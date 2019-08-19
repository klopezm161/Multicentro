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
        
        public FacturacionesBusquesda()
        {
            InitializeComponent();
            FacturacionBusquedaBD busqueda = new FacturacionBusquedaBD();
            busqueda.BuscarTodo(dtvFacturacionBusqueda);
        }

        public string GetIdFactura()
        {
            return txtNumFacturaFacturacionesBusqueda.Text;
        }


        public DataGridView GetDataView()
        {
            return dtvFacturacionBusqueda;
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
            IBuscarElementoPorCodigoBD busqueda = new FacturacionBusquedaBD();
            if (GetIdFactura().Length == 0)
            {
                MessageBox.Show("No ingresó ningún valor. Indique el código o nombre que desea buscar.");
            }
           
            else if (GetIdFactura().Length > 0)
            {
                busqueda.BuscarPorCodigo(GetIdFactura(), dtvFacturacionBusqueda);
            }
            
            txtNumFacturaFacturacionesBusqueda.Clear();
           
        
        }

        private void txtNumFacturaFacturacionesBusqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
