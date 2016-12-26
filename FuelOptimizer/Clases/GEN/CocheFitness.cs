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
        public CocheCromosoma cocheCromosoma { get; set; }

        public double Evaluate(IChromosome cocheCromosoma)
        {
            this.cocheCromosoma = cocheCromosoma as CocheCromosoma;
            return 1 - this.cocheCromosoma.GetConsumoTotal();
        }
    }
}
