using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MulticentroProyectoFinal
{
    //Singleton
    public class MensajesStandard
    {
        public static void CodigoIngresadoIncorrecto()
        {
            MessageBox.Show("Código ingresado incorrecto.");
        }

        public static void MensajeGeneralExcepcionGenerica(Exception ex)
        {
            MessageBox.Show("Mensaje de error general " + ex);
        }

        public static void MensajeNoIngresoCodigo()
        {
            MessageBox.Show("No ingresó un código");
        }
        public static void MensajeFormatoIncorrectoDatos()
        {
            MessageBox.Show("Formato incorrecto de datos. Inténtelo de nuevo");
        }

        public static void MensajeCodigoNuevoYaExistente()
        {
            MessageBox.Show("Ese código ya existe en la base de datos, ingrese otro código.");
        }
        public static void MensajeErrorGeneralBaseDatos()
        {
            MessageBox.Show("Error al ingresar los datos a la base de datos, verifique la información ingresada.");
        }
        
    }
}
