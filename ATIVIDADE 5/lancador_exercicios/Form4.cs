using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lancador_exercicios
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0;
            for (var x =0;x <= richTextBox1.Text.Length -1; x++)
            {
                if (Char.IsNumber(richTextBox1.Text[x]))
                {
                    contador++; 
                }
            }
            MessageBox.Show("Caracteres numericos:" + contador);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 0;
            while(x < richTextBox1.Text.Length)
            {
                if (Char.IsWhiteSpace(richTextBox1.Text[x]))
                {
                    MessageBox.Show("Primeiro Caracter Banco : " + (x + 1));
                    break;
                }
                x++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int contador = 0;
            foreach(char c in richTextBox1.Text)
            {
                if (Char.IsLetter(c))
                {
                    contador++;
                }
            }
            MessageBox.Show("Quantidade de caracteres Alfabéticos :" + contador);
        }
    }
}
