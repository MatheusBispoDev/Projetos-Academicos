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
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            AutenticarUsuario();   
        }

        private void btnAcessar_Enter(object sender, EventArgs e)
        {
            AutenticarUsuario();
        }

        private void AutenticarUsuario()
        {
            Camadas.DTO.UsuarioDTO usuariodto = new Camadas.DTO.UsuarioDTO();
            usuariodto.Login = txtUsuario.Text;
            usuariodto.Senha = txtSenha.Text;

            usuariodto = new Camadas.Model.UsuarioModel().AutenticarUsuario(usuariodto);
            if (usuariodto.Login == null)
            {
                MessageBox.Show("Usuario ou senha inválidos !!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (usuariodto.Tipo_usu == 1)
                {
                    MessageBox.Show("Bem vindo Secretário(a), " + txtUsuario.Text, "BEM VINDO AO SGE", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                }
                else if (usuariodto.Tipo_usu == 2)
                {
                    MessageBox.Show("Bem vindo Coordenador(a)," + txtUsuario.Text, "BEM VINDO AO SGE", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                }
                else if (usuariodto.Tipo_usu == 3)
                {
                    MessageBox.Show("Bem vindo Professor(a)" + txtUsuario.Text, "BEM VINDO AO SGE", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                }
                //FECHA O FORM "LOGIN" E ABRE O FORM "SISTEMAGERENCIADORESCOLAR"
                SistemaGerenciadorEscolar SGE = new SistemaGerenciadorEscolar();
                SGE.Show();
                this.Hide();
            }  
        }
    }
}