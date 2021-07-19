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
    public partial class Consulta : MetroForm
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void tileFuncionarioC_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CONSULTA" E ABRE O FORM "CONSULTAFUNCIONARIO"
            ConsultaFuncionario ConsultaFuncionario = new ConsultaFuncionario();
            ConsultaFuncionario.Show();
            this.Hide();
        }

        private void tileDisciplinaC_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CONSULTA" E ABRE O FORM "CONSULTADISCIPLINA"
            ConsultaDisciplina ConsultaDisciplina = new ConsultaDisciplina();
            ConsultaDisciplina.Show();
            this.Hide();
        }

        private void tileCursoC_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CONSULTA" E ABRE O FORM "CONSULTACURSO"
            ConsultaCurso ConsultaCurso = new ConsultaCurso();
            ConsultaCurso.Show();
            this.Hide();
        }

        private void tileClasseC_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CONSULTA" E ABRE O FORM "CONSULTACLASSE"
            ConsultaClasse ConsultaClasse = new ConsultaClasse();
            ConsultaClasse.Show();
            this.Hide();
        }

        private void tileAlunoC_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CONSULTA" E ABRE O FORM "CONSULTAALUNO"
            ConsultaAluno ConsultaAluno = new ConsultaAluno();
            ConsultaAluno.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CONSULTA" E ABRE O FORM "SISTEMAGERENCIADORESCOLAR"
            SistemaGerenciadorEscolar SGE = new SistemaGerenciadorEscolar();
            SGE.Show();
            this.Close();
        }

        private void TileProfessorC_Click(object sender, EventArgs e)
        {
            ConsultaProfessor consprof = new ConsultaProfessor();
            consprof.Show();
            this.Hide();
        }
    }
}
