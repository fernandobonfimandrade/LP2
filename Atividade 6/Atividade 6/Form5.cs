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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salarioBruto, gratificacao = 0;
            int b = 0, c = 0, d = 0;

            if (double.TryParse(boxSalario.Text, out double salario) && double.TryParse(boxGratif.Text, out gratificacao) &&
                int.TryParse(boxProd.Text, out int producao))
            {
                if (producao >= 100) b = 1;
                if (producao >= 120) c = 1;
                if (producao >= 150) d = 1;
                salarioBruto = salario + salario * (0.05 * b + 0.1 * c + 0.1 * d) + gratificacao;
                if (salarioBruto > 7000)
                {
                    if (producao < 150 || gratificacao == 0) salarioBruto = 7000.00;
                }
                MessageBox.Show("O Salário Bruto é R$ " + salarioBruto.ToString("N2"));
            }
            else
                MessageBox.Show("Dados inválidos!");
        }
    }
}
