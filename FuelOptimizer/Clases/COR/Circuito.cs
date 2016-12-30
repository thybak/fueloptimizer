using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelOptimizer.Clases.COR
{
    public class Circuito
    {
        public static Circuito Current = new Circuito();
        public int LongitudCircuito { get; set; }
        public int LongitudTramoActualizacion { get; set; } // cada cuantos metros se van a actualizar los datos correspondientes a la velocidad y consumo de combustible
        public int NumeroTramos { get; set; }
        public List<Tramo> Tramos { get; set; }

        private Circuito(bool _default = true)
        {
            if (_default)
            {
                Tramos = new List<Tramo>();
                this.addTramo(1000, 50, 140);
                this.addTramo(1000, 20, 90);
                this.addTramo(1000, 50, 140);
                this.addTramo(1000, 20, 90);
                this.LongitudTramoActualizacion = 100;
            }
        }

        private void recalcularParametrosCircuito()
        {
            int longitud = 0;
            int numTramos = 0;
            foreach(var _Tramo in Tramos)
            {
                longitud += _Tramo.Longitud;
                numTramos++;
            }
            this.LongitudCircuito = longitud;
            this.NumeroTramos = numTramos;
        }

        public void addTramo(int longitud, int minVelocidad, int maxVelocidad)
        {
            Tramos.Add(new Tramo() { ID = Tramos.Count, Longitud = longitud, MaxVelocidad = maxVelocidad, MinVelocidad = minVelocidad });
            this.recalcularParametrosCircuito();
        }

        public Tramo getTramoPorLongitud (int longitud)
        {
            Tramo tramo = Tramos[0];
            int longitudAcumulada = Tramos[0].Longitud;
            if (longitud > longitudAcumulada)
            {
                for (int idx = 1; idx < Tramos.Count; idx++)
                {
                    tramo = Tramos[idx];
                    longitudAcumulada += Tramos[idx].Longitud;
                    if (longitud <= longitudAcumulada)
                    {
                        break;
                    }
                }
            }
            return tramo;
        }

        public void setTramos (List<Tramo> tramos, int longitudTramoActualizacion)
        {
            Tramos.RemoveRange(0, Tramos.Count);
            foreach(var tramo in tramos)
            {
                this.addTramo(tramo.Longitud, tramo.MinVelocidad, tramo.MaxVelocidad);
            }
            LongitudTramoActualizacion = longitudTramoActualizacion;
        }
    }
}
