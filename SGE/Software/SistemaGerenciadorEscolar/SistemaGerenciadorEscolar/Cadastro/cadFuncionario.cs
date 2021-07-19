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
    public partial class cadFuncionario : MetroForm
    {
        public cadFuncionario()
        {
            InitializeComponent();
        }

        string sexo;
        int tipofunc;
        //CAMADAS FUNCIONARIO DTO E MODEL
        Camadas.DTO.FuncionarioDTO funcdto = new Camadas.DTO.FuncionarioDTO();
        Camadas.Model.FuncionarioModel funcmodel = new Camadas.Model.FuncionarioModel();
       
        private void cadFuncionario_Load(object sender, EventArgs e)
        {
            Carregar_Grid();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cadastro Cadastro = new Cadastro();
            Cadastro.Show();
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar_campos();
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
            mskTelefone.Clear();
            mskCelular.Clear();
            txtEmail.Clear();
            picImage.Image = null;
            txtCurriculum.Clear();
            mskDataAdmissao.Clear();
        }
        public Boolean VerificarCampos()
        {
            if (txtNome.Text == "" || rdbMasc.Checked == false || rdbFem.Checked == false ||
                mskDataNasc.Text == "" || txtLogra.Text == "" || txtBairro.Text == "" ||
                txtCidade.Text == "" || txtNum.Text == "" || cmbUF.SelectedIndex == -1 ||
                mskRG.Text == "" || mskCPF.Text == "" || mskTelefone.Text == "" ||
                mskCelular.Text == "" ||txtCurriculum.Text == "" || mskDataAdmissao.Text == "" || 
                txtEmail.Text == "" || picImage.ImageLocation == null )
            {              
                    Mensagens(4);
                    return true;
            }
            else
            {
                return false;
            }
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string funcionariocons = dgvConsulta.CurrentRow.Cells[1].Value.ToString();

            Autenticar_Sexo();
            funcdto.Id_func = Convert.ToInt16(dgvConsulta.CurrentRow.Cells[0].Value);
            funcdto.Nome_func = txtNome.Text;
            funcdto.Sexo_func = sexo;
            funcdto.Data_nascimento_func = mskDataNasc.Text; 
            funcdto.Logra_func =  txtLogra.Text;
            funcdto.Bairro_func = txtBairro.Text;
            funcdto.Cidade_func =  txtCidade.Text;
            funcdto.Numero_casa_func =  txtNum.Text;
            funcdto.Uf_func =  cmbUF.Text;
            funcdto.Comp_logra_func =  txtComplemento.Text;
            funcdto.Rg_func =  mskRG.Text;
            funcdto.Cpf_func =  mskCPF.Text;
            funcdto.Tel_func =  mskTelefone.Text;
            funcdto.Cel_func = mskCelular.Text;
            funcdto.Email_func = txtEmail.Text;
            funcdto.Foto_func = picImage.ImageLocation;
            funcdto.Curriculum_func =  txtCurriculum.Text;
            funcdto.Data_admissao_func = mskDataAdmissao.Text;

            int x = funcmodel.AlterarFuncionario(funcdto);

            if (x > 0)
            {
                Mensagens(2);
                Limpar_campos();
                Carregar_Grid();
            }
            else
            {
                Mensagens(5);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string funcionariocons = dgvConsulta.CurrentRow.Cells[1].Value.ToString();

            funcdto.Id_func = Convert.ToInt16(dgvConsulta.CurrentRow.Cells[0].Value.ToString());

            int x = funcmodel.ExcluirFuncionario(funcdto);

            if (x > 0)
            {
                Mensagens(3);
                Limpar_campos();
                Carregar_Grid();
            }
            else
            {
                Mensagens(5);
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
            mskRG.Text = dgvConsulta.CurrentRow.Cells[10].Value.ToString();
            mskCPF.Text = dgvConsulta.CurrentRow.Cells[11].Value.ToString();
            mskTelefone.Text = dgvConsulta.CurrentRow.Cells[12].Value.ToString();
            mskCelular.Text = dgvConsulta.CurrentRow.Cells[13].Value.ToString();
            txtEmail.Text = dgvConsulta.CurrentRow.Cells[14].Value.ToString();
            picImage.ImageLocation = dgvConsulta.CurrentRow.Cells[15].Value.ToString();
            txtCurriculum.Text = dgvConsulta.CurrentRow.Cells[16].Value.ToString();
            mskDataAdmissao.Text = dgvConsulta.CurrentRow.Cells[17].Value.ToString();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {            
                Autenticar_Sexo();
                funcdto.Nome_func = txtNome.Text;
                funcdto.Sexo_func = sexo;
                funcdto.Data_nascimento_func = mskDataNasc.Text;
                funcdto.Logra_func = txtLogra.Text;
                funcdto.Bairro_func = txtBairro.Text;
                funcdto.Cidade_func = txtCidade.Text;
                funcdto.Numero_casa_func = txtNum.Text;
                funcdto.Uf_func = cmbUF.Text;
                funcdto.Comp_logra_func = txtComplemento.Text;
                funcdto.Rg_func = mskRG.Text;
                funcdto.Cpf_func = mskCPF.Text;
                funcdto.Tel_func = mskTelefone.Text;
                funcdto.Cel_func = mskCelular.Text;
                funcdto.Email_func = txtEmail.Text;
                funcdto.Foto_func = picImage.ImageLocation;
                funcdto.Curriculum_func = txtCurriculum.Text;
                funcdto.Data_admissao_func = mskDataAdmissao.Text;

                int x = funcmodel.IncluirFuncionario(funcdto);

                if (x > 0)
                {
                    Mensagens(1);
                    Limpar_campos();
                    Carregar_Grid();
                }
                else
                {
                    Mensagens(5);
                }
              
        }
        private void Carregar_Grid()
        {
            IList<Camadas.DTO.FuncionarioDTO> listafunc = new List<Camadas.DTO.FuncionarioDTO>();
            {
                listafunc = new Camadas.Model.FuncionarioModel().ConsultaFuncionario();
                dgvConsulta.AutoGenerateColumns = false;
                dgvConsulta.DataSource = listafunc;
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
       
        private void Mensagens(int opcao)
        {
            if (opcao == 1)
            {
                 MessageBox.Show("O Funcionario " + txtNome.Text + ", foi incluido com sucesso !!!", "Concluido",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (opcao == 2)
            {
                MessageBox.Show("O Funcionario " + txtNome.Text + ", foi alterado com sucesso !!!", "Concluido",
                       MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                
            }
            else if (opcao == 3)
            {
                MessageBox.Show("O Funcionario " + txtNome.Text + ", foi excluido com sucesso !!!", "Concluido",
                      MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                
            }
            else if(opcao == 4)
            {
                MessageBox.Show("Os Campos Não Estão Preenchidos", "Alerta", MessageBoxButtons.OK,
                         MessageBoxIcon.Exclamation);  
            }
            else if (opcao == 5)
            {
                MessageBox.Show("Não foi possível inserir este funcionario.", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            picImage.ImageLocation = ofd.FileName;
        }        
    }
}
