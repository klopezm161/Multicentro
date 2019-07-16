using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticentroProyectoFinal
{
    /// <summary>
    /// Interfaz con tres funcionalidades de BD: insertar, buscar, actualizar
    /// </summary>
    public interface IActualizarBuscarAgregarBD: IBuscarElementoPorCodigoBD, IAgregarElementoBD, IActualizarElementoBD
    {
    }
}
