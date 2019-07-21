using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MulticentroProyectoFinal;

namespace Multicentro.PruebasUnitarias
{
    [TestClass]
    public class ServiciosIngresoBDPruebas
    {
        [DataTestMethod]

        [DataRow("55500", "55500")]
        [DataRow("1340", "1340")]
        [DataRow("4500", "4500")]
        public void SetPrecioo_DatosCorrectos_RetornaMismoDato(string input, string resultado)
        {
            //Arrange
            var expected = resultado;
            ServiciosIngresoBD ingreso = new ServiciosIngresoBD();
            ingreso.Precio = input;
            //Act
            var actual = ingreso.Precio;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [DataTestMethod]

        [DataRow("55500", "500")]
        [DataRow("1340", "340")]
        [DataRow("4500", "500")]
        public void SetPrecioo_DatosInCorrectos_NoRetornaMismoDato(string input, string resultado)
        {
            //Arrange
            var expected = resultado;
            ServiciosIngresoBD ingreso = new ServiciosIngresoBD();
            ingreso.Precio = input;
            //Act
            var actual = ingreso.Precio;

            //Assert
            Assert.AreNotEqual(expected, actual);
        }
        // [TestMethod]
        //public void Agregar_FormatoCodigoIncorrecto_ReturnMensajeFormatException()
        //{
        //    //Arrange
        //    var expected = "Formato incorrecto de datos. Inténtelo de nuevo";
        //    var ingreso = new ServiciosIngresoBD();
        //    ingreso.Nombre = "a";
        //    ingreso.Precio = "a";
        //    ingreso.Codigo = "4500";

        //    //Act
        //    var actual = new ServiciosIngresoBD();
        //    ingreso.Agregar();

        //    //Asert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void VerificarInformacion_TodosDatosVacios_ReturnVerificarInformacionFalse()
        //{
        //    //Arrange

        //    var expected = false;
        //    var ingreso = new ServiciosIngresoBD();

        //    ingreso.Nombre = "";
        //    ingreso.Precio = "";
        //    ingreso.Codigo = "";

        //    //Act
        //    var actual= ingreso.VerificarInformacion();

        //    //Assert
        //    Assert.AreEqual(expected,actual);
        //}
    }
}
