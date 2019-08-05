using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticentroProyectoFinal
{
    /// <summary>
    /// Interfaz para agregar o insertar elementos a la base de datos
    /// </summary>
  public  interface IAgregarElementoBD
    {
        /// <summary>
        /// Método para agregar elementos a la base de datos
        /// </summary>
        bool Agregar();
    }
}
