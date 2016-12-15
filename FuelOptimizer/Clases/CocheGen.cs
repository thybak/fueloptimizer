using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Genetic;

namespace FuelOptimizer.Clases
{
    public class CocheGen : IGPGene
    {
        public int Velocidad { get; set; }
        public int MarchaActual { get; set; }
        public int ConsumoAcumulado { get; set; }

        public GPGeneType GeneType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int ArgumentsCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int MaxArgumentsCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IGPGene Clone()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public IGPGene CreateNew(GPGeneType type)
        {
            throw new NotImplementedException();
        }
    }
}
