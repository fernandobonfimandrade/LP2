using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inss_irpf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkCasado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void calcularBT_Click(object sender, EventArgs e)
        {
            string nomeFuncionario;
            double salFuncionario;
            int qtdFilhos;
            bool casado = false;
            char sexo = 'M';

            if (checkCasado.Checked)
            {
                casado = true;
            }
            if (radioFemino.Checked)
            {
                sexo = 'F';
            }
            if(double.TryParse(inputSalario.Text, out salFuncionario) && int.TryParse(inputQtdFilhos.Text, out qtdFilhos) && inputNome.Text != "" )
            {
                nomeFuncionario = inputNome.Text;
                if (salFuncionario > 0 && qtdFilhos >= 0)
                {
                    double aliqINSS, aliqIRPF, valorINSS, valorIRPF, valorSalFamilia = 0, valorSalLiquido;
                    /*Aliquota INSS para Salário Bruto: 
                     * Até 800.47 - 7.65% 
                     * De 800.48 a 1050 - 8.65% 
                     * De 1050.01 a 1400.77 – 9.00% 
                     * De 1400.78 a 2801.56 – 11.00% 
                     * >2801.56 -> Desconto = 308.17 (teto) 
                     */
                    if (salFuncionario.CompareTo(800.47) <= 0)
                    {
                        aliqINSS = 0.0765;
                    }
                    else
                    {
                        if (salFuncionario.CompareTo(1050.00) <= 0)
                        {
                            aliqINSS = 0.0865;
                        }
                        else
                        {
                            if (salFuncionario.CompareTo(1400.00) <= 0)
                            {
                                aliqINSS = 0.09;
                            }
                            else
                            {
                                if (salFuncionario.CompareTo(2801.56) <= 0)
                                {
                                    aliqINSS = 0.11;
                                }
                                else
                                {
                                    //Teto
                                    aliqINSS = 0.00;
                                }
                            }
                        }
                    }
                    if (aliqINSS > 0)
                    {
                        valorINSS = Math.Round((salFuncionario * aliqINSS), 2);
                    }
                    else
                    {
                        //Teto
                        valorINSS = 308.17;
                    }
                    /*
                    outAliqInss.Mask = "000,00%";
                    outAliqInss.RightToLeft = RightToLeft.Yes;
                    outAliqInss.TextAlign = HorizontalAlignment.Right;*/
                    outAliqInss.Text = Math.Round((aliqINSS * 100), 2).ToString()+"%";

                    /*outValorInss.Mask = "00000,00";
                    outValorInss.RightToLeft = RightToLeft.Yes;
                    outValorInss.TextAlign = HorizontalAlignment.Right;*/
                    outValorInss.Text = valorINSS.ToString();

                    /*Alíquota IRPF para Salário Bruto: 
                     * Até 1257.12  - isento 
                     * De 1257.13 a 2512.08 – 15.00% 
                     * > 2512.08 - 27.5% 
                     */
                    if (salFuncionario.CompareTo(1257.12) <= 0)
                    {
                        aliqIRPF = 0;
                    }
                    else
                    {
                        if (salFuncionario.CompareTo(2512.08) <= 0)
                        {
                            aliqIRPF = 0.15;
                        }
                        else
                        {
                            aliqIRPF = 0.275;
                        }
                    }
                    valorIRPF = Math.Round((salFuncionario * aliqIRPF), 2);
                   /* outAliqIrpf.Mask = "000,00%";
                    outAliqIrpf.RightToLeft = RightToLeft.Yes;
                    outAliqIrpf.TextAlign = HorizontalAlignment.Right;*/
                    outAliqIrpf.Text = Math.Round((aliqIRPF * 100), 2).ToString()+"%";

                    /*outValorIrpf.Mask = "00000,00";
                    outValorIrpf.RightToLeft = RightToLeft.Yes;
                    outValorIrpf.TextAlign = HorizontalAlignment.Right;*/
                    outValorIrpf.Text = valorIRPF.ToString();

                    /*Salário Família para Salário Bruto: 
                    * Até 435.52 - 22.33 por filho
                    */
                    if (qtdFilhos > 0)
                    {
                        valorSalFamilia = Math.Round((qtdFilhos * 22.33), 2);
                        if (valorSalFamilia.CompareTo(435.52) > 0)
                        {
                            valorSalFamilia = 435.52;
                        }
                    }
                    outSalFamilia.Text = valorSalFamilia.ToString();

                    valorSalLiquido = salFuncionario - valorINSS - valorIRPF + valorSalFamilia;
                    /*outSalLiquido.Mask = "00000,00";
                    outSalLiquido.RightToLeft = RightToLeft.Yes;
                    outSalLiquido.TextAlign = HorizontalAlignment.Right;*/
                    outSalLiquido.Text = valorSalLiquido.ToString();

                    string filhos = qtdFilhos.ToString();
                    string genero = sexo == 'F' ? "a" : "o";
                    string generoRef = sexo == 'M' ? "Sr." : "Sra.";
                    msgSobre.Text = "Os Descontos incidentes sobre o salário do "+generoRef+" "+nomeFuncionario+ " que é " + (casado ? "casad"+genero : "solteir"+genero) + " e que ";
                    if (qtdFilhos > 0)
                    {
                        msgSobre.Text += "possui "+ filhos;
                    }else{
                        msgSobre.Text += "não possui";
                    }
                    msgSobre.Text += " filhos são:";
                }
                else
                {
                    MessageBox.Show("Valores inválidos para Salário ou Quantidade de filhos\nQuantidade de filhos não podem ser negativos\nSalario não pode ser menor ou igual a Zero!");
                }
            }
            else
            {
                MessageBox.Show("Informe valores válidos para cada campo!");
            }

        }
    }
}
