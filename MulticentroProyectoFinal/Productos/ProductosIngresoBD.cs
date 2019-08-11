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
    class ProductosIngresoBD : IAgregarElementoBD
    {
        //referencia a clase para abrir conexion
        private IConexionesBasicasAbrirCerrarBD conexion;
        //referencia a clase de Windows Form para poder capturar los valores ingresados por el cliente
        private ProductoIngreso guiProductosIngreso = (ProductoIngreso)Application.OpenForms["ProductoIngreso"];
        private string nombre;
        private string codigo;
        private string precio;
        private string cantidad;
        private SqlCommand cmd;
        IBuscarElementoPorCodigoYNombre busqueda = new ProductosBusquedaBD();
        public ProductosIngresoBD()
        {
            //inicializacion de variables
            conexion = new ConexionesBasicasAbrirCerrarBD();
            nombre = guiProductosIngreso.GetNombre();
            codigo = guiProductosIngreso.GetCodigo();
            precio = guiProductosIngreso.GetPrecio();
            cantidad = guiProductosIngreso.GetCantidad();
        }
        //Implementación de método de la interfaz

        //método para agregar datos
        public bool Agregar()
        {
            try
            {
                if (VerificarInformacion())
                {
                    conexion.AbrirConexion();

                    cmd = new SqlCommand("insert into Multicentro.dbo.producto (codigoproducto,nombre,cantidad,precio)" +
                        " values('" + int.Parse(codigo) + "', '" + nombre + "', '" + int.Parse(cantidad) + "', '" + int.Parse(precio) + "')", conexion.GetSqlConnection());
                    cmd.ExecuteNonQuery();
                    conexion.CerrarConexion();

                    busqueda.BuscarPorCodigo(guiProductosIngreso.GetCodigo(), guiProductosIngreso.GetDataView());
                    MessageBox.Show("Información agregada");
                    return true;
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
            return false;
        }
        /// <summary>
        /// Método que verifica que no se hayan dejado en blanco nombre, código, precio y cantidad
        /// </summary>
        /// <returns></returns>
        public bool VerificarInformacion()
        {
            if (nombre.Length == 0 || codigo.Length == 0 || precio.Length == 0 || cantidad.Length == 0)
            {
                MessageBox.Show("No puede dejar espacios en blanco");
                return false;
            }
            return true;
        }
    }
}
