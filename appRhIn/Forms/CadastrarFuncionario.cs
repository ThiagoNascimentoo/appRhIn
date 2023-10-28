using appRhIn.Classes;
using appRhIn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace appRhIn.Forms
{
    public partial class CadastrarFuncionario : Form
    {
        private MasterForm masterForm;
        public CadastrarFuncionario( MasterForm masterForm)
        {
            InitializeComponent();
            this.masterForm = masterForm;
        }

        private void CadastrarFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rHDataSet.Situacao'. Você pode movê-la ou removê-la conforme necessário.
            this.situacaoTableAdapter.Fill(this.rHDataSet.Situacao);
            // TODO: esta linha de código carrega dados na tabela 'rHDataSet.Setor'. Você pode movê-la ou removê-la conforme necessário.
            this.setorTableAdapter.Fill(this.rHDataSet.Setor);
            // TODO: esta linha de código carrega dados na tabela 'rHDataSet.Cargo'. Você pode movê-la ou removê-la conforme necessário.
            this.cargoTableAdapter.Fill(this.rHDataSet.Cargo);
            // TODO: esta linha de código carrega dados na tabela 'rHDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.rHDataSet.Funcionario);
            // TODO: esta linha de código carrega dados na tabela 'rHDataSet.Unidade'. Você pode movê-la ou removê-la conforme necessário.
            this.unidadeTableAdapter.Fill(this.rHDataSet.Unidade);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf;

            cpf = textCpf.Text.ToString().Replace(".", "");
            cpf = textCpf.Text.ToString().Replace("-", "");
            cpf = textCpf.Text.ToString().Replace(" ", "");

            if (
                textBoxNome.Text.ToString() == "" ||
                cpf == ""  || cpf.Length < 12 ||
                textDtNasc.Text.ToString() == "  /  /" ||
                textDtAdm.Text.ToString() == "  /  /" ||
                textUnidade.Text.ToString() is null ||
                textSetor.Text.ToString() is null ||
                textSituacao.Text.ToString() is null ||
                textCargo.Text.ToString() is null
                )
            {
                MessageBox.Show("Preencha todos os campos necessários!");
            }
            else
            {
                string DataDem;
                if (textDtDem.Text.ToString() == "  /  /") { DataDem = null; } else { DataDem = textDtDem.Text.ToString(); }
                Funcionario func = new Funcionario(
                    nome: textBoxNome.Text.ToString(),
                    dtNasc: textDtNasc.Text.ToString(),
                    dtAdm: textDtAdm.Text.ToString(),
                    dtDm: DataDem,
                    cargo: (int)textCargo.SelectedValue,
                    setor: (int)textSetor.SelectedValue,
                    unidade: (int)(int)textUnidade.SelectedValue,
                    situacaoId: (int)textSituacao.SelectedValue,
                    cpf: textCpf.Text.ToString()
                    );

                FuncionarioBd bd = new FuncionarioBd();
                try
                {
                    bool val = bd.cadastrarBD(func);
                    if ( val == true )
                    {
                        MessageBox.Show("Funcionário Cadastrado com Sucesso!");
                        masterForm.abrirFormFilho(new Funcionarios(masterForm));
                    } 

                    
                }
                catch (Exception ex) { MessageBox.Show("ERROR:", ex.Message); }
            }

        }

    }
}
