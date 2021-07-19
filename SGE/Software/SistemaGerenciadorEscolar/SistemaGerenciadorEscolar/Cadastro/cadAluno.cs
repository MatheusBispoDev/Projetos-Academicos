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
    public partial class cadAluno : MetroForm
    {
        public cadAluno()
        {
            InitializeComponent();
        }

        string sexo;
        Camadas.DTO.AlunoDTO alunodto = new Camadas.DTO.AlunoDTO();
        Camadas.Model.AlunoModel alunomodel = new Camadas.Model.AlunoModel();
        
        private void cadAluno_Load(object sender, EventArgs e)
        {
            Carregar_Grid();
        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            //FECHA O FORM "CADALUNO" E ABRE O FORM "CADASTRO"
            Cadastro Cadastro = new Cadastro();
            Cadastro.Show();
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
               
        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            txtHistorico.Text = ofd.FileName;
        }

        

        private void picAluno_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            picAluno.ImageLocation = ofd.FileName;
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Autenticar_Sexo();
                alunodto.Nome_aluno = txtNome.Text;
                alunodto.Sexo_aluno = sexo;
                alunodto.Data_nascimento_aluno = mskDataNasc.Text;
                alunodto.Bairro_aluno = txtBairro.Text;
                alunodto.Cidade_aluno = txtCidade.Text;
                alunodto.Logra_aluno = txtLogradouro.Text;
                alunodto.Uf_aluno = cmbUF.Text;
                alunodto.Comp_logra_aluno = txtComplemento.Text;
                alunodto.Numero_casa_aluno = txtNum.Text;
                alunodto.Rg_aluno = mskCPF.Text;
                alunodto.Cpf_aluno = mskRG.Text;
                alunodto.Tel_aluno = mskTelefone.Text;
                alunodto.Cel_aluno = mskCelular.Text;
                alunodto.Email_aluno = txtEmail.Text;
                alunodto.Foto_aluno = picAluno.ImageLocation;
                alunodto.Nome_resp_um = txtNomeResp1.Text;
                alunodto.Tel_resp_um = mskCelularResp.Text;
                alunodto.Cel_resp_um = mskTelResp1.Text;
                alunodto.Email_resp_um = txtEmailResp1.Text;
                alunodto.Rg_resp_um = mskCPFResp1.Text;
                alunodto.Cpf_resp_um = mskRGResp1.Text;
                alunodto.Hist_aluno = txtHistorico.Text;

                int x = alunomodel.IncluirAluno(alunodto);

                if (x > 0)
                {
                    MessageBox.Show("O aluno " + txtNome.Text + ", foi incluido com sucesso !!!", "Concluido",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LimparCampos();
                    Carregar_Grid();
                }
                else
                {
                    MessageBox.Show("Não foi possível inserir este aluno.", "ERROR",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível executar esse comando" + erro.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            rdbMasc.Checked = false;
            rdbFem.Checked = false;
            mskDataNasc.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtLogradouro.Text = "";
            cmbUF.SelectedIndex = -1;
            txtComplemento.Text = "";
            txtNum.Clear();
            mskRG.Text = "";
            mskCPF.Text = "";
            mskTelefone.Text = "";
            mskCelular.Text = "";
            txtEmail.Text = "";
            txtHistorico.Text = "";            
            picAluno.Image = null;
            txtNomeResp1.Clear();
            txtEmailResp1.Clear();
            mskCelularResp.Clear();
            mskTelResp1.Clear();
            mskRGResp1.Clear();
            mskCPFResp1.Clear();
        }

        private void dgvConsula_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsulta.CurrentRow.Cells[2].Value.ToString() == "Masculino" ||
                dgvConsulta.CurrentRow.Cells[2].Value.ToString() == "M")
            {
                rdbFem.Checked = false;
                rdbMasc.Checked = true;
            }
            else
            {
                rdbMasc.Checked = false;
                rdbFem.Checked = true;
            }

            txtNome.Text = dgvConsulta.CurrentRow.Cells[1].Value.ToString();
            mskDataNasc.Text = dgvConsulta.CurrentRow.Cells[3].Value.ToString();
            txtLogradouro.Text = dgvConsulta.CurrentRow.Cells[4].Value.ToString();
            txtBairro.Text = dgvConsulta.CurrentRow.Cells[5].Value.ToString();
            txtCidade.Text = dgvConsulta.CurrentRow.Cells[6].Value.ToString();
            txtComplemento.Text = dgvConsulta.CurrentRow.Cells[7].Value.ToString();
            txtNum.Text = dgvConsulta.CurrentRow.Cells[8].Value.ToString();
            cmbUF.Text = dgvConsulta.CurrentRow.Cells[9].Value.ToString();            
            mskRG.Text = dgvConsulta.CurrentRow.Cells[10].Value.ToString();
            mskCPF.Text = dgvConsulta.CurrentRow.Cells[11].Value.ToString();
            mskTelefone.Text = dgvConsulta.CurrentRow.Cells[12].Value.ToString();
            mskCelular.Text = dgvConsulta.CurrentRow.Cells[13].Value.ToString();
            txtEmail.Text = dgvConsulta.CurrentRow.Cells[14].Value.ToString();
            picAluno.ImageLocation = dgvConsulta.CurrentRow.Cells[15].Value.ToString();
            txtNomeResp1.Text = dgvConsulta.CurrentRow.Cells[16].Value.ToString();
            mskCelularResp.Text = dgvConsulta.CurrentRow.Cells[17].Value.ToString();
            mskTelResp1.Text = dgvConsulta.CurrentRow.Cells[18].Value.ToString();
            txtEmailResp1.Text = dgvConsulta.CurrentRow.Cells[19].Value.ToString();           
            mskCPFResp1.Text = dgvConsulta.CurrentRow.Cells[20].Value.ToString();
            mskRGResp1.Text = dgvConsulta.CurrentRow.Cells[21].Value.ToString();
            txtHistorico.Text = dgvConsulta.CurrentRow.Cells[22].Value.ToString();
        }
        private string Autenticar_Sexo()
        {
            if (rdbMasc.Checked)
            {
                sexo = "Masculino";
            }
            else if (rdbFem.Checked)
            {
                sexo = "Feminino";
            }
            return sexo;
        }
        private void VerificarCampos()
        {
                      
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }
        private void Carregar_Grid()
        {
            IList<Camadas.DTO.AlunoDTO> listaaluno = new List<Camadas.DTO.AlunoDTO>();
            {
                try
                {
                    listaaluno = new Camadas.Model.AlunoModel().ConsultarAluno();
                    dgvConsulta.AutoGenerateColumns = true;
                    dgvConsulta.DataSource = listaaluno;
                }
                catch(Exception erro)
                {
                    MessageBox.Show("Aconteceu um erro ao carregar" + erro.Message);

                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
           string alunocons = dgvConsulta.CurrentRow.Cells[1].Value.ToString();
            Autenticar_Sexo();
            int i = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show("s"+i);
            try
            {
                alunodto.Id_aluno = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());
                alunodto.Nome_aluno = txtNome.Text;
                alunodto.Sexo_aluno = sexo;
                alunodto.Data_nascimento_aluno = mskDataNasc.Text;
                alunodto.Logra_aluno = txtLogradouro.Text;
                alunodto.Bairro_aluno = txtBairro.Text;
                alunodto.Cidade_aluno = txtCidade.Text;
                alunodto.Comp_logra_aluno = txtComplemento.Text;
                alunodto.Numero_casa_aluno = txtNum.Text;
                alunodto.Uf_aluno = cmbUF.Text;        
                alunodto.Rg_aluno = mskCPF.Text;
                alunodto.Cpf_aluno = mskRG.Text;
                alunodto.Tel_aluno = mskTelefone.Text;
                alunodto.Cel_aluno = mskCelular.Text;
                alunodto.Email_aluno = txtEmail.Text;
                alunodto.Foto_aluno = picAluno.ImageLocation;
                alunodto.Nome_resp_um = txtNomeResp1.Text;
                alunodto.Tel_resp_um = mskTelResp1.Text;
                alunodto.Cel_resp_um = mskCelularResp.Text;
                alunodto.Email_resp_um = txtEmailResp1.Text;
                alunodto.Rg_resp_um = mskCPFResp1.Text;
                alunodto.Cpf_resp_um = mskRGResp1.Text;
                alunodto.Hist_aluno = txtHistorico.Text;

                int x = alunomodel.AlterarAluno(alunodto);
                if (x > 0)
                {
                    MessageBox.Show("O Aluno " + txtNome.Text + ", foi alterado com sucesso !!!", "Concluido",
                           MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LimparCampos();
                    Carregar_Grid();
                }
                else
                {
                    MessageBox.Show("Não foi possível alterar este aluno.", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível executar esse comando" + erro.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string alunocons = dgvConsulta.CurrentRow.Cells[1].Value.ToString();
            try
            {

                alunodto.Id_aluno = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());

                int x = alunomodel.ExcluirAluno(alunodto);

                if (x > 0)
                {
                    MessageBox.Show("O aluno " + alunocons + ", foi excluido com sucesso !!!", "Concluido",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Carregar_Grid();
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o aluno " + alunocons, "ERROR",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível executar esse comando" + erro.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();

            cadastro.Show();
            this.Hide();
        }
        /* private void txtNome_Validated(object sender, EventArgs e)
{
if(string.IsNullOrWhiteSpace(txtNome.Text) == true)
{
errorCadAluno.SetError(txtNome, "Campo Obrigatório");
}
else
{
errorCadAluno.SetError(txtNome, string.Empty);
}
} */
    }
 }

