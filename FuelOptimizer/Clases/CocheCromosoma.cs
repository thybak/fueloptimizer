using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Genetic;

namespace FuelOptimizer.Clases
{
    public class CocheCromosoma : IChromosome
    {
        public CocheGen[] Genes { get; set; }
        public int LongitudCircuito { get; set; }
        public int LongitudTramoActualizacion { get; set; }
        public int NumeroTramos { get; set; }
        public Tramo[] Tramos { get; set; }


        public double Fitness
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IChromosome Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public IChromosome CreateNew()
        {
            throw new NotImplementedException();
        }

        public void Crossover(IChromosome pair)
        {
            throw new NotImplementedException();
        }

        public void Evaluate(IFitnessFunction function)
        {
            throw new NotImplementedException();
        }

        public void Generate()
        {
            throw new NotImplementedException();
        }

        public void Mutate()
        {
            throw new NotImplementedException();
        }
    }
}
