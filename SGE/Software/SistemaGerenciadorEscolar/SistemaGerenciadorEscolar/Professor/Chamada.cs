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
    public partial class Chamada : MetroForm
    {
        public Chamada()
        {
            InitializeComponent();
        }

        string data;        
        private void Chamada_Load(object sender, EventArgs e)
        {
            Carregar_Combox_Classe();
            Carregar_Combox_Disc();
            data = Convert.ToString(DateTime.Today.ToString("dd/MM/yyyy"));            
            dgvChamada.Columns[1].HeaderText = data;            
        }

        private void Carregar_Grid()
        {
                IList<Camadas.DTO.AlunoDTO> listaaluno = new List<Camadas.DTO.AlunoDTO>();
                {
                    listaaluno = new Camadas.Model.AlunoModel().ConsultarAluno();
                    dgvChamada.AutoGenerateColumns = false;
                    dgvChamada.DataSource = listaaluno;
                }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Carregar_Grid();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Infelizmente esta operação ainda não foi implementada...", "OPS...",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CHAMADA" E ABRE O FORM "PROFESSOR"
            Professor Professor = new Professor();
            Professor.Show();
            this.Close();
        }
        
    }
}
