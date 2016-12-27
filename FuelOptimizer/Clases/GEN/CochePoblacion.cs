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
                NumGeneraciones = 100;
                cromosomaAncestro.Generate();
                Poblacion = new Population(size, cromosomaAncestro, fitness, seleccion);
                Poblacion.RandomSelectionPortion = .2;
            }
        }

        public void LanzarGeneraciones()
        {
            for (int generacion = 0; generacion < NumGeneraciones; generacion++)
            {
                Console.WriteLine(Poblacion[generacion]);
            }
        }
    }
}
