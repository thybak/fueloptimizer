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
                this.addTramo(1000, 100, 180);
                this.addTramo(1000, 50, 90);
                this.addTramo(1000, 100, 180);
                this.addTramo(1000, 50, 90);
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
            Tramos.Add(new Tramo() { Longitud = longitud, MaxVelocidad = maxVelocidad, MinVelocidad = minVelocidad });
            this.recalcularParametrosCircuito();
        }
    }
}
