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
    /// <summary>
    /// Interfaz para buscar elementos de la base de datos
    /// </summary>
    public interface IBuscarElementoPorCodigoBD
    {
        //Método para buscar por código.
        void BuscarPorCodigo(string elementoABuscar, DataGridView dataGrid);
        SqlDataAdapter getSqlAdaptador();
    }
}
