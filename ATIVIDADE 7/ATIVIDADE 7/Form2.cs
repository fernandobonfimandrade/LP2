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

namespace ATIVIDADE_7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[9];
            int[] numCaracteres = new int[9];
            string aux = "";

            listBox1.Items.Clear();

            for (var i = 0; i < 9; i++)
            {
                aux = Interaction.InputBox("Digite o nome " + (i + 1), "Entrada de Dados");
                if (aux == "")
                {
                    break;
                }
                nomes[i] = aux;
                numCaracteres[i] = aux.Length - aux.Count(Char.IsWhiteSpace);
            }

            for (var i = 0; i < 9; i++)
            {
                listBox1.Items.Add("Nome: " + nomes[i] + " possui " + numCaracteres[i] + " Caracteres\n");
            }
        }
    }
}
