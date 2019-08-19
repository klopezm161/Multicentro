using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using MulticentroProyectoFinal.Interfaces;

namespace MulticentroProyectoFinal.Reporte
{
    class ReporteProducto : IReporteProducto
    {
        //referencia a clase para abrir conexion, implementación de bridge
        public IConexionesBasicasAbrirCerrarBD conexion { get; set; }
        // private SqlCommand cmd;
        private SqlDataAdapter adaptador;
        // private SqlDataReader lector;

        //constructor que inicializa la conexion
        public ReporteProducto()
        {
            conexion = new ConexionesBasicasAbrirCerrarBD();
        }

        public void reporteProducto(string fechaInicial, string fechaFinal, DataGridView dataGrid)
        {
            conexion.AbrirConexion();
            string query = @"SELECT  P.nombre AS Nombre ,F.fecha AS Fecha ,SUM(D.precio) AS Total  FROM Factura AS F INNER JOIN detalle AS D ON (F.Facturaid = D.factura_facturaid) INNER JOIN producto AS P  ON(D.producto_codigoproducto=P.codigoproducto) WHERE fecha BETWEEN '" + fechaInicial + "'" + " AND '" + fechaFinal + "' GROUP BY F.fecha, P.nombre;";
            adaptador = new SqlDataAdapter(query, conexion.GetSqlConnection());
            conexion.CerrarConexion();
            MostrarDatos(dataGrid);
        }


        public SqlDataAdapter getSqlAdaptador()
        {
            return adaptador;
        }

        //Método para mostrar datos en dataGrid de la ventana correspondiente
        public void MostrarDatos(DataGridView dataGrid)
        {
            try
            {
                DataTable dt = new DataTable();
                getSqlAdaptador().Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGrid.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No se encontró el dato que buscaba. Inténtelo de nuevo");
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Falla al mostrar datos");
            }
        }

    }
}