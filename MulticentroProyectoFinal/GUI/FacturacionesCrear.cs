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
    public partial class FacturarCrear : Form
    {
        public FacturarCrear()
        {
            InitializeComponent();
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
    }
}
