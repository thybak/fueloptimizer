using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelOptimizer.Clases.GEN
{
    public class CocheResultado
    {
        public double FitnessMax { get; set; }
        public double FitnessAvg { get; set; }
        public CocheCromosoma BestChromosome { get; set; }
    }
}
