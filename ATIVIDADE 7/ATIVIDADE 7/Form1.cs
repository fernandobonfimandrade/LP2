using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;

namespace ATIVIDADE_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string auxiliar = "";
            string valor = "";

            for (var x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Digite um valor na posição: " + (x + 1),
                    "Entrada de Dados");

                if (valor == "")
                {
                    break;
                }

                if (int.TryParse(valor, out Vetor[x]))
                {
                    //auxiliar = auxiliar + "\n" + Vetor[x].ToString();
                    auxiliar = Vetor[x].ToString() + "\n" + auxiliar;
                }
                else
                {
                    MessageBox.Show("Número inválido!");
                    x--;
                }
            }
            MessageBox.Show(auxiliar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string auxiliar = "";
            string valor = "";

            for (var x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Entre com dado da posição: " + (x + 1), "Entrada de Dados");
                if (valor == "")
                    break;
                if (!int.TryParse(valor, out Vetor[x]))
                {
                    MessageBox.Show("Digite número válido!");
                    x--;
                }
            }
            Array.Reverse(Vetor);
            for (var x = 0; x < 20; x++)
            {
                auxiliar = auxiliar + "\n" + Vetor[x];
            }
            MessageBox.Show(auxiliar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double[] VetorPreco = new double[10];
            int[] VetorQtd = new int[10];

            string valor = "";
            double total = 0;

            for (var x = 0; x < 10; x++)
            {
                valor = "";
                while (valor == "")
                {
                    valor = Interaction.InputBox("Digite a quantidade de Itens vendidos da mercadoria " + (x + 1) + " :");
                    if (!int.TryParse(valor, out VetorQtd[x]) && VetorQtd[x] > 0)
                    {
                        MessageBox.Show("Digite número válido maior que zero!");
                        valor = "";
                    }
                }
                valor = "";
                while (valor == "")
                {
                    valor = Interaction.InputBox("Digite o valor unitátio do Iten " + (x + 1) + " :");
                    if (!double.TryParse(valor, out VetorPreco[x]) && VetorPreco[x] > 0)
                    {
                        MessageBox.Show("Digite número válido maior que zero!");
                        valor = "";
                    }
                }
                total += VetorQtd[x] * VetorPreco[x];
            }
            MessageBox.Show("Faturamento R$ " + total.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Int32 i, total = 0;
            string[] alunos = {"Fernando", "Mirela", "Gustavo", "Giovana", "André",
                "Roberto", "Antonio", "Vilma", "Pedro"};
            Int32 NAlunos = alunos.Length;

            for (i = 0; i < NAlunos - 1; i++)
            {
                total += alunos[i].Length;
            }
            MessageBox.Show("Numero total de caracteres: " + total);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ArrayList alunos = new ArrayList(new string[] {
                "Fernando", "Mirela", "Gustavo", "Giovana", "André",
                "Roberto", "Antonio", "Vilma", "Pedro"});
            alunos.Remove("Pedro");

            string listaAlunos = "";
            foreach (string nome in alunos)
            {
                listaAlunos = listaAlunos + nome + "\n";
            }
            MessageBox.Show(listaAlunos);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double[,] notasArr = new double[21, 4];
            double media;
            string nota = "";
            string retorno = "";

            for (var i = 1; i < 21; i++)
            {
                media = 0;
                for (var j = 1; j < 4; j++)
                {
                    nota = Interaction.InputBox("Aluno " + i + " , nota " + j + " : ","Entrada de Notas");
                    if (nota == "")
                    {
                        break;
                    }
                    if (!double.TryParse(nota, out notasArr[i, j]))
                    {
                        MessageBox.Show("Nota inválida!");
                        j--;
                    }
                    else
                    {
                        media += notasArr[i, j];
                    }
                }
                media /= 3;
                retorno += "Aluno " + i.ToString() + ", média: " + media.ToString("N2") + "\n";
            }
            MessageBox.Show(retorno);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["Form2"];
            if (frm != null)
            {
                frm.Close();
            }
            Form2 atv7 = new Form2();
            atv7.Show();
        }
    }
}
