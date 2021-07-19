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
    public partial class Professor_Disc_Curso : MetroForm
    {
        public Professor_Disc_Curso()
        {
            InitializeComponent();
        }

        Camadas.DTO.Prof_Disc_CursoDTO prof_disc_cursodto = new Camadas.DTO.Prof_Disc_CursoDTO();
        Camadas.Model.Prof_Disc_CursoModel prof_disc_cursomodel = new Camadas.Model.Prof_Disc_CursoModel();
        private void Professor_Disc_Curso_Load(object sender, EventArgs e)
        {
            Carregar_Grid_Prof_Disc_Curso();
            Carregar_Combox_Prof();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Vincular vinc = new Vincular();
            vinc.Show();
            this.Hide();
        }
        private void Carregar_Combox_Prof()
        {
            IList<Camadas.DTO.ProfessorDTO> listaprof = new List<Camadas.DTO.ProfessorDTO>();
            {
                listaprof = new Camadas.Model.ProfessorModel().ConsultarProfessor();
                cmbProf.DataSource = listaprof;
                cmbProf.DisplayMember = "nome_prof";
                cmbProf.ValueMember = "id_prof";
                cmbProf.Refresh();
            }
        }
        private void Carregar_Grid_Disc_Curso()
        {
            IList<Camadas.DTO.Disc_CursoDTO> listadisc_curso = new List<Camadas.DTO.Disc_CursoDTO>();
            {
                listadisc_curso = new Camadas.Model.Disc_CursoModel().ConsultarDisc_Curso();
                dgvConsulta.AutoGenerateColumns = false;
                dgvConsulta.DataSource = listadisc_curso;                
            }
        }
        private void Carregar_Grid_Prof_Disc_Curso()
        {
            IList<Camadas.DTO.Prof_Disc_CursoDTO> listaprof_disc_curso = new List<Camadas.DTO.Prof_Disc_CursoDTO>();
            {
                listaprof_disc_curso = new Camadas.Model.Prof_Disc_CursoModel().ConsultarProf_Disc_Curso();
                dgvConsulta.AutoGenerateColumns = false;
                dgvConsulta.DataSource = listaprof_disc_curso;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            prof_disc_cursodto.Id_prof = Convert.ToInt32(cmbProf.SelectedValue);
            prof_disc_cursodto.Id_disc_curso = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());

            int x = prof_disc_cursomodel.IncluirProf_Disc_Curso(prof_disc_cursodto);
            if (x > 0)
            {
                MessageBox.Show("O Professor " + cmbProf.Text + ", foi vinculada no Curso e na Disciplina com sucesso", "Concluido",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Carregar_Grid_Prof_Disc_Curso();
            }
            else
            {
                MessageBox.Show("Não foi possível vincular este professor.", "ERROR",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            prof_disc_cursodto.Id_prof_curso = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());
            prof_disc_cursodto.Id_prof = Convert.ToInt32(cmbProf.SelectedValue);
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            prof_disc_cursodto.Id_prof_curso = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value.ToString());

            int x = prof_disc_cursomodel.ExcluirProf_Disc_Curso(prof_disc_cursodto);

            if (x > 0)
            {
                MessageBox.Show("O professor foi desvinculada com sucesso !!!", "Concluido",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Carregar_Grid_Prof_Disc_Curso();
            }
            else
            {
                MessageBox.Show("Não foi possível desvincular este professor ", "ERROR",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbProf.Text = dgvConsulta.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
