using Mysqlx.Expr;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola
{
    internal class Aluno
    {
        private int id, idade, serie;
        private string nome;
        private char unidade, turma;
        
        public int GetId()
        {
            return this.id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetIdade()
        {
            return this.idade;
        }
        public void SetIdade(int idade)
        {
            this.idade = idade;
        }

        public int GetSerie()
        {
            return this.serie;
        }
        public void SetSerie(int serie)
        {
            this.serie = serie;
        }

        public string GetNome()
        {
            return this.nome;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public char GetUnidade()
        {
            return this.unidade;
        }
        public void SetUnidade(char unidade)
        {
            this.unidade = unidade;
        }

        public char GetTurma()
        {
            return this.turma;
        }
        public void SetTurma(char turma)
        {
            this.turma = turma;
        }
        /*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////*/
        Conexao bd = new Conexao();
        public void InserirAluno()
        {
            string inserir = $"insert into tblalunos values (null, '{this.nome}', '{this.idade}', '{this.unidade}', '{this.serie}', '{this.turma}');";
            bd.ExecutarComando(inserir);
        }
        public void AlterarAluno()
        {
            string alterar = $"update tblalunos set nome = '{this.nome}', idade = '{this.idade}', unidade = '{this.unidade}', serie = '{this.serie}', turma = '{this.turma}' where id = '{this.id}';";
            bd.ExecutarComando(alterar);
        }
        public void ExcluirDados()
        {
            string excluir = $"delete from tblalunos where id = '{this.id}';";
            bd.ExecutarComando(excluir);
        }

        /*/////////////////////////////////////////////////////*/
        public DataTable ListarDados()
        {
            string query = "select * From tblAlunos ORDER BY nome;";
            return bd.consulta(query);
        }
    }
}
