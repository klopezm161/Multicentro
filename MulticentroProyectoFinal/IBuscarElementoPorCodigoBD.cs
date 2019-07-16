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
    /// Interfaz para buscar elementos de la base de datos
    /// </summary>
    public interface IBuscarElementoPorCodigoBD
    {
        /// <summary>
        /// Buscar elemento en base de datos por código o número
        /// </summary>
        /// <param name="elementoABuscar"></param>
        void BuscarPorCodigo(string elementoABuscar);
        SqlDataAdapter getSqlAdaptador();
    }
}
