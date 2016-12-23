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
            return this;
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
            int longitudActual = 0;
            for (int idx = 0; idx < Genes.Length; idx++)
            {
                Genes[idx] = new CocheGen();
                var TramoActual = Circuito.Current.getTramoPorLongitud(longitudActual);
                Genes[idx].Generate(TramoActual);
                longitudActual += Circuito.Current.LongitudTramoActualizacion;
            }
            // Retorno de la generación inicial del cromosoma
        }

        public void Mutate()
        {
            // Definir cómo van a mutar los genes del cromosoma
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            int idx = 0;
            foreach(var Gene in Genes)
            {
                sb.Append(string.Format("Gen {0}\n", idx));
                sb.Append(Gene);
                idx++;
            }
            return sb.ToString();
        }
    }

    public class FitnessCoche : IFitnessFunction
    {
        public double Evaluate(IChromosome chromosome)
        {
            // Aquí se retornará un valor mayor que 0 en función de nuestra valoración del cromosoma
            throw new NotImplementedException();
        }
    }
}
