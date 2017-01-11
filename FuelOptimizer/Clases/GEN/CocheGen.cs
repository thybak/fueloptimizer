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
        public const int VARIACION_VELOCIDAD = 5;

        public int Velocidad { get; set; }
        public int MarchaActual { get; set; }
        public double ConsumoActual { get; set; }
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
                return 4;
            }
        }

        public int MaxArgumentsCount
        {
            get
            {
                return 4;
            }
        }

        public IGPGene Clone()
        {
            var gen = new CocheGen();
            gen.Velocidad = this.Velocidad;
            gen.MarchaActual = this.MarchaActual;
            gen.ConsumoActual = this.ConsumoActual;
            gen.TramoAsociado = this.TramoAsociado;
            return gen;
        }

        public void Generate()
        {
            this.Generate(Circuito.Current.Tramos[0]);
        }

        public void Generate(Tramo tramo)
        {
            Velocidad = Utils.GenerarEnteroAleatorio(tramo.MinVelocidad, tramo.MaxVelocidad+1);
            MarchaActual = EspecificacionCoche.Current.getMarcha(Velocidad);
            ConsumoActual = EspecificacionCoche.Current.getConsumo(MarchaActual, Velocidad);
            TramoAsociado = tramo.ID;
        }

        public void Mutate()
        {
            var tramo = Circuito.Current.Tramos.FirstOrDefault(x => x.ID == TramoAsociado);
            int variacion = 0;
            do
            {
                variacion = Utils.GenerarEnteroAleatorio(-VARIACION_VELOCIDAD, VARIACION_VELOCIDAD+1);
            } while (Velocidad + variacion > tramo.MaxVelocidad || Velocidad + variacion < tramo.MinVelocidad);
            Velocidad += variacion;
            MarchaActual = EspecificacionCoche.Current.getMarcha(Velocidad);
            ConsumoActual = EspecificacionCoche.Current.getConsumo(MarchaActual, Velocidad);
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

        public override string ToString()
        {
            return string.Format("Velocidad: {0}{1}Marcha: {2}{3}Consumo del subtramo: {4}{5}Índice del tramo asociado: {6} ", Velocidad, Environment.NewLine, MarchaActual, Environment.NewLine, ConsumoActual, Environment.NewLine, TramoAsociado);
        }
    }
}
