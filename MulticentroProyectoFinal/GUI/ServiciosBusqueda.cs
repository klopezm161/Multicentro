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
    public partial class ServiciosBusqueda : Form
    {
        public ServiciosBusqueda()
        {
            InitializeComponent();
            ServiciosBusquedaBD mostrarTodo = new ServiciosBusquedaBD();
            mostrarTodo.BuscarTodo(dGVBusquedaServicio);

            
           
        }
        //getters de los textboxes 
        public string getNombre()
        {
            return txtNombreBusquedaServicio.Text;
        }
        public string getCodigo()
        {
            return txtCodigoBusquedaServicio.Text;
        }
        //botón que referencia ServiciosBusquedaBD y dependiendo de cuál textbox tenga datos, llama al método correspondiente
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarServicios();
        }

        public void BuscarServicios()
        {
            IBuscarElementoPorCodigoYNombre busqueda = new ServiciosBusquedaBD();
            //String elementoABuscar;
            if (getNombre().Length == 0 && getCodigo().Length == 0)
            {
                MessageBox.Show("No ingresó ningún valor. Indique el código o nombre que desea buscar.");
            }
            else if (getNombre().Length > 0)
            {
                busqueda.BuscarPorNombre(getNombre(), dGVBusquedaServicio);

            }
            else if (getCodigo().Length > 0)
            {
                busqueda.BuscarPorCodigo(getCodigo(), dGVBusquedaServicio);
            }
            txtCodigoBusquedaServicio.Clear();
            txtNombreBusquedaServicio.Clear();
        }
        private void BtnSalirEnBusquedaServicio_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMenuPrincipalEnBusquedaServicio_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalPrograma = new MenuPrincipal();
            menuPrincipalPrograma.Show();
            this.Dispose();
        }

        private void ServiciosBusqueda_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
