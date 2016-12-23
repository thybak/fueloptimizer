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

        [TestMethod]
        public void pruebaFitness()
        {
            var cromosoma = new CocheCromosoma();
            cromosoma.Generate();
            var fitness = new CocheFitness();
            Console.WriteLine(fitness.Evaluate(cromosoma));
        }

        [TestMethod]
        public void pruebaMutacion()
        {
            var cromosoma = new CocheCromosoma();
            cromosoma.Generate();
            var fitness = new CocheFitness();
            Console.WriteLine(fitness.Evaluate(cromosoma));
            for (int i = 0; i < 500; i++)
            {
                cromosoma.Mutate();
                Console.WriteLine(fitness.Evaluate(cromosoma));
            }
        }
    }
}
