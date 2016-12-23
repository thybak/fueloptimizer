using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FuelOptimizer.Clases.COR;
using FuelOptimizer.Clases.GEN;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void pruebaGen()
        {
            var gen = new CocheGen();
            gen.Generate(Circuito.Current.Tramos[0]);
        }

        [TestMethod]
        public void pruebaCromosomaVacio()
        {
            var cromosoma = new CocheCromosoma();
        }


        [TestMethod]
        public void pruebaCromosomaAleatorio()
        {
            var cromosoma = new CocheCromosoma();
            cromosoma.Generate();
            Console.WriteLine(cromosoma);
        }
    }
}
