using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelOptimizer.Clases.COR
{
    public class Utils
    {
        public static int GenerarEnteroAleatorio(int min, int max)
        {
            return new Random(Guid.NewGuid().GetHashCode()).Next(min, max);
        }
        public static double GenerarRealAleatorio()
        {
            return new Random(Guid.NewGuid().GetHashCode()).NextDouble();
        }
    }
}
