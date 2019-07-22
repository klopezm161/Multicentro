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
    public partial class ServiciosActualizacion : Form
    {
        public ServiciosActualizacion()
        {
            InitializeComponent();
        }
        //Getters de las text boxes y del dataGridView
        public string GetNombre()
        {
            return txtNombreServiciosActualizacion.Text;
        }
        public string GetCantidad()
        {
            return txtCantidadServiciosActualizacion.Text;
        }
        public string GetPrecio()
        {
            return txtPrecioServiciosActualizacion.Text;
        }
        public string GetCodigoParaActualizar()
        {
            return TxtCodAActualizarActualizacionServicios.Text;
        }
        public DataGridView GetDataGridView()
        {
            return dGVActualizacionServicio;
        }
        //public void SetNombre(string nombre)
        //{
        //    txtNombreServiciosActualizacion.Text = nombre;
        //}
        //public void SetPrecio(string precio)
        //{
        //    txtPrecioServiciosActualizacion.Text = precio;
        //}
        //public void SetCodigoParaActualizar(string codigo)
        //{
        //    TxtCodAActualizarActualizacionServicios.Text = codigo;
        //}
        //Botón instancia a la clase servicioActualización y al método actualizar
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            IActualizarElementoBD servicioActualizacion = new ServiciosActualizacionBD();
            servicioActualizacion.Actualizar();

            txtNombreServiciosActualizacion.Clear();
            //  TxtCodAActualizarActualizacionServicios.Clear();
            txtPrecioServiciosActualizacion.Clear();
            txtCantidadServiciosActualizacion.Clear();
        }
        //botón que busca código para actualizar
        private void BtnBuscarServiciosActualizacion_Click(object sender, EventArgs e)
        {
            if (GetCodigoParaActualizar().Length < 1)
            {
                MensajesStandard.MensajeNoIngresoCodigo();
            }

            else
            {
                IBuscarElementoPorCodigoYNombre busqueda = new ServiciosBusquedaBD();
                busqueda.BuscarPorCodigo(GetCodigoParaActualizar(), dGVActualizacionServicio);
            }
        }
        private void BtnSalirServiciosActualizacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMenuPrincipalEnServiciosActualizacion_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalPrograma = new MenuPrincipal();
            menuPrincipalPrograma.Show();
            this.Dispose();
        }

        private void ServiciosActualizacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

