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
    public partial class Facturaciones : Form
    {
        public Facturaciones()
        {
            InitializeComponent();
        }

        private void BtnSalirFacturacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMenuPrincipalEnFacturacion_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalPrograma = new MenuPrincipal();
            menuPrincipalPrograma.Show();
            this.Dispose();
        }

        private void BtnCrearFacturacion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FacturarCrear facturaCrear = new FacturarCrear();
            facturaCrear.Show();
        }

        private void BtnBuscarFacturacion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FacturacionesBusquesa facturaBusqueda = new FacturacionesBusquesa();
            facturaBusqueda.Show();
        }

        private void Facturaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
