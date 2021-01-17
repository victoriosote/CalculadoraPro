using CAlculadora.Controllers;
using NUnit.Framework;

namespace Nunittestcalculadora
{
    public class TestsCalculadora
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSuma1()
        {
            //Arrange=preparacion
            int num1 = 5;
            int num2 = 7;
            int esperado = 12;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.sumapost(num1, num2);
            //Assert=verification
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestSuma2()
        {
            //Arrange=preparacion
            int num1 = 8;
            int num2 = 5;
            int esperado = 13;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.sumapost(num1, num2);
            //Assert=verification
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestSuma3()
        {
            //Arrange=preparacion
            int num1 = -5;
            int num2 = -3;
            int esperado =-8;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.sumapost(num1, num2);
            //Assert=verification
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestSumaGet1()
        {
            //Arrange=preparacion
            int num1 = 10;
            int num2 = 6;
            int esperado = 16;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.sumaget(num1, num2);
            //Assert=verification
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestSumaGet2()
        {
            //Arrange=preparacion
            int num1 =-8;
            int num2 = -6;
            int esperado = -14;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.sumaget(num1, num2);
            //Assert=verification
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestSumaGet3()
        {
            //Arrange=preparacion
            int num1 = -8;
            int num2 = 3;
            int esperado = -5;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.sumaget(num1, num2);
            //Assert=verification
            Assert.AreEqual(esperado, resultado);
        }
    }
}