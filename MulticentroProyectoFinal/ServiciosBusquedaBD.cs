using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace MulticentroProyectoFinal
{
    public class ServiciosBusquedaBD : IBuscarElementoPorCodigoYNombre
    {
        //referencia a clase para abrir conexion
        private IConexionesBasicasAbrirCerrarBD conexion;
       // private SqlCommand cmd;
        private SqlDataAdapter adaptador;
       // private SqlDataReader lector;
        public ServiciosBusquedaBD()
        {
            conexion = new ConexionesBasicasAbrirCerrarBD();     
        }       

        public void BuscarPorNombre(String elementoABuscar)
        {
            try
            {
                conexion.AbrirConexion();
                //nombre = guiServiciosIBusqueda.getNombre();
                string query = @"SELECT * FROM dbo.servicio where nombre like'" + elementoABuscar + "%'";
                adaptador = new SqlDataAdapter(query, conexion.GetSqlConnection());
                conexion.CerrarConexion();
            }
            catch (NullReferenceException ex2)
            {
                MessageBox.Show("No se seleccionó un dato correcto, no hay nada que mostrar.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensaje de error  " + ex);
            }
        }

        public void BuscarPorCodigo(String elementoABuscar)
        {
          
            try
            {
                conexion.AbrirConexion();
                string query = @"SELECT * FROM dbo.servicio where codigoservicio like'" + Int32.Parse(elementoABuscar) + "%'";
                adaptador = new SqlDataAdapter(query, conexion.GetSqlConnection());
                conexion.CerrarConexion();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Código ingresado incorrecto, ingrese un código numérico.");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No se seleccionó un dato correcto, no hay nada que mostrar." );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensaje de error  " + ex);
            }
        }

        public SqlDataAdapter getSqlAdaptador()
        {
            return adaptador;
        }
    }
}

