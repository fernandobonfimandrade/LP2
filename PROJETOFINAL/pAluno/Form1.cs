using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pAluno
{
    public partial class frmPrincipal : Form
    {

        public static SqlConnection conexao;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCidade frmCid = new frmCidade();
            frmCid.MdiParent = this;
            frmCid.WindowState = FormWindowState.Maximized;
            frmCid.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=DESKTOP-5G9GOHG\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True");
                    conexao.Open();
            }catch(SqlException ex)
            {
                MessageBox.Show("Erro de Banco de Dados =/"+ ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Outros Erros =/" + ex.Message);
            }
        }

        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAluno frmAluno = new frmAluno();
            frmAluno.MdiParent = this;
            frmAluno.WindowState = FormWindowState.Maximized;
            frmAluno.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feito por Fernando Bonfim Andrade\n\n RA: 0030481923015");
        }
    }
}
