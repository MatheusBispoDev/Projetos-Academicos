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
    public partial class ConsultaAluno : MetroForm
    {
        public ConsultaAluno()
        {
            InitializeComponent();
        }

        Camadas.DTO.AlunoDTO alunodto = new Camadas.DTO.AlunoDTO();
        Camadas.Model.AlunoModel alunomodel = new Camadas.Model.AlunoModel();
        private void ConsultaAluno_Load(object sender, EventArgs e)
        {
            Carregar_Grid();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CONSULTAALUNO" E ABRE O FORM "CONSULTA"
            Consulta Consulta = new Consulta();
            Consulta.Show();
            this.Close();
        }
        private void Carregar_Grid()
        {
            IList<Camadas.DTO.AlunoDTO> listaaluno = new List<Camadas.DTO.AlunoDTO>();
            {
                listaaluno = new Camadas.Model.AlunoModel().ConsultarAluno();
                dgvConsulta.AutoGenerateColumns = true;
                dgvConsulta.DataSource = listaaluno;
            }
        }
        private void BuscarNome_Grid()
        {
            IList<Camadas.DTO.AlunoDTO> listaaluno = new List<Camadas.DTO.AlunoDTO>();
            {
                alunodto.Nome_aluno = txtNome.Text;
                listaaluno = new Camadas.Model.AlunoModel().BuscarAlunoNome(alunodto);
                dgvConsulta.DataSource = listaaluno;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome_Grid();
        }
    }
}
