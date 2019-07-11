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

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Servicios frm = new Servicios();
            frm.Show();
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
    }
}
