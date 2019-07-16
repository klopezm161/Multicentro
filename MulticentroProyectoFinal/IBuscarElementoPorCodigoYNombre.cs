using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticentroProyectoFinal
{
    public interface IBuscarElementoPorCodigoYNombre: IBuscarElementoPorCodigoBD
    {
        void BuscarPorNombre(string elementoABuscar);
    }
}
