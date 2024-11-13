using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProjetoEscola
{
    internal class Conexao
    {
        MySqlConnection Conn;
        private void Conectar()
        {
            string dadosconexao = "Persist Security info = false; server = localhost; database = dbescola; user = root; pwd=;";
            Conn = new MySqlConnection(dadosconexao);
            Conn.Open();

        }
        public DataTable consulta(string sql)
        {
            Conectar();
            MySqlDataAdapter dados = new MySqlDataAdapter(sql,Conn);
            DataTable dt = new DataTable();
            dados.Fill(dt); 
            Conn.Close();
            return dt;
        }
        public void ExecutarComando(string sql)
        {
            Conectar();
            MySqlCommand comando = new MySqlCommand(sql, Conn);
            comando.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
