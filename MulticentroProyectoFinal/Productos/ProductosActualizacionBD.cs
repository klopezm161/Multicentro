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
    class ProductosActualizacionBD : IActualizarElementoBD
    {
        //referencia a clase para abrir conexion
        private IConexionesBasicasAbrirCerrarBD conexion;
        //referencia a clase de Windows Form para poder capturar los valores ingresados por el cliente
        private ProductoActualizacion guiProductosActualizacion = (ProductoActualizacion)Application.OpenForms["ProductoActualizacion"];
        private string nombre;
        private string cantidad;
        private string precio;
        private int codigo;
        private SqlCommand cmd;
        private SqlDataAdapter adaptador;
        private String codigoEnStr;

        public ProductosActualizacionBD()
        {
            //inicializacion de variables
            conexion = new ConexionesBasicasAbrirCerrarBD();
            nombre = guiProductosActualizacion.GetNombre();
            cantidad = guiProductosActualizacion.GetCantidad();
            precio = guiProductosActualizacion.GetPrecio();

        }
        /// <summary>
        /// métodos para actualizar elementos a la base de datos
        /// </summary>
        public void Actualizar()
        {
            try
            {
                codigoEnStr = guiProductosActualizacion.GetCodigoParaActualizar();
                if (codigoEnStr.Length < 1)
                {
                    MensajesStandard.MensajeNoIngresoCodigo();
                }

                else if (nombre.Length == 0 && precio.Length == 0)
                {
                    MessageBox.Show("No ingresó datos a actualizar");
                }

                else
                {
                    codigo = Int32.Parse(guiProductosActualizacion.GetCodigoParaActualizar());
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
            int Cantidad = Int32.Parse(cantidad);
            decimal pre = decimal.Parse(precio);

            cmd = new SqlCommand("update Multicentro.dbo.producto SET nombre= @nombre, cantidad=@cantidad, precio=@precio where codigoproducto=@codigoproducto", conexion.GetSqlConnection());
            conexion.AbrirConexion();
            cmd.Parameters.AddWithValue("@codigoproducto", codigo);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@cantidad", Cantidad);
            cmd.Parameters.AddWithValue("@precio", pre);

            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        //metodo que actualiza nombre
        public void ActualizarNombre()
        {
            cmd = new SqlCommand("update Multicentro.dbo.producto SET nombre= @nombre where codigoproducto=@codigoproducto", conexion.GetSqlConnection());
            conexion.AbrirConexion();
            cmd.Parameters.AddWithValue("@codigoproducto", codigo);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        //método que actualiza precio
        public void ActualizarPrecio()
        {
            decimal pre = decimal.Parse(precio);

            cmd = new SqlCommand("update Multicentro.dbo.producto SET  precio=@precio where codigoproducto=@codigoproducto", conexion.GetSqlConnection());
            conexion.AbrirConexion();
            cmd.Parameters.AddWithValue("@codigoproducto", codigo);
            cmd.Parameters.AddWithValue("@precio", pre);
            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();

        }

        //método que actualiza cantidad
        public void ActualizarCantidad()
        {
            int Cantidad = Int32.Parse(cantidad);

            cmd = new SqlCommand("update Multicentro.dbo.producto SET  cantidad=@cantidad where codigoproducto=@codigoproducto", conexion.GetSqlConnection());
            conexion.AbrirConexion();
            cmd.Parameters.AddWithValue("@codigoproducto", codigo);
            cmd.Parameters.AddWithValue("@cantidad", Cantidad);
            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();

        }
    }
}

