using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Genetic;
using FuelOptimizer.Clases.COR;

namespace FuelOptimizer.Clases.GEN
{
    public class CocheCromosoma : IChromosome
    {
        public CocheGen[] Genes { get; set; }

        public CocheCromosoma(bool _default = true)
        {
            if (_default)
            {
                Genes = new CocheGen[Circuito.Current.LongitudCircuito / Circuito.Current.LongitudTramoActualizacion];
            }
        }
        
        public double Fitness
        {
            get
            {
                // Propiedad que retorna el fitness del cromosoma en base a la evaluación del método.
                throw new NotImplementedException();
            }
        }

        public IChromosome Clone()
        {
            return this.Clone();
        }

        public int CompareTo(object obj)
        {
            // ¿¿??
            throw new NotImplementedException();
        }

        public IChromosome CreateNew()
        {
            // Retorno de la generación inicial del cromosoma
            throw new NotImplementedException();
        }

        public void Crossover(IChromosome pair)
        {
            // Mezcla de genes para dar lugar a otros nuevos
            throw new NotImplementedException();
        }

        public void Evaluate(IFitnessFunction function)
        {
            // Evaluación usando la función de fitness del cromosoma
            throw new NotImplementedException();
        }

        public void Generate()
        {
            // Generación inicial de genes del cromosoma
            throw new NotImplementedException();
        }

        public void Mutate()
        {
            // Definir cómo van a mutar los genes del cromosoma
            throw new NotImplementedException();
        }
    }
}
