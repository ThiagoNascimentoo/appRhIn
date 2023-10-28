using appRhIn.Classes;
using appRhIn.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appRhIn.Models
{
    internal class FuncionarioBd
    {
        public SqlConnection con;
        public SqlCommand cmd = new SqlCommand();
        public string strconexao = Conexao.strconexao;


        public bool cadastrarBD(Funcionario funcionario)
        {
            cmd.CommandText = "EXEC sp_InserirFuncionario " +
                "@Nome=@nome, " +
                "@DtNasc=@dtnasc, " +
                "@DtAdm=@dtadm, " +
                "@Cargo=@cargo, " +
                "@Setor=@setor, " +
                "@Unidade=@unidade, " +
                "@SituacaoId=@situacao";

            cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
            cmd.Parameters.AddWithValue("@dtnasc", funcionario.DtNasc);
            cmd.Parameters.AddWithValue("@dtadm", funcionario.DtAdm);
            cmd.Parameters.AddWithValue("@cargo", funcionario.Cargo);
            cmd.Parameters.AddWithValue("@setor", funcionario.Setor);
            cmd.Parameters.AddWithValue("@unidade", funcionario.Unidade);
            cmd.Parameters.AddWithValue("@situacao", funcionario.SituacaoId);

            try
            {
                SqlConnection con = new SqlConnection(strconexao);
                con.Open();
                cmd.Connection = con;

                cmd.ExecuteNonQuery();

                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                string erro = ex.Message;
                MessageBox.Show(erro);
                return false;
            }


        }
            
    }
}
