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
                this.addMarcha(2, 20, 50);
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
                    a = 64 / 3500; b = -1287 / 700; c = 48.9;
                    break;
                case 2:
                    a = 64 / 3500; b = -1287 / 700; c = 48.9;
                    break;
                case 3:
                    a = 7 / 1200; b = -0.75; c = 86 / 3;
                    break;
                case 4:
                    a = 7 / 2750; b = -223 / 550; c = 219 / 11;
                    break;
                case 5:
                    a = 0.0025; b = -0.45; c = 24;
                    break;
                default:
                    a = 3 / 1540; b = -317 / 770; c = 1978 / 77;
                    break;
            }
            return (a * Math.Pow(velocidad, 2) + b * velocidad + c) / 1000;
        }
    }
}
