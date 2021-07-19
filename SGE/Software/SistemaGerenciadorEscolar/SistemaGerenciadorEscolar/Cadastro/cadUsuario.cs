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
    public partial class cadUsuario : MetroForm
    {
        public cadUsuario()
        {
            InitializeComponent();

        }

        int tp;
        Camadas.DTO.UsuarioDTO usuariodto = new Camadas.DTO.UsuarioDTO();
        Camadas.Model.UsuarioModel usuariomodel = new Camadas.Model.UsuarioModel();

        private void cadUsuario_Load(object sender, EventArgs e)
        {
            Carrega_grid();
        }
        public int AutenticarTipoUsuario()
        {
            
            if (cmbTipoUsu.Text == "Secretaria")
            {
                tp = 1;
            }
            else if (cmbTipoUsu.Text == "Coordenação")
            {
                tp = 2;
            }
            else if (cmbTipoUsu.Text == "Professor")
            {
                tp = 3;
            }
            return tp;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CADUSUARIO" E ABRE O FORM "CADASTRO"
            Cadastro Cadastro = new Cadastro();
            Cadastro.Show();
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            AutenticarTipoUsuario();
            if (VerificarCampos() == true)
            {

            }
            else if (VerificarCampos() == false)
            {

                try
                {
                    usuariodto.Login = txtUsuario.Text;
                    usuariodto.Senha = txtSenha.Text;
                    usuariodto.Tipo_usu = tp;

                    int x = usuariomodel.IncluirUsuario(usuariodto);
                    if (x > 0)
                    {
                        MessageBox.Show("O usuário " + txtUsuario.Text + ", foi incluido com sucesso !!!", "Concluido",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Limpar_campos();
                        Carrega_grid();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível inserir este usuário.", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ocorreu um erro ao tentar cadastrar o usuario " + txtUsuario.Text, "ERROR",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void txtConfSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text != txtConfSenha.Text)
            {
                lblSenhas.Visible = true;                  
            }
            else
            {
                lblSenhas.Visible = false;
            }  
        }
        public void LimparCampos()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtConfSenha.Clear();
            cmbTipoUsu.SelectedIndex = -1;
        }
        public Boolean VerificarCampos()
        {
            if (txtUsuario.Text == "" || txtSenha.Text == "" || txtConfSenha.Text == "" || cmbTipoUsu.SelectedIndex == -1)
            {

                MessageBox.Show("Os Campos Não Estão Preenchidos", "Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return true;
            }
            else if (txtSenha.Text != txtConfSenha.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }        

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {           
            string usuariocons = dgvConsulta.CurrentRow.Cells[1].Value.ToString();
            if (VerificarCampos() == true)
                {

                }
                else if (VerificarCampos() == false)
                {
                    AutenticarTipoUsuario();
                    usuariodto.Id_usu = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());
                    usuariodto.Tipo_usu = tp;
                    usuariodto.Login = txtUsuario.Text;
                    usuariodto.Senha = txtSenha.Text;                    

                    int x = usuariomodel.AlterarUsuario(usuariodto);

                    if (x > 0)
                    {
                        MessageBox.Show("O usuário " + usuariocons + ", foi excluido com sucesso !!!", "Concluido",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Carrega_grid();
                        Limpar_campos();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível alterar o usuário " + usuariocons, "ERROR",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
         }
        

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string usuariocons = dgvConsulta.CurrentRow.Cells[1].Value.ToString();
            try
            {
                usuariodto.Id_usu = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());

                int x = usuariomodel.ExcluirUsuario(usuariodto);

                if (x > 0)
                {
                    MessageBox.Show("O usuário " + usuariocons + ", foi excluido com sucesso !!!", "Concluido",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Carrega_grid();
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o usuário " + usuariocons, "ERROR",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro ao tentar excluir o usuario " + usuariocons, "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Carrega_grid()
        {
            try
            {
                IList<Camadas.DTO.UsuarioDTO> listausuario = new List<Camadas.DTO.UsuarioDTO>();
                {
                    listausuario = new Camadas.Model.UsuarioModel().ConsultaUsuario();
                    dgvConsulta.AutoGenerateColumns = false;
                    dgvConsulta.DataSource = listausuario;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os dados do usuario" + erro.Message);
            }
        }
       
        private void Limpar_campos()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtConfSenha.Clear();
            cmbTipoUsu.SelectedIndex = -1;
        }

        private void dgvConsulta_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUsuario.Text = dgvConsulta.CurrentRow.Cells[1].Value.ToString();
            txtSenha.Text = dgvConsulta.CurrentRow.Cells[2].Value.ToString();
            txtConfSenha.Text = dgvConsulta.CurrentRow.Cells[2].Value.ToString();
            int cmb = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[3].Value.ToString());
            if (cmb == 1)
            {
                cmbTipoUsu.SelectedIndex = 0;
            }
            else if (cmb == 2)
            {
                cmbTipoUsu.SelectedIndex = 1;
            }
            else if (cmb == 3)
            {
                cmbTipoUsu.SelectedIndex = 2;
            }
        }
    }
}
