using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic; 

namespace P30481923015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] Vetor = new double[10,4];
            string entrada = "";
            int sai = 0;
            double aux;
            string saida = "";
            double somaMes = 0.00;
            double somaTotal = 0.00;
            BoxSaida.Items.Clear();
            for (var x = 0; x < 10; x++) 
            {
                somaMes = 0.00;
                for (var y = 0; y < 4; y++)
                {
                    entrada = Interaction.InputBox("Digite um valor da venda para Mes " + (x + 1)+ " Semana " + (y + 1),"Entrada de Dados");
                    if(entrada == "")
                    {
                        sai = 1;
                        break;
                    }
                    if (!Double.TryParse(entrada, out aux))
                    {
                        MessageBox.Show("Digite número válido!");
                        y--;
                    }
                    else
                    {
                        Vetor[x, y] = aux;
                        somaMes += aux;
                        saida = "Total vendido Mes : "+(x+1)+" Semana: "+(y+1)+" R$ "+ aux.ToString("N2") + "\n";
                        BoxSaida.Items.Add(saida);
                    }
                }
                if (sai == 1)
                {
                    break;
                }
                somaTotal += somaMes;
                saida = " >> Total vendido Mes R$ " + somaMes.ToString("N2");
                BoxSaida.Items.Add(saida);
                BoxSaida.Items.Add("---------------------");
            }
            saida = " >>>>>>>Total Geral R$ " + somaTotal.ToString("N2");
            BoxSaida.Items.Add(saida);
        }

    }
}
