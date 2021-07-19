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
    public partial class cadClasse : MetroForm
    {
        public cadClasse()
        {
            InitializeComponent();
        }

        Camadas.DTO.ClasseDTO classedto = new Camadas.DTO.ClasseDTO();
        Camadas.Model.ClasseModel classemodel = new Camadas.Model.ClasseModel();        

        private void cadClasse_Load(object sender, EventArgs e)
        {
            Carregar_Combox();
            Carregar_Grid();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CADCLASE" E ABRE O FORM "CADASTRO"
            Cadastro Cadastro = new Cadastro();
            Cadastro.Show();
            this.Close();
        }

        private void dgvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtClasse.Text = dgvConsulta.CurrentRow.Cells[1].Value.ToString();
            cmbCurso.Text = dgvConsulta.CurrentRow.Cells[2].Value.ToString();
        }
        private Boolean VerificarCampos()
        {
            if (txtClasse.Text == "" || cmbCurso.SelectedIndex == -1)
            {
                MessageBox.Show("O Campo Nome Não Está Preenchidos", "Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void LimparCampos()
        {
            txtClasse.Clear();            
        }
        private void Carregar_Grid()
        {
            IList<Camadas.DTO.ClasseDTO> listaclasse = new List<Camadas.DTO.ClasseDTO>();
            {
                listaclasse = new Camadas.Model.ClasseModel().ConsultarClasse();
                dgvConsulta.AutoGenerateColumns = false;
                dgvConsulta.DataSource = listaclasse;
            }
        }

        private void Carregar_Combox()
        {
            try
            {
                IList<Camadas.DTO.CursoDTO> listacurso = new List<Camadas.DTO.CursoDTO>();
                {
                    listacurso = new Camadas.Model.CursoModel().ConsultarCurso();
                    cmbCurso.DataSource = listacurso;
                    cmbCurso.DisplayMember = "curso";
                    cmbCurso.ValueMember = "id_curso";
                    cmbCurso.Refresh();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possive executar a operação", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
                if (VerificarCampos() == true)
                {

                }
                else if (VerificarCampos() == false)
                {
                    classedto.Classe = txtClasse.Text;
                    classedto.Id_curso = Convert.ToInt16(cmbCurso.SelectedValue);

                    int x = classemodel.IncluirClasse(classedto);

                    if (x > 0)
                    {
                        MessageBox.Show("Classe " + txtClasse.Text + ", foi incluido com sucesso !!!", "Concluido",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txtClasse.Clear();
                        Carregar_Grid();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível inserir esta classe.", "ERROR",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }           
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            string classecons = dgvConsulta.CurrentRow.Cells[1].Value.ToString();
            
                if (VerificarCampos() == true)
                {

                }
                else if (VerificarCampos() == false)
                {
                    classedto.Id_classe = Convert.ToInt16(dgvConsulta.CurrentRow.Cells[0].Value.ToString());
                    classedto.Classe = txtClasse.Text;
                    classedto.Id_curso = Convert.ToInt16(cmbCurso.SelectedValue);

                    int x = classemodel.AlterarClasse(classedto);

                    if (x > 0)
                    {
                        MessageBox.Show("A Classe " + classecons + ", foi alterado com sucesso !!!", "Concluido",
                               MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Carregar_Grid();
                        txtClasse.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível alterar a classe " + classecons, "ERROR",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            string classecons = dgvConsulta.CurrentRow.Cells[1].Value.ToString();
            try
            {
                classedto.Id_classe = Convert.ToInt16(dgvConsulta.CurrentRow.Cells[0].Value.ToString());

                int x = classemodel.ExcluirClasse(classedto);

                if (x > 0)
                {
                    MessageBox.Show("A Classe " + classecons + ", foi excluido com sucesso !!!", "Concluido",
                               MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Carregar_Grid();
                }
                else
                {
                    MessageBox.Show("Não foi possível alterar a classe " + classecons, "ERROR",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possive executar a operação", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvConsulta_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtClasse.Text = dgvConsulta.CurrentRow.Cells[1].Value.ToString();            
        }
    }
}
