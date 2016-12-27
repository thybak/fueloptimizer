﻿using System;
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
        public double Fitness { get; set; }

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
            gen.Fitness = this.Fitness;
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
            do
            {
                int variacion = Utils.GenerarEnteroAleatorio(-VARIACION_VELOCIDAD, VARIACION_VELOCIDAD+1);
                Velocidad += variacion;
            } while (Velocidad <= tramo.MaxVelocidad && Velocidad >= tramo.MinVelocidad);
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
            return string.Format("Velocidad: {0}\nMarcha: {1}\nConsumo del subtramo: {2}\nÍndice del tramo asociado: {3} ", Velocidad, MarchaActual, ConsumoActual, TramoAsociado);
        }
    }
}