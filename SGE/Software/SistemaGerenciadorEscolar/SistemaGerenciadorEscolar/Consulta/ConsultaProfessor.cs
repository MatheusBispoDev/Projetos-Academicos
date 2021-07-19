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
    public partial class ConsultaProfessor : MetroForm
    {
        public ConsultaProfessor()
        {
            InitializeComponent();
        }

        Camadas.DTO.ProfessorDTO profdto = new Camadas.DTO.ProfessorDTO();
        Camadas.Model.ProfessorModel profmodel = new Camadas.Model.ProfessorModel();
        private void ConsultaProfessor_Load(object sender, EventArgs e)
        {
            Carrega_Grid();
        }
        private void Carrega_Grid()
        {
            IList<Camadas.DTO.ProfessorDTO> listaprof = new List<Camadas.DTO.ProfessorDTO>();
            listaprof = new Camadas.Model.ProfessorModel().ConsultarProfessor();
            dgvConsulta.AutoGenerateColumns = false;
            dgvConsulta.DataSource = listaprof;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.Show();
            this.Hide();
        }
        private void Buscar_Grid()
        {
            IList<Camadas.DTO.ProfessorDTO> listaprof = new List<Camadas.DTO.ProfessorDTO>();
            {
                profdto.Nome_prof = txtNome.Text;
                listaprof = new Camadas.Model.ProfessorModel().BuscarProfNome(profdto);
                dgvConsulta.DataSource = listaprof;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            Buscar_Grid();
        }
    }
}
