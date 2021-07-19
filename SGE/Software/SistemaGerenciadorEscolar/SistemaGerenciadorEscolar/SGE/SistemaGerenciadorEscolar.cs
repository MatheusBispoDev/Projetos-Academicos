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
    public partial class SistemaGerenciadorEscolar : MetroForm
    {
        public SistemaGerenciadorEscolar()
        {
            InitializeComponent();
        }

        private void SistemaGerenciadorEscolar_Load(object sender, EventArgs e)
        {

        }

        private void tileCadastro_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "SISTEMAGERENCIADORESCOLAR" E ABRE O FORM "CADASTRO"
            Cadastro Cadastro = new Cadastro();
            Cadastro.Show();
            this.Close();
        }

        private void tileConsulta_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "SISTEMAGERENCIADORESCOLAR" E ABRE O FORM "CONSULTA"
            Consulta Consulta = new Consulta();
            Consulta.Show();
            this.Close();
        }

        private void tileAreaProfessor_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "SISTEMAGERENCIADORESCOLAR" E ABRE O FORM "PROFESSOR"
            Professor Professor = new Professor();
            Professor.Show();
            this.Close();
        }

        private void tileSobre_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "SISTEMAGERENCIADORESCOLAR" E ABRE O FORM "SOBRE"
            Sobre Sobre = new Sobre();
            Sobre.Show();
            this.Close();
        }

        private void tileSair_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "SISTEMAGERENCIADORESCOLAR" E ABRE O FORM "LOGIN"
            Login Login = new Login();
            Login.Show();
            this.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Vincular.Vincular vinc = new Vincular.Vincular();
            vinc.Show();
            this.Hide();
        }
    }
}
