using FuelOptimizer.Clases.COR;
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
    public partial class Main : Form
    {
        public CochePoblacion Poblacion { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private void ForzarVelocidadMinimaMarcha(TextBox origen, TextBox destino)
        {
            int velocidadMax = 0;
            try
            {
                velocidadMax = int.Parse(origen.Text);
                var txtMin = gbCoche.Controls[origen.Name.Replace("Max", "Min")] as TextBox;
                int velocidadMin = int.Parse(txtMin.Text);
                if (velocidadMax < velocidadMin)
                {
                    int velocidadAux = velocidadMax;
                    velocidadMax = velocidadMin;
                    velocidadMin = velocidadAux;
                    txtMin.Text = velocidadMin.ToString();
                    origen.Text = velocidadMax.ToString();
                }
            } catch (Exception) { }
            destino.Text = (velocidadMax + 1).ToString();
        }

        private void txtMarcha1Max_TextChanged(object sender, EventArgs e)
        {
            ForzarVelocidadMinimaMarcha(sender as TextBox, txtMarcha2Min);
        }

        private void txtMarcha2Max_TextChanged(object sender, EventArgs e)
        {
            ForzarVelocidadMinimaMarcha(sender as TextBox, txtMarcha3Min);
        }

        private void txtMarcha3Max_TextChanged(object sender, EventArgs e)
        {
            ForzarVelocidadMinimaMarcha(sender as TextBox, txtMarcha4Min);
        }

        private void txtMarcha4Max_TextChanged(object sender, EventArgs e)
        {
            ForzarVelocidadMinimaMarcha(sender as TextBox, txtMarcha5Min);
        }

        private void btnLanzamiento_Click(object sender, EventArgs e)
        {
            btnLanzamiento.Enabled = false;
            btnVerResultados.Enabled = false;
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
            Poblacion.LanzarGeneraciones();
            btnVerResultados.Enabled = true;
            btnLanzamiento.Enabled = true;
        }

        private void btnVerResultados_Click(object sender, EventArgs e)
        {
            var graficas = new Graficas();
            graficas.Resultados = Poblacion.Resultados;
            graficas.preparar();
            graficas.Show();
        }
    }
}
