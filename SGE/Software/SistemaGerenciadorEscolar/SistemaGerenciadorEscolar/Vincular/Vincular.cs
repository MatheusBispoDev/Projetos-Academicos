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

namespace SistemaGerenciadorEscolar.Vincular
{
    public partial class Vincular : MetroForm
    {
        public Vincular()
        {
            InitializeComponent();
        }

        private void Vincular_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SistemaGerenciadorEscolar sge = new SistemaGerenciadorEscolar();
            sge.Show();
            this.Hide();
        }

        private void tileDisc_Curso_Click(object sender, EventArgs e)
        {
            Disciplina_Curso disc_curso = new Disciplina_Curso();
            disc_curso.Show();
            this.Hide();
        }

        private void tileClasse_Aluno_Click(object sender, EventArgs e)
        {
            Classe_Aluno classe_aluno = new Classe_Aluno();
            classe_aluno.Show();
            this.Hide();
        }

        private void tileProf_Curso_Disc_Click(object sender, EventArgs e)
        {
            Professor_Disc_Curso prof_disc_curso = new Professor_Disc_Curso();
            prof_disc_curso.Show();
            this.Hide();
        }
    }
}
