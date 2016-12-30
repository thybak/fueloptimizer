using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelOptimizer.Clases.COR
{
    public class Marcha
    {
        public int NumMarcha { get; set; }
        public int MinVelocidad { get; set; }
        public int MaxVelocidad { get; set; }

        public Marcha() { }

        // Constructor desde el formulario de configuración
        public Marcha (int NumMarcha, string MinVelocidad, string MaxVelocidad)
        {
            this.NumMarcha = NumMarcha;
            this.MinVelocidad = int.Parse(MinVelocidad);
            this.MaxVelocidad = int.Parse(MaxVelocidad);
        }
    }
}
