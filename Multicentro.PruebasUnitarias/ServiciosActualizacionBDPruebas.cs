using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MulticentroProyectoFinal;


namespace Multicentro.PruebasUnitarias
{
    [TestClass]
    public class ServiciosActualizacionBDPruebas
    {
        [TestMethod]
        public void SetNombre_DatosCorrectos_RetornaMismoDato()
        {
            //Arrange
            var expected = "a";
            ServiciosActualizacionBD ingreso = new ServiciosActualizacionBD();
            ingreso.Nombre = "a";
            //Act
            var actual = ingreso.Nombre;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]

        [DataRow("14", "14")]
        [DataRow("10", "10")]
        [DataRow("11", "11")]
        public void SetCodigo_DatosCorrectos_RetornaMismoDato(string input, string resultado)
        {
            //Arrange
            var expected = resultado;
            ServiciosActualizacionBD ingreso = new ServiciosActualizacionBD();
            ingreso.CodigoEnStr = input;
            //Act
            var actual = ingreso.CodigoEnStr;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        //ServiciosActualizacion actualizacion = new ServiciosActualizacion();
        //string nombre = "";
        //string precio = "";
        //string codigo = "1";
        //  [TestMethod]
        //public void Actualizar_TodosDatosVacios_Retorna_MensajeNoIngresoDatos()
        //{
        //    //Arrange
        //    var expected = "No ingresó un código";

        //    actualizacion.SetNombre(nombre);
        //    actualizacion.SetPrecio(precio);
        //    actualizacion.SetCodigoParaActualizar(codigo);
        //    //Act
        //    var actual = new ServiciosActualizacionBD();
        //    actual.Actualizar();

        //    //Assert
        //    Assert.AreEqual(expected, actual);

        //}

    }
}
