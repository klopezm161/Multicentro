using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Globalization;
using MulticentroProyectoFinal.GUI;

namespace MulticentroProyectoFinal
{
    class FacturacionAgregarBD : IAgregarElementoBD
    {
        //referencia a clase para abrir conexion
        private IConexionesBasicasAbrirCerrarBD conexion;
        //referencia a clase de Windows Form para poder capturar los valores ingresados por el cliente
        private FacturarCrear guiFacturacionesCrear = (FacturarCrear)Application.OpenForms["FacturarCrear"];
        // private FacturacionProducto facturacionProducto = (FacturacionProducto)Application.OpenForms["FacturacionProducto"];
        //private FacturacionServicio facturacionServicio = (FacturacionServicio)Application.OpenForms["FacturacionServicio"];
        //declaracion de propiedades Nombre, codigo, precio con su respectivo getter y setter
        public string fecha { get; set; }
        public string cantidad { get; set; }
        public string precio { get; set; }
        public string numFactura { get; set; }
        public string idCliente { get; set; }
        public string tipo { get; set; }
        public string producto { get; set; }
        public string servicio { get; set; }

        private SqlCommand cmd;
        IBuscarElementoPorCodigoBD busqueda;
        public FacturacionAgregarBD()
        {

        }
        //Implementación de método de la interfaz

        /// <summary>
        /// método para agregar datos a servicios
        /// </summary>
        public bool Agregar()
        {
            busqueda = new FacturacionBusquedaBD();
            conexion = new ConexionesBasicasAbrirCerrarBD();
            fecha = guiFacturacionesCrear.GetFecha();


            numFactura = guiFacturacionesCrear.GetNumFactura();
            idCliente = guiFacturacionesCrear.GetNombreCliente();
            tipo = guiFacturacionesCrear.GetTipo();

            try
            {
                conexion.AbrirConexion();
                cmd = new SqlCommand("insert into Multicentro.dbo.factura (facturaid,cliente_clienteid,fecha)" +
                " values('" + int.Parse(numFactura) + "', '" + int.Parse(idCliente) + "', '" + fecha + "')", conexion.GetSqlConnection());
                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();
                return true;

            }
            catch (FormatException ex)
            {
                MensajesStandard.MensajeFormatoIncorrectoDatos();
            }
            catch (SqlException ex)
            {
                MensajesStandard.MensajeErrorGeneralBaseDatos();
            }
            catch (Exception ex)
            {
                MensajesStandard.MensajeGeneralExcepcionGenerica(ex);
            }
            return false;
        }
        /// <summary>
        /// Método que verifica que no se hayan dejado en blanco nombre, código y precio
        /// </summary>
        /// <returns></returns>
        public bool VerificarInformacion()
        {
            if (numFactura.Length == 0 || idCliente.Length == 0 || tipo.Length == 0)
            {
                MessageBox.Show("No puede dejar espacios en blanco");
                return false;
            }
            return true;
        }

    }
}
//public bool Agregar()
//{
//    busqueda = new FacturacionBusquedaBD();
//    conexion = new ConexionesBasicasAbrirCerrarBD();
//    fecha = guiFacturacionesCrear.GetFecha();


//    numFactura = guiFacturacionesCrear.GetNumFactura();
//    idCliente = guiFacturacionesCrear.GetNombreCliente();
//    tipo = guiFacturacionesCrear.GetTipo();


//    try
//    {
//        if (VerificarInformacion())
//        {

//            if (tipo.Equals("Servicio"))
//            {
//                servicio = facturacionServicio.getServicio();
//                cantidad = facturacionServicio.getCantidad();
//                conexion.AbrirConexion();
//                cmd = new SqlCommand("insert into Multicentro.dbo.factura (facturaid,cliente_clienteid,fecha,servicio,producto,cantidad,precio,tipo)" +
//                " values('" + int.Parse(numFactura) + "', '" + int.Parse(idCliente) + "', '" + fecha + "', '" + int.Parse(servicio) + "', '" + null + "', '" + int.Parse(cantidad) + "', '" + null + "', '" + "Servicio" + "')", conexion.GetSqlConnection());
//                cmd.ExecuteNonQuery();
//                conexion.CerrarConexion();
//            }
//            else
//            {
//                producto = facturacionProducto.getProducto();
//                cantidad = facturacionProducto.getCantidad();
//                conexion.AbrirConexion();
//                cmd = new SqlCommand("insert into Multicentro.dbo.factura (facturaid,cliente_clienteid,fecha,servicio,producto,cantidad,precio,tipo)" +
//                " values('" + int.Parse(numFactura) + "', '" + int.Parse(idCliente) + "', '" + fecha + "', '" + null + "', '" + int.Parse(producto) + "', '" + int.Parse(cantidad) + "', '" + null + "', '" + "Producto" + "')", conexion.GetSqlConnection());
//                cmd.ExecuteNonQuery();
//                conexion.CerrarConexion();
//            }


//            busqueda.BuscarPorCodigo(guiFacturacionesCrear.GetNumFactura(), guiFacturacionesCrear.GetDataView());
//            MessageBox.Show("Información agregada");
//            return true;
//        }

//    }
//    catch (FormatException ex)
//    {
//        MensajesStandard.MensajeFormatoIncorrectoDatos();
//    }
//    catch (SqlException ex)
//    {
//        MensajesStandard.MensajeErrorGeneralBaseDatos();
//    }
//    catch (Exception ex)
//    {
//        MensajesStandard.MensajeGeneralExcepcionGenerica(ex);
//    }
//    return false;
//}