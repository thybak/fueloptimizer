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
        public List<CocheResultado> Resultados { get; set; }
        public int NumGeneraciones { get; set; }
        public int NumCromosomas { get; set; }

        public CochePoblacion(bool _default = true)
        {
            Resultados = new List<CocheResultado>();

            if (_default)
            {    
                NumCromosomas = 100;
                NumGeneraciones = 2000;
            }
        }

        public CochePoblacion(int NumGeneraciones, int NumCromosomas)
            : this(false)
        {
            this.NumCromosomas = NumCromosomas;
            this.NumGeneraciones = NumGeneraciones;
        }

        public void IniciarPoblacion()
        {
            var cromosomaAncestro = new CocheCromosoma();
            cromosomaAncestro.Generate();
            var fitness = new CocheFitness();
            var seleccion = new CocheSeleccion();
            Poblacion = new Population(NumCromosomas, cromosomaAncestro, fitness, seleccion);
            Poblacion.RandomSelectionPortion = 0.1;
        }

        public void LanzarGeneraciones()
        {
            if (Poblacion == null)
            {
                IniciarPoblacion();
            }
            for (int generacion = 0; generacion < NumGeneraciones; generacion++)
            {
                Poblacion.RunEpoch();
                Resultados.Add(new CocheResultado() { BestChromosome = Poblacion.BestChromosome.Clone() as CocheCromosoma, FitnessAvg = Poblacion.FitnessAvg, FitnessMax = Poblacion.FitnessMax });
                Console.WriteLine(string.Format("Generación {0}\nMáximo {1}\nMedia {2}\nMejor cromosoma {3}", generacion + 1, Poblacion.FitnessMax, Poblacion.FitnessAvg, ((CocheCromosoma)Poblacion.BestChromosome).GetConsumoTotal()));
            }
        }
    }
}
