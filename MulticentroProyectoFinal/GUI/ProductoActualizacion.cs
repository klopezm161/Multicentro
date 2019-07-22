using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MulticentroProyectoFinal
{
    public partial class ProductoActualizacion : Form
    {
        public ProductoActualizacion()
        {
            InitializeComponent();
        }

        public string GetNombre()
        {
            return txtNombreProductoActualizado.Text;
        }

        public string GetCantidad()
        {
            return txtCantidadProductoActualizado.Text;

        }
        public string GetPrecio()
        {
            return txtPrecioProductoActualizado.Text;
        }
        public string GetCodigoParaActualizar()
        {
            return TxtCodAActualizarActualizacionProductos.Text;
        }
        public DataGridView GetDataGridView()
        {
            return dataGridView1;
        }

        private void BtnSalirProductoActualizado_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMenuPrincipalProductoActualizado_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalPrograma = new MenuPrincipal();
            menuPrincipalPrograma.Show();
            this.Dispose();
        }

        private void ProductoActualizacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnBuscarServiciosActualizacion_Click(object sender, EventArgs e)
        {
            BuscarCodigo();
        }
        public void BuscarCodigo()
        {
            if (GetCodigoParaActualizar().Length < 1)
            {
                MensajesStandard.MensajeNoIngresoCodigo();
            }
            else
            {
                IBuscarElementoPorCodigoYNombre busqueda = new ProductosBusquedaBD();
                busqueda.BuscarPorCodigo(GetCodigoParaActualizar(), dataGridView1);
              //  txtNombreProductoActualizado.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
               // txtPrecioProductoActualizado.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void BtnAceptarProductoActualizado_Click(object sender, EventArgs e)
        {
            IActualizarElementoBD servicioActualizacion = new ProductosActualizacionBD();
            servicioActualizacion.Actualizar();

            txtNombreProductoActualizado.Clear();
            //  TxtCodAActualizarActualizacionServicios.Clear();
            txtPrecioProductoActualizado.Clear();
            txtCantidadProductoActualizado.Clear();
        }
    }
    }
