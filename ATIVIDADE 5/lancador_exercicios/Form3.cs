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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            box2.Text = box2.Text.Replace(box1.Text, "");
            int i;
            i = box2.Text.IndexOf(box1.Text);
            while (i >= 0)
            {
                box2.Text = box2.Text.Substring(0, i) +
                box2.Text.Substring(i + box1.Text.Length,
                box2.Text.Length - i - box1.Text.Length);

                i = box2.Text.IndexOf(box1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            box2.Text = box2.Text.Replace(box1.Text, "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string aux = box1.Text;
            char[] arr = aux.ToCharArray();  
            Array.Reverse(arr);   
            aux = "";
            foreach (char c in arr)
                aux = aux + c.ToString();
            MessageBox.Show(aux);

        }
    }
}
