using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pAluno
{
    public partial class frmAluno : Form
    {
        private BindingSource bnAluno = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsAluno = new DataSet();
        private DataSet dsCidade = new DataSet();


        public frmAluno()
        {
            InitializeComponent();
        }

        private void frmAluno_Load(object sender, EventArgs e)
        {
            try
            {
                Aluno Alu = new Aluno();
                dsAluno.Tables.Add(Alu.Listar());
                bnAluno.DataSource = dsAluno.Tables["TBaluno"];
                dgvAluno.DataSource = bnAluno;
                bnvAluno.BindingSource = bnAluno;

                txtRA.DataBindings.Add("TEXT", bnAluno, "ra_aluno");
                txtNomeAluno.DataBindings.Add("TEXT", bnAluno, "nome_aluno");

                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());

                cbxCidade.DataSource = dsCidade.Tables["TBcidade"];
                cbxCidade.DisplayMember = "nome_cidade";
                cbxCidade.ValueMember = "id_cidade";

                cbxCidade.DataBindings.Add("selectedValue", bnAluno, "cidade_id_cidade");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }

            txtNomeAluno.Focus();
            txtNomeAluno.Enabled = true;
            cbxCidade.Enabled = true;
            txtRA.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;

            bInclusao = false;
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }

            bnAluno.AddNew();
            txtNomeAluno.Focus();
            cbxCidade.SelectedIndex = 0;
            txtNomeAluno.Enabled = true;
            txtRA.Enabled = true;
            cbxCidade.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;

            bInclusao = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }


            Aluno RegAl = new Aluno();
            RegAl.RaAluno = Convert.ToInt16(txtRA.Text);
            RegAl.NomeAluno = txtNomeAluno.Text;

            if (MessageBox.Show("Confirma Exlusão de " + RegAl.NomeAluno, "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (RegAl.RaAluno == 0)
                {
                    MessageBox.Show("Selecione um Aluno!");
                }
                else
                {
                    if (RegAl.Excluir() > 0)
                    {
                        MessageBox.Show("Cidade " + RegAl.NomeAluno + " removido com sucesso!");

                        dsAluno.Tables.Clear();
                        dsAluno.Tables.Add(RegAl.Listar());
                        bnAluno.DataSource = dsAluno.Tables["TBaluno"];

                        tabControl1.SelectTab(0);

                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir Aluno!");
                    }
                }

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeAluno.Text == "")
            {
                MessageBox.Show("Informe um nome válido para o Aluno!");
            }
            else
            {
                Aluno RegAl = new Aluno();
                RegAl.RaAluno = Convert.ToInt16(txtRA.Text);
                RegAl.NomeAluno = txtNomeAluno.Text;
                RegAl.IdCidade = Convert.ToInt32(cbxCidade.SelectedValue.ToString());

                if (bInclusao)
                {
                    if (RegAl.Salvar() > 0)
                    {
                        MessageBox.Show("Aluno adicionado com sucesso!");

                        bInclusao = false;

                    }
                    else
                    {
                        MessageBox.Show("Erro ao incluir Aluno!");
                    }
                }
                else
                {
                    if (RegAl.Alterar() > 0)
                    {
                        MessageBox.Show("Aluno alterada com sucesso!");

                        bInclusao = false;

                    }
                }
                btnSalvar.Enabled = false;
                txtRA.Enabled = false;
                txtNomeAluno.Enabled = false;
                cbxCidade.Enabled = false;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;

                btnAlterar.Enabled = true;
                btnNovoRegistro.Enabled = true;
                btnExcluir.Enabled = true;

                dsAluno.Tables.Clear();
                dsAluno.Tables.Add(RegAl.Listar());
                bnAluno.DataSource = dsAluno.Tables["TBaluno"];

                tabControl1.SelectTab(0);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnAluno.CancelEdit();

            btnSalvar.Enabled = false;
            txtNomeAluno.Enabled = false;
            cbxCidade.Enabled = false;
            txtRA.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovoRegistro.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
