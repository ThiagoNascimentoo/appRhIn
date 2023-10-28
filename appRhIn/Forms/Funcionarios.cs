using appRhIn.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appRhIn.Forms
{
    public partial class Funcionarios : Form
    {
        private MasterForm masterForm;
        public Funcionarios(MasterForm masterForm)
        {
            InitializeComponent();
            this.masterForm = masterForm;
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rHDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.rHDataSet.Funcionario);

            using (SqlConnection connection = new SqlConnection(Conexao.strconexao))
            {
                connection.Open();

                // Execute sua consulta personalizada aqui e obtenha os resultados
                SqlCommand command = new SqlCommand("SELECT f.[Id]\r\n      ,f.[Nome]\r\n      ,f.[DtNasc]\r\n      ,f.[DtAdm]\r\n      ,f.[DtDm]\r\n      ,Cargo = c.Nome\r\n      ,Setor = s.Nome\r\n      ,Unidade = u.Nome\r\n      ,Situacao = sit.Nome\r\n  FROM [RH].[dbo].[Funcionario] f\r\n  inner join Cargo c on c.Id = f.Cargo\r\n  Inner join Setor s on s.Id = f.Setor\r\n  inner join Unidade u on u.Id = f.Unidade\r\n  inner join Situacao sit on sit.Id = f.SituacaoId\r\n", connection);
                SqlDataReader reader = command.ExecuteReader();

                // Crie uma DataTable para armazenar os resultados
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                // Associe o DataGridView com a DataTable
                dataGridView1.DataSource = dataTable;
            }


        }



        private void btnCad_Click(object sender, EventArgs e)
        {
            masterForm.abrirFormFilho(new CadastrarFuncionario(masterForm));
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.funcionarioTableAdapter.FillBy(this.rHDataSet.Funcionario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    }
}
