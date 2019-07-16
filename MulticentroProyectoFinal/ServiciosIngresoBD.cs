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
       

        public ServiciosIngresoBD()
        {
            //inicializacion de variables
            conexion = new ConexionesBasicasAbrirCerrarBD();
            nombre = guiServiciosIngreso.getNombre();
            codigo = guiServiciosIngreso.getCodigo();
            precio = guiServiciosIngreso.getPrecio();
        }

        /// <summary>
        /// Método para agregar/insertar datos a servicios en base de datos
        /// </summary>
        public void Agregar()
        {
            try
            {
                if (VerificarInformacion())
                {
                    conexion.AbrirConexion();

                    cmd = new SqlCommand("insert into Multicentro.dbo.servicio (codigoservicio,nombre,precio)" +
                        " values('" + int.Parse(codigo) + "', '" + nombre + "', '" + int.Parse(precio) + "')", conexion.GetSqlConnection());
                    cmd.ExecuteNonQuery();
                    conexion.CerrarConexion();
                    MessageBox.Show("Información agregada");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato incorrecto de datos. Inténtelo de nuevo");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR DE BASE DE DATOS. Inténtelo de nuevo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensaje de error  " + ex);
            }
        }

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

