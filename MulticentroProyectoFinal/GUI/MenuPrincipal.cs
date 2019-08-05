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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void BtnSalirMenuPrincipal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRegresarMenuPrincipal_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Dispose();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            if (cBoxProductos.GetItemText(this.cBoxProductos.SelectedItem).Equals("Buscar"))
            {
                ProductoBusqueda productosBuscar = new ProductoBusqueda();
                productosBuscar.Show();
                this.Dispose();
            }
            else if (cBoxProductos.GetItemText(this.cBoxProductos.SelectedItem).Equals("Agregar"))
            {
                ProductoIngreso productosAgregar= new ProductoIngreso();
                productosAgregar.Show();
                this.Dispose();
            }
            else if (cBoxProductos.GetItemText(this.cBoxProductos.SelectedItem).Equals("Actualizar"))
            {
                ProductoActualizacion productosActualizar = new ProductoActualizacion();
                productosActualizar.Show();
                this.Dispose();
            }
        }

        private void BtnFacturacion_Click(object sender, EventArgs e)
        {
            if (cBoxFacturacion.GetItemText(this.cBoxFacturacion.SelectedItem).Equals("Buscar"))
            {
                FacturacionesBusquesda facturaBuscar = new FacturacionesBusquesda();
                facturaBuscar.Show();
                this.Dispose();
            }
            else if (cBoxFacturacion.GetItemText(this.cBoxFacturacion.SelectedItem).Equals("Agregar"))
            {
                FacturarCrear FacturaAgregar = new FacturarCrear();
                FacturaAgregar.Show();
                this.Dispose();
            }
        }

        private void BtnServicios_Click(object sender, EventArgs e)
        {
            if (cBoxServicios.GetItemText(this.cBoxServicios.SelectedItem).Equals("Buscar"))
            {
                ServiciosBusqueda servicioBuscar = new ServiciosBusqueda();
               servicioBuscar.Show();
                this.Dispose();
            }
            else if (cBoxServicios.GetItemText(this.cBoxServicios.SelectedItem).Equals("Agregar"))
            {
                ServiciosIngreso servicioAgregar = new ServiciosIngreso();
                servicioAgregar.Show();
                this.Dispose();
            }
            else if (cBoxServicios.GetItemText(this.cBoxServicios.SelectedItem).Equals("Actualizar"))
            {
                ServiciosActualizacion servicioActualizar = new ServiciosActualizacion();
                servicioActualizar.Show();
                this.Dispose();
            }
        }

        private void BtnReporteVentasMenuPrincipal_Click(object sender, EventArgs e)
        {
            ReporteVentas ventas = new ReporteVentas();
            ventas.Show();
            this.Dispose();
            

        }
    }
}