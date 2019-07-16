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
        //Getters de las textboxes para utilizarlas en ServiciosIngresoBD
        public string getNombre()
        {
            return txtNombreServicioIngreso.Text;
        }

        public string getCodigo()
        {
            return txtCodigoServicioIngreso.Text;
        }

        public string getPrecio()
        {
            return txtPrecioServicioIngreso.Text;
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

        private void BtnAceptarServicioIngreso_Click(object sender, EventArgs e)
        {
            ServiciosIngresoBD servicioIngreso = new ServiciosIngresoBD();
            servicioIngreso.Agregar();
            ServiciosBusquedaBD busqueda = new ServiciosBusquedaBD();
            busqueda.BuscarPorCodigo(getCodigo());
            DataTable dt = new DataTable();
            busqueda.getSqlAdaptador().Fill(dt);
            dgvServicioNuevo.DataSource = dt;
            txtNombreServicioIngreso.Clear();
            txtCodigoServicioIngreso.Clear();
            txtPrecioServicioIngreso.Clear();
        }
    }
}
