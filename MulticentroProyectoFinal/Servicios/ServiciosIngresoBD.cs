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
    class ServiciosIngresoBD : IAgregarElementoBD
    {
        //referencia a clase para abrir conexion
        private IConexionesBasicasAbrirCerrarBD conexion;
        //referencia a clase de Windows Form para poder capturar los valores ingresados por el cliente
        private ServiciosIngreso guiServiciosIngreso = (ServiciosIngreso)Application.OpenForms["ServiciosIngreso"];
        private string nombre;
        private string codigo;
        private string precio;
        private SqlCommand cmd;
        IBuscarElementoPorCodigoYNombre busqueda = new ServiciosBusquedaBD();
        public ServiciosIngresoBD()
        {
            //inicializacion de variables
            conexion = new ConexionesBasicasAbrirCerrarBD();
            nombre = guiServiciosIngreso.GetNombre();
            codigo = guiServiciosIngreso.GetCodigo();
            precio = guiServiciosIngreso.GetPrecio();
        }
        //Implementación de método de la interfaz

        //método para agregar datos
        public void Agregar()
        {
            try
            {
                if (VerificarInformacion() )
                {
                    conexion.AbrirConexion();

                    cmd = new SqlCommand("insert into Multicentro.dbo.servicio (codigoservicio,nombre,precio)" +
                        " values('" + int.Parse(codigo) + "', '" + nombre + "', '" + int.Parse(precio) + "')", conexion.GetSqlConnection());
                    cmd.ExecuteNonQuery();
                    conexion.CerrarConexion();

                    busqueda.BuscarPorCodigo(guiServiciosIngreso.GetCodigo(), guiServiciosIngreso.GetDataView());
                    MessageBox.Show("Información agregada");
                }
                
            }
            catch (FormatException ex)
            {
                MensajesStandard.MensajeFormatoIncorrectoDatos();
            }
            catch (SqlException ex)
            {
                MensajesStandard.MensajeCodigoNuevoYaExistente();
            }
            catch (Exception ex)
            {
                MensajesStandard.MensajeGeneralExcepcionGenerica(ex);
            }
        }
        /// <summary>
        /// Método que verifica que no se hayan dejado en blanco nombre, código y precio
        /// </summary>
        /// <returns></returns>
        public bool VerificarInformacion()
        {
            if (nombre.Length == 0 || codigo.Length == 0 || precio.Length == 0)
            {
                MessageBox.Show("No puede dejar espacios en blanco");
                return false;
            }
            return true;
        }

    }
}


