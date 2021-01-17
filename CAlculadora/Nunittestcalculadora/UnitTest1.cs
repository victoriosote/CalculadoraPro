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
        [Test]
        public void TestResta1()
        {
            //Arrange=preparacion
            int num1 = 8;
            int num2 = 7;
            int esperado = 1;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.restapost(num1, num2);
            //Assert=verification
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestResta2()
        {
            //Arrange=preparacion
            int num1 = -8;
            int num2 = 5;
            int esperado = -13;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.restapost(num1, num2);
            //Assert=verification
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestResta3()
        {
            //Arrange=preparacion
            int num1 = -6;
            int num2 = -3;
            int esperado = -3;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.restapost(num1, num2);
            //Assert=verification
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestRestaGet1()
        {
            //Arrange=preparacion
            int num1 = 1;
            int num2 = 6;
            int esperado = -5;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.restaget(num1, num2);
            //Assert=verification
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestRestaGet2()
        {
            //Arrange=preparacion
            int num1 = -9;
            int num2 = -8;
            int esperado = -1;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.restaget(num1, num2);
            //Assert=verification
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestRestaGet3()
        {
            //Arrange=preparacion
            int num1 = -8;
            int num2 = -3;
            int esperado = -5;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.restaget(num1, num2);
            //Assert=verification
            Assert.AreEqual(esperado, resultado);
        }
        public void TestMulti1()
        {
            //Arrange=preparacion
            int num1 = 8;
            int num2 = 7;
            int esperado = 56;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.multipost(num1, num2);
            //Assert=verification
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestMulti2()
        {
            //Arrange=preparacion
            int num1 = -8;
            int num2 = 5;
            int esperado = -40;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.multipost(num1, num2);
            //Assert=verification
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestMulti3()
        {
            //Arrange=preparacion
            int num1 = -6;
            int num2 = -3;
            int esperado = 18;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.multipost(num1, num2);
            //Assert=verification
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestMultiGet1()
        {
            //Arrange=preparacion
            int num1 = 1;
            int num2 = 6;
            int esperado = 6;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.multiget(num1, num2);
            //Assert=verification
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestMultiGet2()
        {
            //Arrange=preparacion
            int num1 = -9;
            int num2 = -8;
            int esperado = 72;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.multiget(num1, num2);
            //Assert=verification
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestMultiGet3()
        {
            //Arrange=preparacion
            int num1 = -8;
            int num2 = -3;
            int esperado = 24;
            CalculadoraController calc = new CalculadoraController();

            //Act=ejecucion
            int resultado = calc.multiget(num1, num2);
            //Assert=verification
            Assert.AreEqual(esperado, resultado);
        }
    }
}