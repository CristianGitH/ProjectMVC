using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectMVC.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalcularPotenciaDosALaDos()
        {
            //Arrange

            Logica.Services.TestClass test = new Logica.Services.TestClass();
            int num = 2, potencia = 2;

            //Act

            double result = test.CalcularPotencia(num, potencia);

            //Assert

            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void ContarDivisoresDeDies()
        {
            //Arrange

            Logica.Services.TestClass test = new Logica.Services.TestClass();
            int num = 10;

            //Act
            int result = test.ContarDivisores(num);

            //Assert

            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void ContarDivisoresDeCincuenta()
        {
            //Arrange

            Logica.Services.TestClass test = new Logica.Services.TestClass();
            int num = 50;

            //Act
            int result = test.ContarDivisores(num);

            //Assert

            Assert.AreEqual(result, 6);
        }

        [TestMethod]
        public void ContarDivisoresDeSesenta()
        {
            //Arrange

            Logica.Services.TestClass test = new Logica.Services.TestClass();
            int num = 60;

            //Act
            int result = test.ContarDivisores(num);

            //Assert

            Assert.AreEqual(result, 12);
        }

        [TestMethod]
        public void ContarDivisoresDeOchenta()
        {
            //Arrange

            Logica.Services.TestClass test = new Logica.Services.TestClass();
            int num = 80;

            //Act
            int result = test.ContarDivisores(num);

            //Assert

            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        public void ContarDivisoresDeCien()
        {
            //Arrange

            Logica.Services.TestClass test = new Logica.Services.TestClass();
            int num = 10;

            //Act
            int result = test.ContarDivisores(num);

            //Assert

            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void ConsultarProductoUno()
        {
            //Arrange

            Logica.Services.TestClass test = new Logica.Services.TestClass();
            int codigo = 1250;

            //Act

            double result = test.ObtenerValorProducto(codigo);

            //Assert

            Assert.AreEqual(result, 15500);
        }

        [TestMethod]
        public void ConsultarProductoDos()
        {
            //Arrange

            Logica.Services.TestClass test = new Logica.Services.TestClass();
            int codigo = 1251;

            //Act

            double result = test.ObtenerValorProducto(codigo);

            //Assert

            Assert.AreEqual(result, 18500);
        }

        [TestMethod]
        public void ConsultarProductoTres()
        {
            //Arrange

            Logica.Services.TestClass test = new Logica.Services.TestClass();
            int codigo = 1252;

            //Act

            double result = test.ObtenerValorProducto(codigo);

            //Assert

            Assert.AreEqual(result, 20000);
        }

        [TestMethod]
        public void ConsultarProductoCuatro()
        {
            //Arrange

            Logica.Services.TestClass test = new Logica.Services.TestClass();
            int codigo = 1253;

            //Act

            double result = test.ObtenerValorProducto(codigo);

            //Assert

            Assert.AreEqual(result, 10000);
        }

        [TestMethod]
        public void ConsultarProductoCinco()
        {
            //Arrange

            Logica.Services.TestClass test = new Logica.Services.TestClass();
            int codigo = 1254;

            //Act

            double result = test.ObtenerValorProducto(codigo);

            //Assert

            Assert.AreEqual(result, 30000);
        }

        [TestMethod]
        public void CalcularSubtotalUno()
        {
            //Arrange

            Logica.Services.TestClass test = new Logica.Services.TestClass();
            int codigo = 1250;
            int cantidad = 2;

            //Act

            double result = test.CalcularSubtotal(codigo, cantidad);

            //Assert

            Assert.AreEqual(result, 31000);
        }

        [TestMethod]
        public void CalcularSubtotalDos()
        {
            //Arrange

            Logica.Services.TestClass test = new Logica.Services.TestClass();
            int codigo = 1251;
            int cantidad = 3;

            //Act

            double result = test.CalcularSubtotal(codigo, cantidad);

            //Assert

            Assert.AreEqual(result, 55500);
        }

        [TestMethod]
        public void CalcularSubtotalTres()
        {
            //Arrange

            Logica.Services.TestClass test = new Logica.Services.TestClass();
            int codigo = 1252;
            int cantidad = 5;

            //Act

            double result = test.CalcularSubtotal(codigo, cantidad);

            //Assert

            Assert.AreEqual(result, 100000);
        }

        [TestMethod]
        public void CalcularSubtotalCuatro()
        {
            //Arrange

            Logica.Services.TestClass test = new Logica.Services.TestClass();
            int codigo = 1253;
            int cantidad = 2;

            //Act

            double result = test.CalcularSubtotal(codigo, cantidad);

            //Assert

            Assert.AreEqual(result, 20000);
        }

        [TestMethod]
        public void CalcularSubtotalCinco()
        {
            //Arrange

            Logica.Services.TestClass test = new Logica.Services.TestClass();
            int codigo = 1254;
            int cantidad = 2;

            //Act

            double result = test.CalcularSubtotal(codigo, cantidad);

            //Assert

            Assert.AreEqual(result, 60000);
        }

        [TestMethod]
        public void CalcularDescuentoUno()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            double Subtotal = 600000;

            //Act
            double result = test.CalcularDescuento(Subtotal);

            //Assert
            Assert.AreEqual(result, 570000);
        }

        [TestMethod]
        public void CalcularDescuentoDos()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            double Subtotal = 300000;

            //Act
            double result = test.CalcularDescuento(Subtotal);

            //Assert
            Assert.AreEqual(result, 300000);
        }

        [TestMethod]
        public void CalcularDescuentoTres()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            double Subtotal = 1100000;

            //Act
            double result = test.CalcularDescuento(Subtotal);

            //Assert
            Assert.AreEqual(result, 990000);
        }

        [TestMethod]
        public void CalcularDescuentoCuatro()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            double Subtotal = 1460000;

            //Act
            double result = test.CalcularDescuento(Subtotal);

            //Assert
            Assert.AreEqual(result, 1314000);
        }

        [TestMethod]
        public void CalcularDescuentoCinco()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            double Subtotal = 500000;

            //Act
            double result = test.CalcularDescuento(Subtotal);

            //Assert
            Assert.AreEqual(result, 475000);
        }

        [TestMethod]
        public void CalcularIvaUno()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            double Subtotal = 500000;

            //Act
            double result = test.CalcularIVA(Subtotal);

            //Assert
            Assert.AreEqual(result, 95000);
        }

        [TestMethod]
        public void CalcularIvaDos()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            double Subtotal = 800000;

            //Act
            double result = test.CalcularIVA(Subtotal);

            //Assert
            Assert.AreEqual(result, 152000);
        }

        [TestMethod]
        public void CalcularIvaTres()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            double Subtotal = 30000;

            //Act
            double result = test.CalcularIVA(Subtotal);

            //Assert
            Assert.AreEqual(result, 5700);
        }

        [TestMethod]
        public void CalcularIvaCuatro()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            double Subtotal = 250000;

            //Act
            double result = test.CalcularIVA(Subtotal);

            //Assert
            Assert.AreEqual(result, 47500);
        }

        [TestMethod]
        public void CalcularIvaCinco()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            double Subtotal = 10000000;

            //Act
            double result = test.CalcularIVA(Subtotal);

            //Assert
            Assert.AreEqual(result, 1900000);
        }

        [TestMethod]
        public void CalcularTotalUno()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            double Subtotal = 100000;
            double Descuento = 50;
            double Impuesto = 19;

            //Act
            double result = test.CalcularTotal(Subtotal, Descuento, Impuesto);

            //Assert
            Assert.AreEqual(result, 59500);
        }

        [TestMethod]
        public void CalcularTotalDos()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            double Subtotal = 550000;
            double Descuento = 25;
            double Impuesto = 19;

            //Act
            double result = test.CalcularTotal(Subtotal, Descuento, Impuesto);

            //Assert
            Assert.AreEqual(result, 490875);
        }

        [TestMethod]
        public void CalcularTotalTres()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            double Subtotal = 890000;
            double Descuento = 35;
            double Impuesto = 19;

            //Act
            double result = test.CalcularTotal(Subtotal, Descuento, Impuesto);

            //Assert
            Assert.AreEqual(result, 688415);
        }

        [TestMethod]
        public void CalcularTotalCuatro()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            double Subtotal = 1500000;
            double Descuento = 60;
            double Impuesto = 19;

            //Act
            double result = test.CalcularTotal(Subtotal, Descuento, Impuesto);

            //Assert
            Assert.AreEqual(result, 714000);
        }

        [TestMethod]
        public void CalcularTotalCinco()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            double Subtotal = 2000000;
            double Descuento = 10;
            double Impuesto = 19;

            //Act
            double result = test.CalcularTotal(Subtotal, Descuento, Impuesto);

            //Assert
            Assert.AreEqual(result, 2142000);
        }

        [TestMethod]
        public void ImprimirComentarioUno()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            double Subtotal = 600000;

            //Act
            string result = test.ImprimirComentario(Subtotal);

            //Assert
            Assert.AreEqual(result, "APLICA DESCUENTO DEL 5%");
        }

        [TestMethod]
        public void ImprimirComentarioDos()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            double Subtotal = 300000;

            //Act
            string result = test.ImprimirComentario(Subtotal);

            //Assert
            Assert.AreEqual(result, "NO APLICA DESCUENTO");
        }

        [TestMethod]
        public void ImprimirComentarioTres()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            double Subtotal = 1100000;

            //Act
            string result = test.ImprimirComentario(Subtotal);

            //Assert
            Assert.AreEqual(result, "APLICA DESCUENTO DEL 10%");
        }

        [TestMethod]
        public void ImprimirComentarioCuatro()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            double Subtotal = 1460000;

            //Act
            string result = test.ImprimirComentario(Subtotal);

            //Assert
            Assert.AreEqual(result, "APLICA DESCUENTO DEL 10%");
        }

        [TestMethod]
        public void ImprimirComentarioCinco()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            double Subtotal = 500000;

            //Act
            string result = test.ImprimirComentario(Subtotal);

            //Assert
            Assert.AreEqual(result, "APLICA DESCUENTO DEL 5%");
        }

        [TestMethod]
        public void ValidarCamposUno()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            string cliente = "holis", nit = "", direccion = "cra", telefono = "1421241", formaDePago = "Cheque", contacto = "124124124";

            //Act
            bool result = test.ValidarCampos(cliente, nit, direccion, telefono, formaDePago, contacto);

            //Assert
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void ValidarCamposDos()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            string cliente = "", nit = "", direccion = "", telefono = "", formaDePago = "", contacto = "";

            //Act
            bool result = test.ValidarCampos(cliente, nit, direccion, telefono, formaDePago, contacto);

            //Assert
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void ValidarCamposTres()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            string cliente = "cris", nit = "52266", direccion = "cra3", telefono = "1421241", formaDePago = "Cheque", contacto = "124124124";

            //Act
            bool result = test.ValidarCampos(cliente, nit, direccion, telefono, formaDePago, contacto);

            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void ValidarCamposCuatro()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            string cliente = "", nit = "", direccion = "", telefono = "1421241", formaDePago = "Cheque", contacto = "124124124";

            //Act
            bool result = test.ValidarCampos(cliente, nit, direccion, telefono, formaDePago, contacto);

            //Assert
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void ValidarCamposCinco()
        {
            //Arrange
            Logica.Services.TestClass test = new Logica.Services.TestClass();
            string cliente = "holis", nit = "556645", direccion = "cra", telefono = "1421241", formaDePago = "Cheque", contacto = "124124124";

            //Act
            bool result = test.ValidarCampos(cliente, nit, direccion, telefono, formaDePago, contacto);

            //Assert
            Assert.AreEqual(result, true);
        }
    }
}
