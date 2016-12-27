using AForge.Genetic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelOptimizer.Clases.GEN
{
    public class CochePoblacion
    {
        public Population Poblacion { get; set; }
        public int NumGeneraciones { get; set; }

        public CochePoblacion(bool _default = true)
        {
            if (_default)
            {
                var cromosomaAncestro = new CocheCromosoma();
                var fitness = new CocheFitness();
                var seleccion = new CocheSeleccion();
                var size = 100;
                NumGeneraciones = 2000;
                cromosomaAncestro.Generate();
                Poblacion = new Population(size, cromosomaAncestro, fitness, seleccion);
                Poblacion.RandomSelectionPortion = 0.1;
            }
        }

        public void LanzarGeneraciones()
        {
            for (int generacion = 0; generacion < NumGeneraciones; generacion++)
            {
                Poblacion.RunEpoch();
                Console.WriteLine(string.Format("Generación {0}\nMáximo {1}\nMedia {2}\nMejor cromosoma {3}", generacion + 1, Poblacion.FitnessMax, Poblacion.FitnessAvg, ((CocheCromosoma)Poblacion.BestChromosome).GetConsumoTotal()));
            }
        }
    }
}
