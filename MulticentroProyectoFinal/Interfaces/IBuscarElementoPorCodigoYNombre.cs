using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MulticentroProyectoFinal
{
    public interface IBuscarElementoPorCodigoYNombre: IBuscarElementoPorCodigoBD
    {
        void BuscarPorNombre(string elementoABuscar,DataGridView dataGrid);
    }
}
