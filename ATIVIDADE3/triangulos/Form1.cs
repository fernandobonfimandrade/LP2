using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void verificar_Click(object sender, EventArgs e)
        {
            imgTriangulo.BackgroundImage = triangulos.Properties.Resources.vazio;
            if (Double.TryParse(inputLadoA.Text, out Double ladoA) && 
                Double.TryParse(inputLadoB.Text, out Double ladoB) && 
                Double.TryParse(inputLadoC.Text, out Double ladoC))
            {
                if(ladoA > 0 && ladoB > 0 && ladoC > 0)
                {
                   if(ladoA.CompareTo(ladoB) == 0 && ladoB.CompareTo(ladoC) == 0)
                    {
                        //equilatero
                        imgTriangulo.BackgroundImage = triangulos.Properties.Resources.triEqui;
                    }
                    else
                    {
                        if (ladoA.CompareTo(ladoB) != 0 && ladoB.CompareTo(ladoC) != 0 && ladoA.CompareTo(ladoC) != 0)
                        {
                            //escaleno
                            imgTriangulo.BackgroundImage = triangulos.Properties.Resources.triEsc;
                        }
                        else
                        {
                            //isoceles
                            imgTriangulo.BackgroundImage = triangulos.Properties.Resources.triIso;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Tipo de entrada Inválida\nNão é existe triângulo com lado menor ou igual a 0!");
                }
            }
            else
            {
                MessageBox.Show("Tipo de entrada Inválida\nInforme somente números!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
