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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palindromo, palavra = box.Text;
            palavra.Replace(" ", "");
            char[] arr = palavra.ToCharArray();
            Array.Reverse(arr);
            palindromo = arr.ToString();
            palindromo = "";
            foreach (char c in arr)
                palindromo = palindromo + c.ToString();
            MessageBox.Show(palindromo);
            if (palindromo.CompareTo(palavra) == 0)
            {
                MessageBox.Show("É Palindromo");
            }
            else
            {
                MessageBox.Show("Não é Palindromo");
            }

        }
    }
}
