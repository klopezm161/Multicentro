using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MulticentroProyectoFinal.GUI;

namespace MulticentroProyectoFinal
{
    public partial class FacturarCrear : Form
    {
        private IConexionesBasicasAbrirCerrarBD conexion = new ConexionesBasicasAbrirCerrarBD();
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
        public string GetTipo()
        {
            return cbTipoFacturaCrear.Text;
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
           FacturacionServicio facturacionServicio= new FacturacionServicio();
            FacturacionProducto facturacionProducto = new FacturacionProducto();
            FacturacionAgregarBD agregarFac = new FacturacionAgregarBD();
            if (txtNombreClienteFacturarCrear.Text.Length == 0 || txtNumFacturaFacturarCrear.Text.Length == 0)
            {
                MessageBox.Show("No se aceptan espacios vacios.");
            }
            else if (txtNombreClienteFacturarCrear.Text.Length > 0 || txtNumFacturaFacturarCrear.Text.Length > 0)
            {
                agregarFac.Agregar();
               
               //if(agregarFac.Agregar()) 
               // {
                 

               //     if (cbTipoFacturaCrear.Text.Equals("Servicio"))
               //     {

               //         facturacionServicio.Show();
               //     }
               //     else if (cbTipoFacturaCrear.Text.Equals("Producto"))
               //     {
               //         facturacionProducto.Show();
               //     }
               // }
            }
        }

        private void txtNumFacturaFacturarCrear_TextChanged(object sender, EventArgs e)
        {

        }
        
       
        private void FacturarCrear_Load(object sender, EventArgs e)
        {
            
           
        }

        private void dgvFacturaNueva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
