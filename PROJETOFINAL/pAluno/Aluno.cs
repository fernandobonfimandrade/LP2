using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace pAluno
{

    class Aluno
    {
        private int raAluno;
        private string nomeAluno;
        private int idCidade;

        public int RaAluno
        {
            get
            {
                return raAluno;
            }
            set
            {
                raAluno = value;
            }
        }

        public string NomeAluno
        {
            get
            {
                return nomeAluno;
            }
            set
            {
                nomeAluno = value;
            }
        }
        public int IdCidade
        {
            get
            {
                return idCidade;
            }
            set
            {
                idCidade = value;
            }
        }

        public DataTable Listar()
        {
            SqlDataAdapter daAluno;
            DataTable dtAluno = new DataTable();

            try
            {
                daAluno = new SqlDataAdapter("SELECT * FROM TBaluno order by nome_aluno asc", frmPrincipal.conexao);
                daAluno.Fill(dtAluno);
                daAluno.FillSchema(dtAluno, SchemaType.Source);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtAluno; 
        }
        public int Salvar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                int nReg;
                mycommand = new SqlCommand("INSERT INTO TBAluno VALUES (@ra,@nome_aluno,@id_cidade)", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@ra", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nome_aluno", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@id_cidade", SqlDbType.Int));

                mycommand.Parameters["@ra"].Value = raAluno;
                mycommand.Parameters["@nome_aluno"].Value = nomeAluno;
                mycommand.Parameters["@id_cidade"].Value = idCidade;

                nReg = mycommand.ExecuteNonQuery();
                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }
        public int Alterar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                int nReg = 0;
                mycommand = new SqlCommand("UPDATE TBAluno SET ra_aluno = @ra, nome_aluno = @nome_aluno, cidade_id_cidade = @id_cidade WHERE ra_aluno = @ra", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@ra", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nome_aluno", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@id_cidade", SqlDbType.Int));

                mycommand.Parameters["@ra"].Value = raAluno;
                mycommand.Parameters["@nome_aluno"].Value = nomeAluno;
                mycommand.Parameters["@id_cidade"].Value = idCidade;

                nReg = mycommand.ExecuteNonQuery();
                if (nReg > 0)
                {
                    retorno = nReg;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }
        public int Excluir()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                int nReg = 0;
                mycommand = new SqlCommand("DELETE FROM TBaluno WHERE ra_aluno = @ra", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@ra", SqlDbType.Int));
                mycommand.Parameters["@ra"].Value = raAluno;
                nReg = mycommand.ExecuteNonQuery();
                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }
    }
}
