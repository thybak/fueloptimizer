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
        public const double PORCENTAJE_MUTACION = .010;

        public CocheGen[] Genes { get; set; }

        public CocheCromosoma(bool _default = true)
        {
            if (_default)
            {
                Genes = new CocheGen[Circuito.Current.LongitudCircuito / Circuito.Current.LongitudTramoActualizacion];
            }
        }

        private double _Fitness;
        public double Fitness
        {
            get
            {
                return _Fitness;
            }
        }

        public IChromosome Clone()
        {
            return this.Clone();
        }

        public int CompareTo(object cromosoma)
        {
            // Asumimos que solo se puede comparar con otro cromosoma y por fitness, útil para el método Sort()
            var FitnessCromosoma = (cromosoma as CocheCromosoma).Fitness;
            if (FitnessCromosoma > Fitness)
            {
                return 1;
            } else if (Fitness == FitnessCromosoma)
            {
                return 0;
            } else
            {
                return -1;
            }
        }

        public IChromosome CreateNew()
        {
            // Generamos un nuevo cromosoma
            var cromosoma = new CocheCromosoma();
            cromosoma.Generate();
            return cromosoma;
        }

        public void Crossover(IChromosome cromosomaPar)
        {
            // Mezcla de genes de cromosomas para dar lugar a otros nuevos
            int posicionInicial = Utils.GenerarEnteroAleatorio(0, Genes.Length);
            int posicionFinal = Utils.GenerarEnteroAleatorio(posicionInicial, Genes.Length);

            var cocheCromosoma = cromosomaPar as CocheCromosoma;

            for(int idx = 0; idx < Genes.Length; idx++)
            {
                if (idx < posicionInicial || idx > posicionFinal)
                {
                    Genes[idx] = cocheCromosoma.Genes[idx];
                }
            }
        }

        public void Evaluate(IFitnessFunction funcion)
        {
            _Fitness = funcion.Evaluate(this);
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
        }

        public void Mutate()
        {
            // Definir cómo van a mutar los genes del cromosoma
            foreach(var _Gen in Genes)
            {
                var porcentajeAleatorio = Utils.GenerarRealAleatorio();
                if (porcentajeAleatorio < PORCENTAJE_MUTACION)
                {
                    Console.WriteLine(">" + porcentajeAleatorio);
                    Genes[Utils.GenerarEnteroAleatorio(0, Genes.Length)].Mutate();
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            int idx = 0;
            foreach(var Gene in Genes)
            {
                sb.Append(string.Format("\nGen {0}\n", idx));
                sb.Append(Gene);
                idx++;
            }
            return sb.ToString();
        }

        public double GetConsumoTotal()
        {
            return Genes.Sum(x => x.ConsumoActual);
        }
    }
}
