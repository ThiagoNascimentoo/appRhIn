using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appRhIn.Classes
{
    internal class Funcionario
    {
        int     id;
        string  nome;
        string  dtNasc;
        string  dtAdm;
        string  dtDm = null;
        int     cargo;
        int     setor;
        int     unidade;
        int     situacaoId;
        string  cpf;
        public Funcionario() { }
        public Funcionario(int id, string nome, string dtNasc, string dtAdm, string dtDm, int cargo, int setor, int unidade, int situacaoId, string cpf)
        {
            this.id = id;
            this.nome = nome;
            this.dtNasc = dtNasc;
            this.dtAdm = dtAdm;
            this.dtDm = dtDm;
            this.cargo = cargo;
            this.setor = setor;
            this.unidade = unidade;
            this.situacaoId = situacaoId;
            this.cpf = cpf;
        }
        public Funcionario(string nome, string dtNasc, string dtAdm, string dtDm, int cargo, int setor, int unidade, int situacaoId, string cpf)
        {
            this.nome = nome;
            this.dtNasc = dtNasc;
            this.dtAdm = dtAdm;
            this.dtDm = dtDm;
            this.cargo = cargo;
            this.setor = setor;
            this.unidade = unidade;
            this.situacaoId = situacaoId;
            this.cpf = cpf;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string DtNasc { get => dtNasc; set => dtNasc = value; }
        public string DtAdm { get => dtAdm; set => dtAdm = value; }
        public string DtDm { get => dtDm; set => dtDm = value; }
        public int Cargo { get => cargo; set => cargo = value; }
        public int Setor { get => setor; set => setor = value; }
        public int Unidade { get => unidade; set => unidade = value; }
        public int SituacaoId { get => situacaoId; set => situacaoId = value; }
        public string Cpf { get => cpf; set => cpf = value; }
    }
}
