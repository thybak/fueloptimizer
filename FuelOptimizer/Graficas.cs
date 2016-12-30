using FuelOptimizer.Clases.GEN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelOptimizer
{
    public partial class Graficas : Form
    {
        public List<CocheResultado> Resultados { get; set; }

        public Graficas()
        {
            InitializeComponent();
        }

        public void preparar()
        {
            var Generacion = 0;
            foreach(var _Resultado in Resultados)
            {
                chResultados.Series[0].Points.AddXY(Generacion, _Resultado.FitnessMax); // fitness máximo
                chResultados.Series[1].Points.AddXY(Generacion, _Resultado.FitnessAvg); // fitness media
                chResultados.Series[2].Points.AddXY(Generacion, _Resultado.BestChromosome.GetConsumoTotal()); // consumo
                Generacion++;
            }
            lblConsumo.Text = lblConsumo.Text.Replace("{0}", Resultados.Last().BestChromosome.GetConsumoTotal().ToString());
            lblMedia.Text = lblMedia.Text.Replace("{0}", Resultados.Last().FitnessAvg.ToString());
            lblMax.Text = lblMax.Text.Replace("{0}", Resultados.Last().FitnessMax.ToString());
            txtCromosoma.Text = Resultados.Last().BestChromosome.ToString();
        }
    }
}
