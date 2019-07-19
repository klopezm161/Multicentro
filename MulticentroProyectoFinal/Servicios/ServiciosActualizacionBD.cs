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
    class ServiciosActualizacionBD : IActualizarElementoBD
    {
        //referencia a clase para abrir conexion
        private IConexionesBasicasAbrirCerrarBD conexion;
        //referencia a clase de Windows Form para poder capturar los valores ingresados por el cliente
        private ServiciosActualizacion guiServiciosActualizacion = (ServiciosActualizacion)Application.OpenForms["ServiciosActualizacion"];
        private string nombre;
        private string cantidad;
        private string precio;
        private int codigo;
        private SqlCommand cmd;
        private SqlDataAdapter adaptador;
        private String codigoEnStr;

        public ServiciosActualizacionBD()
        {
            //inicializacion de variables
            conexion = new ConexionesBasicasAbrirCerrarBD();
            nombre = guiServiciosActualizacion.GetNombre();
            cantidad = guiServiciosActualizacion.GetCantidad();
            precio = guiServiciosActualizacion.GetPrecio();

        }
        /// <summary>
        /// métodos para actualizar elementos a la base de datos
        /// </summary>
        public void Actualizar()
        {
            try
            {
                codigoEnStr = guiServiciosActualizacion.GetCodigoParaActualizar();
                if (codigoEnStr.Length<1)
                {
                    MensajesStandard.MensajeNoIngresoCodigo();
                }

                else if (nombre.Length == 0 && precio.Length == 0)
                {
                    MessageBox.Show("No ingresó datos a actualizar");
                }

                else
                {
                    codigo = Int32.Parse(guiServiciosActualizacion.GetCodigoParaActualizar());
                    if (nombre.Length > 0 && precio.Length > 0)
                        ActualizarTodosDatos();

                    else if (nombre.Length > 0 && precio.Length == 0)
                    {
                        ActualizarNombre();
                    }
                    else if (nombre.Length == 0 && precio.Length > 0)
                    {
                        ActualizarPrecio();
                    }
                    
                    IBuscarElementoPorCodigoYNombre busqueda = new ServiciosBusquedaBD();
                    busqueda.BuscarPorCodigo(guiServiciosActualizacion.GetCodigoParaActualizar(), guiServiciosActualizacion.GetDataGridView());
                    MessageBox.Show("Información actualizada");
                    
                }
            }
            catch (FormatException ex)
            {
                MensajesStandard.MensajeFormatoIncorrectoDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensaje de error  " + ex);
            }
        }
        //metodo que actualiza nombre, precio, codigo a Servicios
        public void ActualizarTodosDatos()
        {
            int pre = Int32.Parse(precio);

            cmd = new SqlCommand("update Multicentro.dbo.servicio SET nombre= @nombre, precio=@precio where codigoservicio=@codigoservicio", conexion.GetSqlConnection());
            conexion.AbrirConexion();
            cmd.Parameters.AddWithValue("@codigoservicio", codigo);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@precio", pre);

            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        //metodo que actualiza nombre
        public void ActualizarNombre()
        {
            cmd = new SqlCommand("update Multicentro.dbo.servicio SET nombre= @nombre where codigoservicio=@codigoservicio", conexion.GetSqlConnection());
            conexion.AbrirConexion();
            cmd.Parameters.AddWithValue("@codigoservicio", codigo);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        //método que actualiza precio
        public void ActualizarPrecio()
        {
            int pre = Int32.Parse(precio);

            cmd = new SqlCommand("update Multicentro.dbo.servicio SET  precio=@precio where codigoservicio=@codigoservicio", conexion.GetSqlConnection());
            conexion.AbrirConexion();
            cmd.Parameters.AddWithValue("@codigoservicio", codigo);
            cmd.Parameters.AddWithValue("@precio", pre);
            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();

        }

    }

}

