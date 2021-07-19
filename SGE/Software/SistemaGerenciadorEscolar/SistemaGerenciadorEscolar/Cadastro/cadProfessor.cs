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
    public partial class cadProfessor : MetroForm
    {
        public cadProfessor()
        {
            InitializeComponent();
        }

        string sexo;
        Camadas.DTO.ProfessorDTO profdto = new Camadas.DTO.ProfessorDTO();
        Camadas.Model.ProfessorModel profmodel = new Camadas.Model.ProfessorModel();
        private void cadProfessor_Load(object sender, EventArgs e)
        {
            Carrega_Grid();
        }
        private void Limpar_campos()
        {
            txtNome.Clear();
            rdbMasc.Checked = false;
            rdbFem.Checked = false;
            mskDataNasc.Clear();
            txtLogra.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtNum.Clear();
            cmbUF.SelectedIndex = -1;
            txtComplemento.Clear();
            mskRG.Clear();
            mskCPF.Clear();
            mskCelular.Clear();
            mskTelefone.Clear();
            txtCurriculum.Clear();
            mskDataAdmissao.Clear();
            picImage.Image = null;
        }
        public Boolean VerificarCampos()
        {
            if (txtNome.Text == "" || rdbMasc.Checked == false || rdbFem.Checked == false ||
                mskDataNasc.Text == "" || txtLogra.Text == "" || txtBairro.Text == "" ||
                txtCidade.Text == "" || txtNum.Text == "" || cmbUF.SelectedIndex == -1 ||
                mskRG.Text == "" || mskCPF.Text == "" || mskCelular.Text == "" ||
                mskTelefone.Text == "")
            {
                if (txtCurriculum.Text == "" || mskDataAdmissao.Text == "")
                {
                    MessageBox.Show("Os Campos Não Estão Preenchidos", "Alerta", MessageBoxButtons.OK,
                         MessageBoxIcon.Exclamation);
                    return true;
                }
                MessageBox.Show("Os Campos Não Estão Preenchidos", "Alerta", MessageBoxButtons.OK,
                         MessageBoxIcon.Exclamation);
                return true;
            }
            else
            {
                return false;
            }
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            profdto.Nome_prof = txtNome.Text;
            profdto.Sexo_prof = rdbMasc.Text;
            profdto.Data_nascimento_prof = mskDataNasc.Text;
            profdto.Logra_prof = txtLogra.Text;
            profdto.Bairro_prof = txtBairro.Text;
            profdto.Cidade_prof = txtCidade.Text;
            profdto.Numero_casa_prof = txtNum.Text;
            profdto.Uf_prof = cmbUF.Text;
            profdto.Comp_logra_prof = txtComplemento.Text;
            profdto.Rg_prof = mskCPF.Text;
            profdto.Cpf_prof = mskRG.Text;
            profdto.Tel_prof = mskTelefone.Text;
            profdto.Cel_prof = mskCelular.Text;
            profdto.Email_prof = txtEmail.Text;
            profdto.Foto_prof = picImage.ImageLocation;
            profdto.Curriculum_prof = txtCurriculum.Text;
            profdto.Data_admissao_prof = mskDataAdmissao.Text;

            int x = profmodel.IncluirProfessor(profdto);
            if (x > 0)
            {
                MessageBox.Show("O Professor " + txtNome.Text + ", foi incluido com sucesso !!!", "Concluido",
                       MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Limpar_campos();
                Carrega_Grid();
            }
            else
            {
                MessageBox.Show("Não foi possível inserir este funcionario.", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
        private void Carrega_Grid()
        {
            IList<Camadas.DTO.ProfessorDTO> listaprof = new List<Camadas.DTO.ProfessorDTO>();
            listaprof = new Camadas.Model.ProfessorModel().ConsultarProfessor();
            dgvConsulta.AutoGenerateColumns = false;
            dgvConsulta.DataSource = listaprof;
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            picImage.ImageLocation = ofd.FileName;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string profcons = dgvConsulta.CurrentRow.Cells[1].Value.ToString();

            profdto.Id_prof = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());

            Autenticar_Sexo();
            profdto.Nome_prof = txtNome.Text;
            profdto.Sexo_prof = sexo;
            profdto.Data_nascimento_prof = mskDataNasc.Text;
            profdto.Logra_prof = txtLogra.Text;
            profdto.Bairro_prof = txtBairro.Text;
            profdto.Cidade_prof = txtCidade.Text;
            profdto.Numero_casa_prof = txtNum.Text;
            profdto.Uf_prof = cmbUF.Text;
            profdto.Comp_logra_prof = txtComplemento.Text;
            profdto.Rg_prof = mskCPF.Text;
            profdto.Cpf_prof = mskRG.Text;
            profdto.Tel_prof = mskTelefone.Text;
            profdto.Cel_prof = mskCelular.Text;
            profdto.Email_prof = txtEmail.Text;
            profdto.Foto_prof = picImage.ImageLocation;
            profdto.Curriculum_prof = txtCurriculum.Text;
            profdto.Data_admissao_prof = mskDataAdmissao.Text;

            int x = profmodel.AlterarProfessor(profdto);
            if (x > 0)
            {
                MessageBox.Show("O Professor " + txtNome.Text + ", foi alterado com sucesso !!!", "Concluido",
                       MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Limpar_campos();
                Carrega_Grid();
            }
            else
            {
                MessageBox.Show("Não foi possível alterar este Professor.", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cadastro Cadastro = new Cadastro();
            Cadastro.Show();
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string profcons = dgvConsulta.CurrentRow.Cells[1].Value.ToString();

            profdto.Id_prof = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());

            int x = profmodel.ExcluirProfessor(profdto);

            if(x > 0)
            {
                MessageBox.Show("O Professor " + profcons + ", foi excluido com sucesso !!!", "Concluido",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Carrega_Grid();
            }
            else
            {
                MessageBox.Show("Não foi possível excluir o Professor " + profcons, "ERROR",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
            txtLogra.Text = dgvConsulta.CurrentRow.Cells[4].Value.ToString();
            txtBairro.Text = dgvConsulta.CurrentRow.Cells[5].Value.ToString();
            cmbUF.Text = dgvConsulta.CurrentRow.Cells[6].Value.ToString();
            txtCidade.Text = dgvConsulta.CurrentRow.Cells[7].Value.ToString();
            txtComplemento.Text = dgvConsulta.CurrentRow.Cells[8].Value.ToString();
            txtNum.Text = dgvConsulta.CurrentRow.Cells[9].Value.ToString();
            mskCPF.Text = dgvConsulta.CurrentRow.Cells[10].Value.ToString();
            mskRG.Text = dgvConsulta.CurrentRow.Cells[11].Value.ToString();
            mskTelefone.Text = dgvConsulta.CurrentRow.Cells[12].Value.ToString();
            mskCelular.Text = dgvConsulta.CurrentRow.Cells[13].Value.ToString();
            txtEmail.Text = dgvConsulta.CurrentRow.Cells[14].Value.ToString();
            picImage.ImageLocation = dgvConsulta.CurrentRow.Cells[15].Value.ToString();
            txtCurriculum.Text = dgvConsulta.CurrentRow.Cells[16].Value.ToString();
            mskDataAdmissao.Text = dgvConsulta.CurrentRow.Cells[17].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar_campos();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
