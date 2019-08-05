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
    public class ServiciosIngresoBD : IAgregarElementoBD
    {
        //referencia a clase para abrir conexion
        private IConexionesBasicasAbrirCerrarBD conexion;
        //referencia a clase de Windows Form para poder capturar los valores ingresados por el cliente
        private ServiciosIngreso guiServiciosIngreso = (ServiciosIngreso)Application.OpenForms["ServiciosIngreso"];
        //declaracion de propiedades Nombre, codigo, precio con su respectivo getter y setter
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Precio { get; set; }
        private SqlCommand cmd;
        IBuscarElementoPorCodigoYNombre busqueda;
        public ServiciosIngresoBD()
        {
            //inicializacion de variables
            //conexion = new ConexionesBasicasAbrirCerrarBD();
            //Nombre = guiServiciosIngreso.GetNombre();
            //Codigo = guiServiciosIngreso.GetCodigo();
            //Precio = guiServiciosIngreso.GetPrecio();
        }
        //Implementación de método de la interfaz

        /// <summary>
        /// método para agregar datos a servicios
        /// </summary>
        public bool Agregar()
        {
            busqueda = new ServiciosBusquedaBD();
            conexion = new ConexionesBasicasAbrirCerrarBD();
            Nombre = guiServiciosIngreso.GetNombre();
            Codigo = guiServiciosIngreso.GetCodigo();
            Precio = guiServiciosIngreso.GetPrecio();
            try
            {
                if (VerificarInformacion() )
                {
                    conexion.AbrirConexion();

                    cmd = new SqlCommand("insert into Multicentro.dbo.servicio (codigoservicio,nombre,precio)" +
                        " values('" + int.Parse(Codigo) + "', '" + Nombre + "', '" + int.Parse(Precio) + "')", conexion.GetSqlConnection());
                    cmd.ExecuteNonQuery();
                    conexion.CerrarConexion();

                    busqueda.BuscarPorCodigo(guiServiciosIngreso.GetCodigo(), guiServiciosIngreso.GetDataView());
                    MessageBox.Show("Información agregada");
                    return true;
                }
              
            }
            
            catch (FormatException ex)
            {
                MensajesStandard.MensajeFormatoIncorrectoDatos();
                return false;
            }
            catch (SqlException ex)
            {
                MensajesStandard.MensajeErrorGeneralBaseDatos();
                return false;
            }
            catch (Exception ex)
            {
                MensajesStandard.MensajeGeneralExcepcionGenerica(ex);
                return false;
            }
            return false;  
        }
        /// <summary>
        /// Método que verifica que no se hayan dejado en blanco nombre, código y precio
        /// </summary>
        /// <returns></returns>
        public bool VerificarInformacion()
        {
            if (Nombre.Length == 0 || Codigo.Length == 0 || Precio.Length == 0)
            {
                MessageBox.Show("No puede dejar espacios en blanco");
                return false;
            }
            return true;
        }

    }
}


