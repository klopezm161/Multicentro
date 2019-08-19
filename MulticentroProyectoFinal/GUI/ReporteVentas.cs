using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MulticentroProyectoFinal.Interfaces;
using MulticentroProyectoFinal.Reporte;
using Microsoft.Office.Interop.Excel;

namespace MulticentroProyectoFinal
{
    public partial class ReporteVentas : Form
    {
        public ReporteVentas()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalPrograma = new MenuPrincipal();
            menuPrincipalPrograma.Show();
            this.Dispose();
        }
        public string getFechaInicial()
        {
            return dateTimePicker1.Text;
        }

        public string getFechaFinal()
        {
            return dateTimePicker2.Text;
        }

        public string getFiltro()
        {
            return cBoxSeleccionReporteVentas.Text;
        }


        /// <summary>
        /// Método que exporta a un fichero Excel el contenido de un DataGridView
        /// </summary>
        /// <param name="grd">DataGridView que contiene los datos a exportar</param>
        private void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            IReporteFactura reporte = new ReporteFactura();
            IReporteProducto reporteP = new ReporteProducto();
            IReporteServicio reporteS = new ReporteServicio();

            if (getFiltro().Equals("Facturas"))
            {
                if (getFechaInicial().Length == 0 && getFechaFinal().Length == 0)
                {
                    MessageBox.Show("No ingresó ningúna fecha. Por favor ingrese un rango de fecha");
                }
                else
                {
                    reporte.reporteFacturas(getFechaInicial().ToString(), getFechaFinal().ToString(), dataGridView1);

                }
            }

            else if (getFiltro().Equals("Productos"))

            {
                if (getFechaInicial().Length == 0 && getFechaFinal().Length == 0)
                {
                    MessageBox.Show("No ingresó ningúna fecha. Por favor ingrese un rango de fecha");
                }
                else
                {
                    reporteP.reporteProducto(getFechaInicial().ToString(), getFechaFinal().ToString(), dataGridView1);
                }
            }

            else if (getFiltro().Equals("Servicios"))

            {
                if (getFechaInicial().Length == 0 && getFechaFinal().Length == 0)
                {
                    MessageBox.Show("No ingresó ningúna fecha. Por favor ingrese un rango de fecha");
                }
                else
                {
                    reporteS.reporteServicio(getFechaInicial().ToString(), getFechaFinal().ToString(), dataGridView1);
                }
            }

        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dataGridView1);
        }
    }
}
