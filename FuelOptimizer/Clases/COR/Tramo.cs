using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelOptimizer.Clases.COR
{
    [Serializable]
    public class Tramo
    {
        public int ID { get; set; }
        public int Longitud { get; set; }
        public int MinVelocidad { get; set; }
        public int MaxVelocidad { get; set; }
    }
}
