using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace MulticentroProyectoFinal.Interfaces
{
    interface IReporteProducto
    {
        void reporteProducto(string fechaInicial, string fechaFInal, DataGridView dataGrid);
    }
}

