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
    public partial class ConsultaDisciplina : MetroForm
    {
        public ConsultaDisciplina()
        {
            InitializeComponent();
        }

        Camadas.DTO.DisciplinaDTO disciplinadto = new Camadas.DTO.DisciplinaDTO();
        Camadas.Model.DisciplinaModel disciplinamodel = new Camadas.Model.DisciplinaModel();
        private void ConsultaDisciplina_Load(object sender, EventArgs e)
        {
            Carregar_Grid();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CONSULTADISCIPLINA" E ABRE O FORM "CONSULTA"
            Consulta Consulta = new Consulta();
            Consulta.Show();
            this.Close();
        }

        private void txtDisc_TextChanged(object sender, EventArgs e)
        {
            Buscar_Grid();
        }
        private void Buscar_Grid()
        {
            IList<Camadas.DTO.DisciplinaDTO> listadisciplina = new List<Camadas.DTO.DisciplinaDTO>();
            {
                disciplinadto.Disciplina = txtDisc.Text;
                listadisciplina = new Camadas.Model.DisciplinaModel().BuscarDisciplina(disciplinadto);
                dgvDisc.DataSource = listadisciplina;
            }
        }
        private void Carregar_Grid()
        {
            try
            {
                IList<Camadas.DTO.DisciplinaDTO> listadisciplina = new List<Camadas.DTO.DisciplinaDTO>();
                {
                    listadisciplina = new Camadas.Model.DisciplinaModel().ConsultaDisciplina();
                    dgvDisc.AutoGenerateColumns = true;
                    dgvDisc.DataSource = listadisciplina;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os dados do usuario" + erro.Message);
            }
        }
    }
}
