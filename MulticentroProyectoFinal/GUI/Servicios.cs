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
    public partial class Servicios : Form
    {
        public Servicios()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiciosIngreso ing = new ServiciosIngreso();
            ing.Show();
           
        }

        private void BtnBusqueda_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiciosBusqueda busq = new ServiciosBusqueda();
            busq.Show();
        }

        private void BtnActualizacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiciosActualizacion act = new ServiciosActualizacion();
            act.Show();
        }

        private void BtnMenuPrincipalEnServicios_Click(object sender, EventArgs e)
        {

            MenuPrincipal volver = new MenuPrincipal();
            volver.Show();
            this.Dispose();
        }

        private void BtnSalirServicios_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Servicios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    }

