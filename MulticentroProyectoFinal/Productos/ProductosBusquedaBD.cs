using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace MulticentroProyectoFinal
{
    class ProductosBusquedaBD : IBuscarElementoPorCodigoYNombre
    {
        //referencia a clase para abrir conexion
        private IConexionesBasicasAbrirCerrarBD conexion;
        // private SqlCommand cmd;
        private SqlDataAdapter adaptador;
        // private SqlDataReader lector;

        //constructor que inicializa la conexion
        public ProductosBusquedaBD()
        {
            conexion = new ConexionesBasicasAbrirCerrarBD();
        }
        //Implementación de métodos de la interfaz 

        /// <summary>
        /// método que busca por nombre
        /// </summary>
        /// <param name="elementoABuscar"></param>
        /// <param name="dataGrid"></param>
        public void BuscarPorNombre(String elementoABuscar, DataGridView dataGrid)
        {
            try
            {
                conexion.AbrirConexion();
                string query = @"SELECT * FROM dbo.producto where nombre like'" + elementoABuscar + "%'";
                adaptador = new SqlDataAdapter(query, conexion.GetSqlConnection());
                conexion.CerrarConexion();
                MostrarDatos(dataGrid);
            }
            catch (ArgumentNullException ex)
            {
                MensajesStandard.MensajeNoIngresoCodigo();
            }
            catch (Exception ex)
            {
                MensajesStandard.MensajeGeneralExcepcionGenerica(ex);
            }
        }
        //método que busca por código
        public void BuscarPorCodigo(String elementoABuscar, DataGridView dataGrid)
        {
            try
            {
                if (elementoABuscar.Length > 0 && elementoABuscar.Length < 11)
                {
                    conexion.AbrirConexion();
                    string query = @"SELECT * FROM dbo.producto where codigoproducto like'" + Int32.Parse(elementoABuscar) + "%'";
                    adaptador = new SqlDataAdapter(query, conexion.GetSqlConnection());
                    conexion.CerrarConexion();
                    MostrarDatos(dataGrid);
                }
                else if (elementoABuscar.Length > 11 || elementoABuscar.Length < 1)
                {
                    MensajesStandard.CodigoIngresadoIncorrecto();
                }
            }
            catch (ArgumentNullException ex)
            {
                MensajesStandard.MensajeNoIngresoCodigo();
            }
            catch (FormatException ex)
            {
                MensajesStandard.CodigoIngresadoIncorrecto();
            }
            catch (Exception ex)
            {
                MensajesStandard.MensajeGeneralExcepcionGenerica(ex);
            }
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
