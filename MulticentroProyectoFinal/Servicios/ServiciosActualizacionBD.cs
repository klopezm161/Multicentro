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
    public class ServiciosActualizacionBD : IActualizarElementoBD
    {
        //referencia a clase para abrir conexion
        private IConexionesBasicasAbrirCerrarBD conexion;
        //referencia a clase de Windows Form para poder capturar los valores ingresados por el cliente
        private ServiciosActualizacion guiServiciosActualizacion = (ServiciosActualizacion)Application.OpenForms["ServiciosActualizacion"];
        //declaracion de propiedades con su respectivo getter y setter
        public string Nombre { get; set; }
        public  string Cantidad { get; set; }
        public string Precio { get; set; }
        public int Codigo { get; set; }
        private SqlCommand cmd;
        private SqlDataAdapter adaptador;
        public String CodigoEnStr{ get; set; }

        public ServiciosActualizacionBD()
        {
            //inicializacion de variables
            //conexion = new ConexionesBasicasAbrirCerrarBD();
            //Nombre = guiServiciosActualizacion.GetNombre();
            //Cantidad = guiServiciosActualizacion.GetCantidad();
            //Precio = guiServiciosActualizacion.GetPrecio();

        }
        /// <summary>
        /// métodos para actualizar elementos a la base de datos
        /// </summary>
        public void Actualizar()
        {
            conexion = new ConexionesBasicasAbrirCerrarBD();
            Nombre = guiServiciosActualizacion.GetNombre();           
            Precio = guiServiciosActualizacion.GetPrecio();

            try
            {
                CodigoEnStr = guiServiciosActualizacion.GetCodigoParaActualizar();
                if (CodigoEnStr.Length<1)
                {
                    MensajesStandard.MensajeNoIngresoCodigo();
                }

                else if (Nombre.Length == 0 && Precio.Length == 0)
                {
                    MessageBox.Show("No ingresó datos a actualizar");
                }

                else
                {
                    Codigo = Int32.Parse(guiServiciosActualizacion.GetCodigoParaActualizar());
                    if (Nombre.Length > 0 && Precio.Length > 0)
                        ActualizarTodosDatos();

                    else if (Nombre.Length > 0 && Precio.Length == 0)
                    {
                        ActualizarNombre();
                    }
                    else if (Nombre.Length == 0 && Precio.Length > 0)
                    {
                        ActualizarPrecio();
                    }
                    
                    IBuscarElementoPorCodigoYNombre busqueda = new ServiciosBusquedaBD();
                    busqueda.BuscarPorCodigo(guiServiciosActualizacion.GetCodigoParaActualizar(), guiServiciosActualizacion.GetDataGridView());
                    MessageBox.Show("Información actualizada");
                    
                }
            }
            catch (SqlException ex)
            {
                MensajesStandard.MensajeErrorGeneralBaseDatos();
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
            float pre = float.Parse(Precio);

            cmd = new SqlCommand("update Multicentro.dbo.servicio SET nombre= @nombre, precio=@precio where codigoservicio=@codigoservicio", conexion.GetSqlConnection());
            conexion.AbrirConexion();
            cmd.Parameters.AddWithValue("@codigoservicio", Codigo);
            cmd.Parameters.AddWithValue("@nombre", Nombre);
            cmd.Parameters.AddWithValue("@precio", pre);

            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        //metodo que actualiza nombre a servicios
        public void ActualizarNombre()
        {
            cmd = new SqlCommand("update Multicentro.dbo.servicio SET nombre= @nombre where codigoservicio=@codigoservicio", conexion.GetSqlConnection());
            conexion.AbrirConexion();
            cmd.Parameters.AddWithValue("@codigoservicio", Codigo);
            cmd.Parameters.AddWithValue("@nombre", Nombre);
            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        //método que actualiza precio a servicios
        public void ActualizarPrecio()
        {
            double pre = double.Parse(Precio);

            cmd = new SqlCommand("update Multicentro.dbo.servicio SET  precio=@precio where codigoservicio=@codigoservicio", conexion.GetSqlConnection());
            conexion.AbrirConexion();
            cmd.Parameters.AddWithValue("@codigoservicio", Codigo);
            cmd.Parameters.AddWithValue("@precio", pre);
            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();

        }

    }

}

