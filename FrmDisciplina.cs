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
    public partial class FrmDisciplina : Form
    {
        public FrmDisciplina()
        {
            InitializeComponent();
        }
        private void exibirdados()
        {
            dtgDisciplina.DataSource = dadosDisciplina.ListarDisciplinas();
        }
        private void FrmDisciplina_Load(object sender, EventArgs e)
        {
            exibirdados();
        }
        Disciplinas dadosDisciplina = new Disciplinas();
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ArmazenarDados()
        {
            dadosDisciplina.SetNome(txtNome.Text);
            dadosDisciplina.SetCargaH(int.Parse(txtCargaHoraria.Text));
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ArmazenarDados();
            dadosDisciplina.InserirDisciplina();
            exibirdados();
            MessageBox.Show("Dados cadastrados com sucesso!");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            dadosDisciplina.SetId(int.Parse(txtID.Text));
            ArmazenarDados();
            dadosDisciplina.AlterarDisciplina();
            exibirdados();
            MessageBox.Show("Dados de aluno ALTERADOS com sucesso.");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dadosDisciplina.SetId(int.Parse(txtID.Text));
            dadosDisciplina.ExcluirDisciplina();
            exibirdados();
            MessageBox.Show("Dados ecluidos com sucesso.");
        }

    }
}
