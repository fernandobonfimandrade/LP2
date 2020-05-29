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
    public partial class formExe2 : Form
    {
        public formExe2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.Compare(palavra1.Text, palavra2.Text, true) == 0)
                MessageBox.Show("São Iguais");
            else
                MessageBox.Show("São Diferentes");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int meio = palavra2.Text.Length / 2;

            palavra2.Text = palavra2.Text.Substring(0, meio) +
                palavra1.Text + palavra2.Text.Substring(meio, palavra2.Text.Length - meio);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int meio = palavra1.Text.Length / 2;

            palavra2.Text = palavra1.Text.Substring(0, meio) +
                "**" + palavra1.Text.Substring(meio, palavra1.Text.Length - meio);
        }
    }
}
