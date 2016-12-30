using AForge.Genetic;
using FuelOptimizer.Clases.COR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelOptimizer.Clases.GEN
{
    public class CocheFitness : IFitnessFunction
    {
        public double Evaluate(IChromosome cocheCromosoma)
        {
            var fitness = 1 - ((CocheCromosoma)cocheCromosoma).GetConsumoTotal();
            return fitness;
        }
    }
}
