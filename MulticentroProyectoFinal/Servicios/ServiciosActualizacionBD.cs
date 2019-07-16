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

        public ServiciosActualizacionBD()
        {
            //inicializacion de variables
            conexion = new ConexionesBasicasAbrirCerrarBD();
            nombre = guiServiciosActualizacion.getNombre();
            cantidad = guiServiciosActualizacion.getCantidad();
            precio = guiServiciosActualizacion.getPrecio();
        }

        public void Actualizar()
        {
            codigo = Int32.Parse(guiServiciosActualizacion.getCodigoParaActualizar());
            try
            {
                int pre = Int32.Parse(precio);

                cmd = new SqlCommand("update Multicentro.dbo.servicio SET nombre= @nombre, precio=@precio where codigoservicio=@codigoservicio", conexion.GetSqlConnection());
                conexion.AbrirConexion();
                cmd.Parameters.AddWithValue("@codigoservicio", codigo);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@precio", pre);

                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();
                MessageBox.Show("Información actualizada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensaje de error  " + ex);
            }
        }

    }

}

