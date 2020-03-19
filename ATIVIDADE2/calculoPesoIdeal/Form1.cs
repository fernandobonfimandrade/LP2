using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculoPesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {

            double.TryParse(inputAltura.Text, out double altura);
            double.TryParse(inputPeso.Text, out double peso);
            double pesoIdeal;

            if (peso > 0 && altura > 0)
            {
                if(radioMasc.Checked)
                {
                    pesoIdeal = Math.Round( ((72.7  * altura) - 58) ,2);
                }
                else
                {
                    pesoIdeal = Math.Round( ((62.1  * altura) - 44.7) ,2);
                }

                inputPesoIdeal.Text = pesoIdeal.ToString("N2");

                if (pesoIdeal.CompareTo(peso) < 0)
                {
                    MessageBox.Show("Regime Obrigatório Já");
                }
                if(pesoIdeal.CompareTo(peso) == 0)
                {
                    MessageBox.Show("Você está com o peso ideal");
                }                
                if(pesoIdeal.CompareTo(peso) > 0)
                {
                    MessageBox.Show("Coma bastante massas e doces");
                }
            }
            else
            {
                MessageBox.Show("Valor de peso e altura não podem ser menor ou igual a zero");
            }

        }
    }
}
