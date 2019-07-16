using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
namespace MulticentroProyectoFinal
{
    /// <summary>
    /// Clase dedicada a poder abrir y cerra la conexion a la base de datos utilizando App.Config
    /// </summary>
    public class ConexionesBasicasAbrirCerrarBD : IConexionesBasicasAbrirCerrarBD
    {
        //declaracion de variables globales que se usarán en los métodos de Open y Close
        private string stringConexion;
        private SqlConnection conexion;

        /// <summary>
        /// Constructor que inicializa las variables globales
        /// </summary>
        public ConexionesBasicasAbrirCerrarBD()
        {
            stringConexion = ConfigurationManager.ConnectionStrings["MyConnStr"].ConnectionString;
            conexion = new SqlConnection(stringConexion);
        }            

        //Al ser interfaz es necesario implementar los metodos de la misma.

        /// <summary>
        /// Metodo para abrir conexion a base de datos
        /// </summary>
        public void AbrirConexion()
        {
            conexion.Open();           
        }
        /// <summary>
        /// Metodo para cerrar conexion a base de datos
        /// </summary>
        public void CerrarConexion()
        {
            conexion.Close();
        }
        /// <summary>
        /// metodo getter para acceder a la variable de SqlConnection
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetSqlConnection()
        {
            return conexion;
        }

    }
}
