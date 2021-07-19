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
    public partial class Mencao : MetroForm
    {
        public Mencao()
        {
            InitializeComponent();
        }

        string data;   
        private void Mencao_Load(object sender, EventArgs e)
        {
            Carregar_Combox_Classe();
            Carregar_Combox_Disc();
            data = Convert.ToString(DateTime.Today.ToString("dd/MM/yyyy"));
            dgvMencao.Columns[1].HeaderText = data;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "MENCAO" E ABRE O FORM "PROFESSOR"
            Professor Professor = new Professor();
            Professor.Show();
            this.Close();
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
        private void Carregar_Combox_Classe()
        {
            IList<Camadas.DTO.ClasseDTO> listaclasse = new List<Camadas.DTO.ClasseDTO>();
            listaclasse = new Camadas.Model.ClasseModel().ConsultarClasse();
            cmbClasse.DataSource = listaclasse;
            cmbClasse.DisplayMember = "classe";
            cmbClasse.ValueMember = "id_classe";
            cmbClasse.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Carregar_Grid();
        }
        private void Carregar_Grid()
        {
            IList<Camadas.DTO.AlunoDTO> listaaluno = new List<Camadas.DTO.AlunoDTO>();
            {
                listaaluno = new Camadas.Model.AlunoModel().ConsultarAluno();
                dgvMencao.AutoGenerateColumns = false;
                dgvMencao.DataSource = listaaluno;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Infelizmente esta operação ainda não foi implementada...", "OPS...",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
