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
    public partial class Cadastro : MetroForm
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void tileUsuario_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CADASTRO" E ABRE O FORM "CADUSUARIO"
            cadUsuario CadastroUsuario = new cadUsuario();
            CadastroUsuario.Show();
            this.Hide();    
        }

        private void tileFuncionario_Click(object sender, EventArgs e)
        {            
            //FECHA O FORM "CADASTRO" E ABRE O FORM "CADFUNCIONARIO"
            cadFuncionario CadastroFuncionario = new cadFuncionario();
            CadastroFuncionario.Show();
            this.Hide();
        }

        private void tileDisciplina_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CADASTRO" E ABRE O FORM "CADDISCIPLINA"
            cadDisciplina CadastroDisciplina = new cadDisciplina();
            CadastroDisciplina.Show();
            this.Hide();
        }

        private void tileCurso_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CADASTRO" E ABRE O FORM "CADCURSO"
            cadCurso CadastroCurso = new cadCurso();
            CadastroCurso.Show();
            this.Hide();
        }

        private void tileClasse_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CADASTRO" E ABRE O FORM "CADCLASSE"
            cadClasse CadastroClasse = new cadClasse();
            CadastroClasse.Show();
            this.Hide();
        }

        private void tileAluno_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CADASTRO" E ABRE O FORM "CADALUNO"
            cadAluno CadastroAluno = new cadAluno();
            CadastroAluno.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CADASTRO" E ABRE O FORM "SISTEMAGERENCIADORESCOLAR"
            SistemaGerenciadorEscolar SGE = new SistemaGerenciadorEscolar();
            SGE.Show();
            this.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CADASTRO" E ABRE O FORM "CADPROFESSOR"
            cadProfessor CadastroProfessor = new cadProfessor();
            CadastroProfessor.Show();
            this.Hide();
        }
    }
}
