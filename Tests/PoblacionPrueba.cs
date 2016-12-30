using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FuelOptimizer.Clases.COR;
using FuelOptimizer.Clases.GEN;
using System.Collections.Generic;
using AForge.Genetic;

namespace Tests
{
    [TestClass]
    public class PoblacionPrueba
    {
        public List<IChromosome> cromosomas = new List<IChromosome>();
        public ISelectionMethod seleccion { get; set; }
        public IFitnessFunction fitness = new CocheFitness();

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
            cromosoma.Evaluate(fitness);
            Console.WriteLine(cromosoma.Fitness);
        }

        [TestMethod]
        public void pruebaMutacion()
        {
            var cromosoma = new CocheCromosoma();
            cromosoma.Generate();
            Console.WriteLine(fitness.Evaluate(cromosoma));
            for (int i = 0; i < 500; i++)
            {
                cromosoma.Mutate();
                cromosoma.Evaluate(fitness);
                Console.WriteLine(cromosoma.Fitness);
            }
        }

        [TestMethod]
        public void pruebaCrossover()
        {
            var cromosoma = new CocheCromosoma();
            cromosoma.Generate();
            cromosoma.Evaluate(fitness);
            Console.WriteLine(cromosoma.Fitness);
            var cromosoma2 = new CocheCromosoma();
            cromosoma2.Generate();
            cromosoma.Crossover(cromosoma2);
            cromosoma.Evaluate(fitness);
            Console.WriteLine(cromosoma.Fitness);
        }

        [TestMethod]
        public void pruebaSeleccion()
        {
            for (int i = 0; i < 100; i++)
            {
                var cromosoma = new CocheCromosoma();
                cromosoma.Generate();
                cromosoma.Evaluate(fitness);
                cromosomas.Add(cromosoma);
            }
            seleccion = new CocheSeleccion();
            Console.WriteLine(this.cromosomas.Count);
            seleccion.ApplySelection(this.cromosomas, 20);
            Console.WriteLine(this.cromosomas.Count);
        }

        [TestMethod]
        public void pruebaPoblacion()
        {
            var poblacion = new CochePoblacion();
            //poblacion.LanzarGeneraciones();
        }
    }
}
