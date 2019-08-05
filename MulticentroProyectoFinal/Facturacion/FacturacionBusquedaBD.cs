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
    class FacturacionBusquedaBD : IBuscarElementoPorCodigoBD
    {

        //referencia a clase para abrir conexion
        private IConexionesBasicasAbrirCerrarBD conexion;
        // private SqlCommand cmd;
        private SqlDataAdapter adaptador;
        // private SqlDataReader lector;

        //constructor que inicializa la conexion
        public FacturacionBusquedaBD()
        {
            conexion = new ConexionesBasicasAbrirCerrarBD();
        }
        //Implementación de métodos de la interfaz
        public void BuscarPorCodigo(String elementoABuscar, DataGridView dataGrid)
        {
            try
            {

                conexion.AbrirConexion();
                string query = @"SELECT * FROM dbo.servicio where codigoservicio like'" + Int32.Parse(elementoABuscar) + "%'";
                adaptador = new SqlDataAdapter(query, conexion.GetSqlConnection());
                conexion.CerrarConexion();
                MostrarDatos(dataGrid);


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
        public void MostrarDatos(DataGridView dataGrid)
        {
            try
            {
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGrid.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No se encontró el dato que buscaba. Inténtelo de nuevo");
                }
            }
            catch (NullReferenceException ex) { }
        }
        public SqlDataAdapter getSqlAdaptador()
        {
            return adaptador;
        }
    }

}

