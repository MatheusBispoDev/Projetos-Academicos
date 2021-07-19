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
    public partial class cadCurso : MetroForm
    {
        public cadCurso()
        {
            InitializeComponent();
        }

        Camadas.DTO.CursoDTO cursodto = new Camadas.DTO.CursoDTO();
        Camadas.Model.CursoModel cursomodel = new Camadas.Model.CursoModel();

        private void cadCurso_Load(object sender, EventArgs e)
        {
            Carrega_grid();
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CADCURSO" E ABRE O FORM "CADASTRO"
            Cadastro Cadastro = new Cadastro();
            Cadastro.Show();
            this.Close();
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
                    cursodto.Curso = txtCurso.Text;
                    cursodto.Modulo_Curso = txtModulo.Text;
                    cursodto.Periodo_curso = txtPeriodo.Text;

                    int x = cursomodel.IncluirCurso(cursodto);
                    if (x > 0)
                    {
                        MessageBox.Show("O Curso " + txtCurso.Text + ", foi incluido com sucesso !!!", "Concluido",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Limpar_Campos();
                        Carrega_grid();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível inserir este curso.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possive executar a operação","ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
        }
        private void dgvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCurso.Text = dgvConsulta.CurrentRow.Cells[1].Value.ToString();
            txtModulo.Text = dgvConsulta.CurrentRow.Cells[2].Value.ToString();
            txtPeriodo.Text = dgvConsulta.CurrentRow.Cells[3].Value.ToString();  
        }
        private void Limpar_Campos()
        {
            txtCurso.Clear();
            txtModulo.Clear();
            txtPeriodo.Clear();
        }
        private Boolean VerificarCampos()
        {
            if (txtCurso.Text == "" || txtModulo.Text == "" || txtPeriodo.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return true;
            }
            else
            {
                return false;
            }
        }
        private void Carrega_grid()
        {
            try
            {
                IList<Camadas.DTO.CursoDTO> listacurso = new List<Camadas.DTO.CursoDTO>();
                {
                    listacurso = new Camadas.Model.CursoModel().ConsultarCurso();
                    dgvConsulta.AutoGenerateColumns = false;
                    dgvConsulta.DataSource = listacurso;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os dados do curso" + erro.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                string cursocons = dgvConsulta.CurrentRow.Cells[1].Value.ToString();

                if (VerificarCampos() == true)
                {

                }
                else if (VerificarCampos() == false)
                {
                    cursodto.Id_curso = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());
                    cursodto.Curso = txtCurso.Text;
                    cursodto.Modulo_Curso = txtModulo.Text;
                    cursodto.Periodo_curso = txtPeriodo.Text;

                    int x = cursomodel.AlterarCurso(cursodto);

                    if (x > 0)
                    {
                        MessageBox.Show("O curso " + cursocons + ", foi alterado com sucesso !!!", "Concluido",
                               MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Carrega_grid();
                        Limpar_Campos();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível alterar o curso " + cursocons, "ERROR",
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
            string cursocons = dgvConsulta.CurrentRow.Cells[1].Value.ToString();
            try
            {
                cursodto.Id_curso = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());

                int x = cursomodel.ExcluirCurso(cursodto);

                if (x > 0)
                {
                    MessageBox.Show("O curso " + cursocons + ", foi excluido com sucesso !!!", "Concluido",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Carrega_grid();
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o curso " + cursocons, "ERROR",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possive executar a operação", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
