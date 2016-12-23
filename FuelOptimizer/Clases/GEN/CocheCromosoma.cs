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
        public const double PORCENTAJE_MUTACION = .10;

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
            // Mezcla de genes de cromosomas para dar lugar a otros nuevos
            throw new NotImplementedException();
        }

        public void Evaluate(IFitnessFunction function)
        {
            _Fitness = function.Evaluate(this);
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

        private HashSet<int> GetGenesAMutar()
        {
            var numGenesAMutar = (int)(Genes.Length * PORCENTAJE_MUTACION);
            var indicesGen = new HashSet<int>();
            for (int numGen = 0; numGen < numGenesAMutar; numGen++)
            {
                var indiceAleatorio = new Random(Guid.NewGuid().GetHashCode()).Next(0, 40);
                while (indicesGen.Contains(indiceAleatorio))
                {
                    indiceAleatorio = new Random(Guid.NewGuid().GetHashCode()).Next(0, 40);
                }
                indicesGen.Add(indiceAleatorio);
            }
            return indicesGen;
        }

        public void Mutate()
        {
            // Definir cómo van a mutar los genes del cromosoma
            var indicesMutables = GetGenesAMutar();
            foreach(var _idx in indicesMutables)
            {
                Genes[_idx].Mutate();
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
    }

    public class CocheFitness : IFitnessFunction
    {
        public CocheCromosoma cocheCromosoma { get; set; }

        private double GetMediaTramo(Tramo tramo)
        {
            var MinValorConsumo = cocheCromosoma.Genes.Where(x => x.TramoAsociado == tramo.ID).Min(x=>x.ConsumoActual);
            double proporcionAcumulada = 0.0;
            foreach(var Gen in cocheCromosoma.Genes.Where(x=>x.TramoAsociado == tramo.ID))
            {
                var proporcion = MinValorConsumo / Gen.ConsumoActual;
                proporcionAcumulada += proporcion;
            }
            return proporcionAcumulada / cocheCromosoma.Genes.Where(x => x.TramoAsociado == tramo.ID).Count();
        }

        public double Evaluate(IChromosome cocheCromosoma)
        {
            this.cocheCromosoma = cocheCromosoma as CocheCromosoma;
            double porcentajeAcumulado = 0.0;
            foreach(var Tramo in Circuito.Current.Tramos)
            {
                porcentajeAcumulado += GetMediaTramo(Tramo);
            }
            return porcentajeAcumulado / Circuito.Current.Tramos.Count;
        }
    }
}
