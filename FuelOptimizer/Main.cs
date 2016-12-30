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
                var txtMin = this.Controls[origen.Name.Replace("Max", "Min")] as TextBox;
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
    }
}
