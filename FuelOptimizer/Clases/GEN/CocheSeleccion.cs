using AForge.Genetic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelOptimizer.Clases.GEN
{
    public class CocheSeleccion : ISelectionMethod
    {
        public void ApplySelection(List<IChromosome> cromosomas, int size)
        {
            // Por ahora aplicamos elitismo
            cromosomas.Sort();
            cromosomas.RemoveRange(size, cromosomas.Count - size);
            foreach(var cromosoma in cromosomas)
            {
                Console.WriteLine(cromosoma.Fitness + "<->" + (cromosoma as CocheCromosoma).GetConsumoTotal());
            }
        }
    }
}
