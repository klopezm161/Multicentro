using System.Configuration;
using System.Data.SqlClient;
namespace MulticentroProyectoFinal
{
    /// <summary>
    /// Interfaz para la funcion basica de abrir y cerrar conexion
    /// </summary>
    public interface IConexionesBasicasAbrirCerrarBD
    {
        void AbrirConexion();
        void CerrarConexion();

        SqlConnection GetSqlConnection();
    }
}