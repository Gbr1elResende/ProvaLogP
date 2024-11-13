using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola
{
    internal class Disciplinas
    {
        private int id, cargaH;
        private string nome;

        public int GetId()
        {
            return this.id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public int GetCargaH()
        {
            return this.cargaH;
        }
        public void SetCargaH(int cargaH)
        {
            this.cargaH = cargaH;
        }
        public string GetNome()
        {
            return this.nome;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        Conexao bd = new Conexao();

        public void InserirDisciplina()
        {
            string inserir = $"insert into tblDisciplinas values (null, '{this.nome}', '{this.cargaH}');";
            bd.ExecutarComando(inserir);
        }
        public void AlterarDisciplina()
        {
            string alterar = $"update tblDisciplinas set nome = '{this.nome}', cargaH = '{this.cargaH}' where id = '{this.id}';";
            bd.ExecutarComando(alterar);
        }
        public void ExcluirDisciplina()
        {
            string excluir = $"delete from tblDisciplinas where id = '{this.id}';";
            bd.ExecutarComando(excluir);
        }

        /*/////////////////////////////////////////////////////*/
        public DataTable ListarDisciplinas()
        {
            string query = "select * From tblDisciplinas ORDER BY nome;";
            return bd.consulta(query);
        }

    }
}
