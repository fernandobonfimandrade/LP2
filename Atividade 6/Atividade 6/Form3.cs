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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, n = Convert.ToInt32(boxN.Text);
            double h = 1;
            /* H = 1 + 1/2 +1/3+1/4+1/5+...+1/N */
            for(i=2; i <= n; i++)
            {
                h += 1.0 / i;
            }
            MessageBox.Show("H = " + h.ToString("N2"));
        }
    }
}
