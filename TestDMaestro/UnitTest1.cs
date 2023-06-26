using PrimerParcial.Entidades.Models;
using PrimerParcial.Entidades.SQL.ElementosDB;

namespace TestDMaestro
{
    [TestClass]
    public class UnitTestCalculadoraDados
    {
        [TestMethod]
        public void TestCalculadoraDadosYModificadores()
        {
            string cajaCalculo = "d20+5-15+d100";

            double resultado = Calculadora.CalcularDadosYModificadores(cajaCalculo);

            Assert.AreNotEqual(0, resultado);
        }

        [TestMethod]
        public void TestCalculadoraDadosValoresRandom()
        {
            string cajaCalculo = "d20+d100";

            double resultado = Calculadora.CalcularDadosYModificadores(cajaCalculo);

            Assert.AreNotEqual(0, resultado);

        }

        [TestMethod]
        public void TestCalculadoraModificadoresNoNumericos()
        {
            string cajaCalculo = "a+z";

            double resultado = Calculadora.CalcularDadosYModificadores(cajaCalculo);

            Assert.AreEqual(0, resultado);

        }
    }

    [TestClass]
    public class UnitTestCalculadoraPuntosExperiencia
    {

        List<Dictionary<string, object>> tablaDos = Archivos.LeerInfoArchivo("tabla2");
        List<Dictionary<string, object>> tablaTres = Archivos.LeerInfoArchivo("tabla3");
        
        [TestMethod]
        public void TestCalculopPuntosExperiencia()
        {
            int nivelPromedio = 1;
            int cantPersonajes = 3;
            int cantEnemigos = 1;
            string dificultad = "Fácil";

            int result = Enemigo.CalcularXP(nivelPromedio, cantPersonajes, cantEnemigos, dificultad, tablaDos, tablaTres);

            Assert.AreEqual(75, result);
        }

        [TestMethod]
        public void TestCalculopPuntosExperienciaDificultadNoEncontrada()
        {
            int nivelPromedio = 1;
            int cantPersonajes = 3;
            int cantEnemigos = 1;
            string dificultad = "";

            Assert.ThrowsException<KeyNotFoundException>(() => Enemigo.CalcularXP(nivelPromedio, cantPersonajes, cantEnemigos, dificultad, tablaDos, tablaTres));
        }
    }

    [TestClass]
    public class UnitTestCalculadoraChallengeRating
    {

        List<Dictionary<string, object>> tablaUno = Archivos.LeerInfoArchivo("tabla1");

        [TestMethod]
        public void TestCalculopCR()
        {
            int puntosExperencia = 800;

            string result = Enemigo.CalcularCR(puntosExperencia, tablaUno);

            Assert.AreEqual("3", result);
        }

        [TestMethod]
        public void TestCalculopCRPuntosNegativos()
        {
            int puntosExperencia = -800;

            string result = Enemigo.CalcularCR(puntosExperencia, tablaUno);

            Assert.AreEqual("", result);
        }
    }


}