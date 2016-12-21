using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Genetic;
using FuelOptimizer.Clases.COR;

namespace FuelOptimizer.Clases.GEN
{
    public class CocheGen : IGPGene
    {
        public int Velocidad { get; set; }
        public int MarchaActual { get; set; }
        public double ConsumoAcumulado { get; set; }
        public int TramoAsociado { get; set; }

        public CocheGen()
        {

        }

        public GPGeneType GeneType
        {
            get
            {
                return GPGeneType.Argument;
            }
        }

        public int ArgumentsCount
        {
            get
            {
                return 3;
            }
        }

        public int MaxArgumentsCount
        {
            get
            {
                return 3;
            }
        }

        public IGPGene Clone()
        {
            return this.Clone();
        }

        public void Generate()
        {
            throw new NotImplementedException();
        }

        public void Generate(GPGeneType type)
        {
            throw new NotImplementedException();
        }

        public IGPGene CreateNew()
        {
            return this;
        }

        public IGPGene CreateNew(GPGeneType type)
        {
            return this;
        }

        public IGPGene CreateNew(Tramo tramo, int tramoIndex)
        {
            var gen = this.CreateNew() as CocheGen;
            gen.Velocidad = new Random().Next(tramo.MinVelocidad, tramo.MaxVelocidad);
            gen.MarchaActual = EspecificacionCoche.Current.getMarcha(gen.Velocidad);
            gen.ConsumoAcumulado = EspecificacionCoche.Current.getConsumo(gen.MarchaActual, gen.Velocidad);
            gen.TramoAsociado = tramoIndex;
            return gen;
        }
    }
}
