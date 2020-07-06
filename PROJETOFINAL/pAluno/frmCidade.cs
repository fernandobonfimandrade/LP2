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
    public partial class frmCidade : Form
    {
        private BindingSource bnCidade = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsCidade = new DataSet();

        public frmCidade()
        {
            InitializeComponent();
        }

        private void frmCidade_Load(object sender, EventArgs e)
        {
            try
            {
                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());
                bnCidade.DataSource = dsCidade.Tables["TBcidade"];
                dgvCidade.DataSource = bnCidade;
                bnvCidade.BindingSource = bnCidade;

                txtId.DataBindings.Add("TEXT", bnCidade, "id_cidade");
                txtNomeCidade.DataBindings.Add("TEXT", bnCidade, "nome_cidade");
                cbxEstado.DataBindings.Add("TEXT", bnCidade, "uf_cidade");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //validar dados
            if(txtNomeCidade.Text == "")
            {
                MessageBox.Show("Informe um nome válido para cidade!");
            }
            else
            {
                Cidade RegCid = new Cidade();
                RegCid.Idcidade = Convert.ToInt16(txtId.Text);
                RegCid.Nomecidade = txtNomeCidade.Text;
                RegCid.Ufcidade = cbxEstado.SelectedItem.ToString();

                if (bInclusao)
                {
                    if(RegCid.Salvar() > 0)
                    {
                        MessageBox.Show("Cidade adicionada com sucesso!");

                        bInclusao = false;

                    }
                    else
                    {
                        MessageBox.Show("Erro ao incluir cidade!");
                    }
                }
                else
                {
                    if(RegCid.Alterar() > 0)
                    {
                        MessageBox.Show("Cidade alterada com sucesso!");

                        bInclusao = false;

                    }
                }
                btnSalvar.Enabled = false;
                txtId.Enabled = false;
                txtNomeCidade.Enabled = false;
                cbxEstado.Enabled = false;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;

                btnAlterar.Enabled = true;
                btnNovoRegistro.Enabled = true;
                btnExcluir.Enabled = true;

                dsCidade.Tables.Clear();
                dsCidade.Tables.Add(RegCid.Listar());
                bnCidade.DataSource = dsCidade.Tables["TBcidade"];

                tabControl1.SelectTab(0);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }

            bnCidade.AddNew();
            txtNomeCidade.Focus();
            cbxEstado.SelectedIndex = 0;
            txtNomeCidade.Enabled = true;
            cbxEstado.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;

            bInclusao = true;
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }


            Cidade RegCid = new Cidade();
            RegCid.Idcidade = Convert.ToInt16(txtId.Text);
            RegCid.Nomecidade = txtNomeCidade.Text;

            if (MessageBox.Show("Confirma Exlusão de " + RegCid.Nomecidade, "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (RegCid.Idcidade == 0)
                {
                    MessageBox.Show("Selecione uma Cidade!");
                }
                else
                {
                    if (RegCid.Excluir() > 0)
                    {
                        MessageBox.Show("Cidade " + RegCid.Nomecidade + " removida com sucesso!");

                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCid.Listar());
                        bnCidade.DataSource = dsCidade.Tables["TBcidade"];

                        tabControl1.SelectTab(0);

                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir cidade!");
                    }
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnCidade.CancelEdit();

            btnSalvar.Enabled = false;
            txtNomeCidade.Enabled = false;
            cbxEstado.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovoRegistro.Enabled = true;
            btnExcluir.Enabled = true;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }

            txtNomeCidade.Focus();
            txtNomeCidade.Enabled = true;
            cbxEstado.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;

            bInclusao = false;

        }
    }
}
