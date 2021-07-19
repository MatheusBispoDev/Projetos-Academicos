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
    public partial class Disciplina_Curso : MetroForm
    {
        public Disciplina_Curso()
        {
            InitializeComponent();
        }

        Camadas.DTO.Disc_CursoDTO disc_cursodto = new Camadas.DTO.Disc_CursoDTO();
        Camadas.Model.Disc_CursoModel disc_cursomodel = new Camadas.Model.Disc_CursoModel();
        private void Disciplina_Curso_Load(object sender, EventArgs e)
        {
            Carregar_Grid();
            Carregar_Combox_Curso();
            Carregar_Combox_Disc();
        }

        private void dgvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbCurso.Text = dgvConsulta.CurrentRow.Cells[4].Value.ToString();
            cmbDisc.Text = dgvConsulta.CurrentRow.Cells[3].Value.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Vincular vinc = new Vincular();
            vinc.Show();
            this.Hide();
        }
        private void Carregar_Combox_Disc()
        {
            IList<Camadas.DTO.DisciplinaDTO> listadisc = new List<Camadas.DTO.DisciplinaDTO>();
            {
                listadisc = new Camadas.Model.DisciplinaModel().ConsultaDisciplina();
                cmbDisc.DataSource = listadisc;
                cmbDisc.DisplayMember = "disciplina";
                cmbDisc.ValueMember = "id_disc";
                cmbDisc.Refresh();
            }
        }
        private void Carregar_Combox_Curso()
        {
            IList<Camadas.DTO.CursoDTO> listacurso = new List<Camadas.DTO.CursoDTO>();
            {
                listacurso = new Camadas.Model.CursoModel().ConsultarCurso();
                cmbCurso.DataSource = listacurso;
                cmbCurso.DisplayMember = "curso";
                cmbCurso.ValueMember = "id_curso";
                cmbCurso.Refresh();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            disc_cursodto.Id_disc = Convert.ToInt32(cmbDisc.SelectedValue);
            disc_cursodto.Id_curso = Convert.ToInt32(cmbCurso.SelectedValue);

            int x = disc_cursomodel.IncluirDisc_Curso(disc_cursodto);

            if (x > 0)
            {
                MessageBox.Show("A Disciplina " + cmbDisc.Text + ", foi vinculada no Curso " + cmbCurso.Text, "Concluido",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Carregar_Grid();
            }
            else
            {
                MessageBox.Show("Não foi possível vincular esta disciplina.", "ERROR",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Carregar_Grid()
        {
            IList<Camadas.DTO.Disc_CursoDTO> listadisc_curso = new List<Camadas.DTO.Disc_CursoDTO>();
            {
                listadisc_curso = new Camadas.Model.Disc_CursoModel().ConsultarDisc_Curso();
                dgvConsulta.AutoGenerateColumns = true;
                dgvConsulta.DataSource = listadisc_curso;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            disc_cursodto.Id_disc_curso = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());

            int x = disc_cursomodel.ExcluirDisc_Curso(disc_cursodto);

            if (x > 0)
            {
                MessageBox.Show("A Disciplina foi desvinculada com sucesso !!!", "Concluido",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Carregar_Grid();
            }
            else
            {
                MessageBox.Show("Não foi possível desvincular esta Disciplina ", "ERROR",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            disc_cursodto.Id_disc_curso = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());
            disc_cursodto.Id_disc = Convert.ToInt32(cmbDisc.SelectedValue);
            disc_cursodto.Id_curso = Convert.ToInt32(cmbCurso.SelectedValue);

            int x = disc_cursomodel.AlterarDisc_Curso(disc_cursodto);

            if (x > 0)
            {
                MessageBox.Show("A Disciplina "+ cmbDisc.Text + "foi alterada com sucesso para o Curso "+ cmbCurso.Text, "Concluido",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Carregar_Grid();
            }
            else
            {
                MessageBox.Show("Não foi possível alterar esta Disciplina ", "ERROR",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
