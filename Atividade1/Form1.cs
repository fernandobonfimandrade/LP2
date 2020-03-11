using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_volume_Cilindro
{
    public partial class volume : Form
    {
        public volume()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double calc, r, h;
            if (double.TryParse(raio.Text, out r) && double.TryParse(altura.Text, out h))
            {
                calc = Math.PI * Math.Pow(r, 2) * h;
                resultado.Text = calc.ToString("N2");
            }
            else
            {
                MessageBox.Show("Operadores Inválidos!");
            }
        }


    }
}
