using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0, count = 0;
            while (x < box.Text.Length)
            {
                if (Char.IsWhiteSpace(box.Text[x]))
                {
                    count++;
                }
                x++;
            }
            MessageBox.Show("Quantidade de espaçoes em branco :" + count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 0, count = 0;
            while (x < box.Text.Length)
            {
                if (Convert.ToChar(box.Text[x].ToString().ToLower()).Equals('r'))
                {
                    count++;
                }
                x++;
            }
            MessageBox.Show("Quantidade de letras R :" + count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = 0, count = 0;
            char atual, prox;
            while (x < box.Text.Length -1 )
            {
                atual = Convert.ToChar(box.Text[x].ToString().ToLower());
                prox = Convert.ToChar(box.Text[x+1].ToString().ToLower());
                if (atual.Equals(prox))
                {
                    count++;
                }
                x++;
            }
            MessageBox.Show("Quantidade de Pares de letras :" + count);
        }
    }
}
