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

namespace SistemaGerenciadorEscolar
{
    public partial class cadDisciplina : MetroForm
    {
        public cadDisciplina()
        {
            InitializeComponent();
        }

        Camadas.DTO.DisciplinaDTO disciplinadto = new Camadas.DTO.DisciplinaDTO();
        Camadas.Model.DisciplinaModel disciplinamodel = new Camadas.Model.DisciplinaModel();

        private void cadDisciplina_Load(object sender, EventArgs e)
        {
            Carregar_Grid();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CADDISCIPLINA" E ABRE O FORM "CADASTRO"
            Cadastro Cadastro = new Cadastro();
            Cadastro.Show();
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDisc.Clear();
            txtCarga.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarCampos() == true)
                {

                }
                else if (VerificarCampos() == false)
                {
                    disciplinadto.Disciplina = txtDisc.Text;
                    disciplinadto.Carga_horario = txtCarga.Text;

                    int x = disciplinamodel.IncluirDisciplina(disciplinadto);
                    if (x > 0)
                    {
                        MessageBox.Show("Disciplina " + txtDisc.Text + ", foi incluido com sucesso !!!", "Concluido",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Limpar_campos();
                        Carregar_Grid();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível inserir esta disciplina.", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possive executar a operação", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try{
            string usuariocons = dgvConsulta.CurrentRow.Cells[1].Value.ToString();
            if (VerificarCampos() == true)
            {

            }
            else if (VerificarCampos() == false)
            {
                disciplinadto.Id_disc = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());
                disciplinadto.Disciplina = txtDisc.Text;
                disciplinadto.Carga_horario = txtCarga.Text;

                int x = disciplinamodel.AlterarDisciplina(disciplinadto);

                if (x > 0)
                {
                    MessageBox.Show("O usuário " + usuariocons + ", foi alterado com sucesso !!!", "Concluido",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Carregar_Grid();
                    Limpar_campos();
                }
                else
                {
                    MessageBox.Show("Não foi possível alterar o usuário " + usuariocons, "ERROR",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possive executar a operação", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string disciplinacons = dgvConsulta.CurrentRow.Cells[1].Value.ToString();
                disciplinadto.Id_disc = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());

                int x = disciplinamodel.ExcluirDisciplina(disciplinadto);

                if (x > 0)
                {
                    MessageBox.Show("O usuário " + disciplinacons + ", foi excluido com sucesso !!!", "Concluido",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Carregar_Grid();
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o usuário " + disciplinacons, "ERROR",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possive executar a operação", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDisc.Text = dgvConsulta.CurrentRow.Cells[1].Value.ToString();
            txtCarga.Text = dgvConsulta.CurrentRow.Cells[2].Value.ToString();
        }
        private void Limpar_campos()
        {
            txtDisc.Clear();
            txtCarga.Clear();
        }
        public Boolean VerificarCampos()
        {
            if (txtDisc.Text == "" || txtCarga.Text == "")
            {
                MessageBox.Show("Os Campos Não Estão Preenchidos", "Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Carregar_Grid()
        {
            try
            {
                IList<Camadas.DTO.DisciplinaDTO> listadisciplina = new List<Camadas.DTO.DisciplinaDTO>();
                {
                    listadisciplina = new Camadas.Model.DisciplinaModel().ConsultaDisciplina();
                    dgvConsulta.AutoGenerateColumns = false;
                    dgvConsulta.DataSource = listadisciplina;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os dados do usuario" + erro.Message);
            }
        }
    }
}
