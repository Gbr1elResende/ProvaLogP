using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEscola
{
    public partial class frmAlunos : Form
    {
        public frmAlunos()
        {
            InitializeComponent();
        }
        Conexao bd = new Conexao();
        private void exibirdados()
        {
            dtgAlunos.DataSource = dadosAluno.ListarDados();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void frmAlunos_Load(object sender, EventArgs e)
        {
            exibirdados();
        }
        Aluno dadosAluno = new Aluno();

        private void ArmazenarDados()
        {
            int serieAluno = rdb1Serie.Checked ? 1 : rdb2Serie.Checked ? 2 : 3; ;
            char uidadeAluno = rdbBarroca.Checked ? 'B' : rdbFloresta.Checked ? 'F' : ' ';

            dadosAluno.SetNome(txtNome.Text);
            dadosAluno.SetIdade(int.Parse(txtIdade.Text));
            dadosAluno.SetSerie(serieAluno);
            dadosAluno.SetTurma(char.Parse(cmbTurma.Text));
            dadosAluno.SetUnidade(uidadeAluno);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ArmazenarDados();
            dadosAluno.InserirAluno();
            exibirdados();
            MessageBox.Show("Dados cadastrados com sucesso!");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            dadosAluno.SetId(int.Parse(txtID.Text));
            ArmazenarDados(); 
            dadosAluno.AlterarAluno();
            exibirdados();
            MessageBox.Show("Dados de aluno ALTERADOS com sucesso.");
        }

        private void dtgAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtgAlunos.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtNome.Text = dtgAlunos.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtIdade.Text = dtgAlunos.Rows[e.RowIndex].Cells["idade"].Value.ToString();
            cmbTurma.Text = dtgAlunos.Rows[e.RowIndex].Cells["turma"].Value.ToString();

            if (dtgAlunos.Rows[e.RowIndex].Cells["unidade"].Value.ToString() == "B")
                rdbBarroca.Checked = true;
            else
                if (dtgAlunos.Rows[e.RowIndex].Cells["unidade"].Value.ToString() == "F")
                rdbFloresta.Checked = true;

            rdb1Serie.Checked = dtgAlunos.Rows[e.RowIndex].Cells["serie"].Value.ToString() == "1" ? true : false;
            rdb2Serie.Checked = dtgAlunos.Rows[e.RowIndex].Cells["serie"].Value.ToString() == "1" ? true : false;
            rdb3Serie.Checked = dtgAlunos.Rows[e.RowIndex].Cells["serie"].Value.ToString() == "1" ? true : false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dadosAluno.SetId(int.Parse(txtID.Text));
            dadosAluno.ExcluirDados();
            exibirdados();
            MessageBox.Show("Dados ecluidos com sucesso.");
        }
    }

}
