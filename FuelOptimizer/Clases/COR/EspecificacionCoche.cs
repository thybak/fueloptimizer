using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelOptimizer.Clases.COR
{
    public class EspecificacionCoche
    {
        public static EspecificacionCoche Current = new EspecificacionCoche();
        public List<Marcha> Marchas { get; set; }

        private EspecificacionCoche(bool _default = true)
        {
            if (_default)
            {
                Marchas = new List<Marcha>();
                this.addMarcha(1, 0, 20);
                this.addMarcha(2, 21, 50);
                this.addMarcha(3, 51, 75);
                this.addMarcha(4, 76, 90);
                this.addMarcha(5, 91, 150);
            }
        }

        public void addMarcha(int numMarcha, int minVelocidad, int maxVelocidad)
        {
            Marchas.Add(new Marcha() { NumMarcha = numMarcha, MinVelocidad = minVelocidad, MaxVelocidad = maxVelocidad });
        }

        public int getMarcha(int velocidad)
        {
            int numMarcha = 0;
            foreach(var _Marcha in Marchas)
            {
                if (velocidad >= _Marcha.MinVelocidad && velocidad <= _Marcha.MaxVelocidad)
                {
                    numMarcha = _Marcha.NumMarcha;
                    break;
                }
            }
            return numMarcha;
        }

        public double getConsumo(int numMarcha, int velocidad)
        {
            double a, b, c = 0;
            switch (numMarcha)
            {
                case 1: // parametrizables para la marcha, pero por ahora son fijos los parámetros de consumo para el motor encontrado
                    a = 64.0 / 3500.0; b = -1287.0 / 700.0; c = 48.9;
                    break;
                case 2:
                    a = 64.0 / 3500.0; b = -1287.0 / 700.0; c = 48.9;
                    break;
                case 3:
                    a = 7.0 / 1200.0; b = -0.75; c = 86.0 / 3.0;
                    break;
                case 4:
                    a = 7.0 / 2750.0; b = -223.0 / 550.0; c = 219.0 / 11.0;
                    break;
                case 5:
                    a = 0.0025; b = -0.45; c = 24;
                    break;
                default:
                    a = 3.0 / 1540.0; b = -317.0 / 770.0; c = 1978.0 / 77.0;
                    break;
            }
            return (a * Math.Pow(velocidad, 2) + b * velocidad + c) / 1000.0;
        }

        public void setMarchas(List<Marcha> marchas)
        {
            Marchas.RemoveRange(0, Marchas.Count);
            Marchas.AddRange(marchas);
        }
    }
}
