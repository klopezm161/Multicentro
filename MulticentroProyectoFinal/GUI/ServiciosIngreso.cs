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
    public partial class ServiciosIngreso : Form
    {
        public ServiciosIngreso()
        {
            InitializeComponent();
        }
        //Getters de las textboxes y del dataViewGrid
        public string GetNombre()
        {
            return txtNombreServicioIngreso.Text;
        }
        public string GetCodigo()
        {
            return txtCodigoServicioIngreso.Text;
        }
        public string GetPrecio()
        {
            return txtPrecioServicioIngreso.Text;
        }

        public DataGridView GetDataView()
        {
            return dgvServicioNuevo;
        }
       
        private void ServiciosIngreso_Load(object sender, EventArgs e)
        {

        }     

        private void BtnSalirServicioIngreso_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMenuPrincipalEnServicioIngreso_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MenuPrincipal menuPrincipalPrograma = new MenuPrincipal();
            menuPrincipalPrograma.Show();            
        }

        private void ServiciosIngreso_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //boton que inicializar ServiciosIngreso BD y llama al método Agregar
        private void BtnAceptarServicioIngreso_Click(object sender, EventArgs e)
        {
            ServiciosIngresoBD servicioIngreso = new ServiciosIngresoBD();
            servicioIngreso.Agregar();
            //ServiciosBusquedaBD busqueda = new ServiciosBusquedaBD();
            //busqueda.BuscarPorCodigo(getCodigo(), dgvServicioNuevo);

            txtNombreServicioIngreso.Clear();
            txtCodigoServicioIngreso.Clear();
            txtPrecioServicioIngreso.Clear();
        }
    }
}
