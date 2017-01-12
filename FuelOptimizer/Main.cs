using FuelOptimizer.Clases.COR;
using FuelOptimizer.Clases.GEN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelOptimizer
{
    public partial class Main : Form
    {
        public CochePoblacion Poblacion { get; set; }

        public Main()
        {
            InitializeComponent();
            this.tramoBindingSource.DataSource = Circuito.Current.Tramos;
        }

        private void btnLanzamiento_Click(object sender, EventArgs e)
        {
            btnLanzamiento.Enabled = false;
            btnVerResultados.Enabled = false;

            bwCalculo.RunWorkerAsync();
        }

        private void btnVerResultados_Click(object sender, EventArgs e)
        {
            var graficas = new Graficas();
            graficas.Resultados = Poblacion.Resultados;
            graficas.preparar();
            graficas.Show();
        }

        private void bwCalculo_DoWork(object sender, DoWorkEventArgs e)
        {
            btnLanzamiento.Enabled = false;
            btnVerResultados.Enabled = false;
            GC.Collect();
            var TramoLista = ((BindingSource)dgvCircuito.DataSource).List.Cast<Tramo>().ToList();
            int idx = 0;
            foreach (var Tramo in TramoLista)
            {
                Tramo.ID = idx++;
            }
            Circuito.Current.setTramos(TramoLista, int.Parse(txtLongitudTramoActualizacion.Text));
            var Marchas = new List<Marcha>();
            Marchas.Add(new Marcha(1, txtMarcha1Min.Text, txtMarcha1Max.Text));
            Marchas.Add(new Marcha(2, txtMarcha2Min.Text, txtMarcha2Max.Text));
            Marchas.Add(new Marcha(3, txtMarcha3Min.Text, txtMarcha3Max.Text));
            Marchas.Add(new Marcha(4, txtMarcha4Min.Text, txtMarcha4Max.Text));
            Marchas.Add(new Marcha(5, txtMarcha5Min.Text, txtMarcha5Max.Text));
            EspecificacionCoche.Current.setMarchas(Marchas);
            Poblacion = new CochePoblacion(int.Parse(txtNumGeneraciones.Text), int.Parse(txtSize.Text));
            Poblacion.LanzarGeneraciones(tslblGeneracion);   
        }

        private void bwCalculo_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                btnLanzamiento.Enabled = true;
                btnVerResultados.Enabled = true;
            } else
            {
                tslblGeneracion.Text = e.Error.Message;
            }
        }
    }
}
