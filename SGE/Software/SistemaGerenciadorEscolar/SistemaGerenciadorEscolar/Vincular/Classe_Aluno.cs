using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGerenciadorEscolar.Vincular
{
    public partial class Classe_Aluno : MetroForm
    {
        public Classe_Aluno()
        {
            InitializeComponent();
        }

        Camadas.DTO.Classe_AlunoDTO classe_alunodto = new Camadas.DTO.Classe_AlunoDTO();
        Camadas.Model.Classe_AlunoModel classe_alunomodel = new Camadas.Model.Classe_AlunoModel();
        private void Classe_Aluno_Load(object sender, EventArgs e)
        {
            Carregar_Grid();
            Carregar_Combox_Classe();
            Carregar_Combox_Aluno();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Vincular vinc = new Vincular();
            vinc.Show();
            this.Hide();
        }
        private void Carregar_Combox_Classe()
        {
            IList<Camadas.DTO.ClasseDTO> listaclasse = new List<Camadas.DTO.ClasseDTO>();
            listaclasse = new Camadas.Model.ClasseModel().ConsultarClasse();
            cmbClasse.DataSource = listaclasse;
            cmbClasse.DisplayMember = "classe";
            cmbClasse.ValueMember = "id_classe";
            cmbClasse.Refresh();
        }
        private void Carregar_Combox_Aluno()
        {
            IList<Camadas.DTO.AlunoDTO> listaaluno = new List<Camadas.DTO.AlunoDTO>();
            listaaluno = new Camadas.Model.AlunoModel().ConsultarAluno();
            cmbAluno.DataSource = listaaluno;
            cmbAluno.DisplayMember = "nome_aluno";
            cmbAluno.ValueMember = "id_aluno";
            cmbAluno.Refresh();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            classe_alunodto.Id_classe = Convert.ToInt32(cmbClasse.SelectedValue);
            classe_alunodto.Id_aluno = Convert.ToInt32(cmbAluno.SelectedValue);

            int x = classe_alunomodel.IncluirClasse_Aluno(classe_alunodto);

            if (x > 0)
            {
                MessageBox.Show("O Aluno " + cmbAluno.Text + ", foi vinculada na Classe " + cmbClasse.Text, "Concluido",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Carregar_Grid();
            }
            else 
            {
                MessageBox.Show("Não foi possível vincular este Aluno ", "ERROR",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void Carregar_Grid()
        {
            IList<Camadas.DTO.Classe_AlunoDTO> listaclasse_aluno = new List<Camadas.DTO.Classe_AlunoDTO>();
            {
                listaclasse_aluno = new Camadas.Model.Classe_AlunoModel().ConsultarClasse_Aluno();
                dgvConsulta.AutoGenerateColumns = false;
                dgvConsulta.DataSource = listaclasse_aluno;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            classe_alunodto.Id_classe_aluno = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());
            classe_alunodto.Id_classe = Convert.ToInt32(cmbClasse.SelectedValue);
            classe_alunodto.Id_aluno = Convert.ToInt32(cmbAluno.SelectedValue);

            int x = classe_alunomodel.AlterarClasse_Aluno(classe_alunodto);

            if (x > 0)
            {
                MessageBox.Show("O Aluno " + cmbAluno.Text + "foi alterada com sucesso para a Classe " + cmbClasse.Text, "Concluido",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Carregar_Grid();
            }
            else
            {
                MessageBox.Show("Não foi possível alterar este Aluno", "ERROR",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            classe_alunodto.Id_classe_aluno = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());

            int x = classe_alunomodel.ExcluirClasse_Aluno(classe_alunodto);

            if (x > 0)
            {
                MessageBox.Show("O Aluno foi desvinculado com sucesso !!!", "Concluido",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Carregar_Grid();
            }
            else
            {
                MessageBox.Show("Não foi possível desvincular este Aluno", "ERROR",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbClasse.Text =dgvConsulta.CurrentRow.Cells[3].Value.ToString();
            cmbAluno.Text = dgvConsulta.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
