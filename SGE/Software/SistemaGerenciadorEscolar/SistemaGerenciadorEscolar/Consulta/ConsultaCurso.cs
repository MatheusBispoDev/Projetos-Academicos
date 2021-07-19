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
    public partial class ConsultaCurso : MetroForm
    {
        public ConsultaCurso()
        {
            InitializeComponent();
        }

        Camadas.DTO.CursoDTO cursodto = new Camadas.DTO.CursoDTO();
        Camadas.Model.CursoModel cursomodel = new Camadas.Model.CursoModel();
        private void ConsultaCurso_Load(object sender, EventArgs e)
        {
            Carrega_grid();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CONSULTACURSO" E ABRE O FORM "CONSULTA"
            Consulta Consulta = new Consulta();
            Consulta.Show();
            this.Close();
        }
        private void Carrega_grid()
        {
            try
            {
                IList<Camadas.DTO.CursoDTO> listacurso = new List<Camadas.DTO.CursoDTO>();
                {
                    listacurso = new Camadas.Model.CursoModel().ConsultarCurso();
                    dgvConsulta.AutoGenerateColumns = false;
                    dgvConsulta.DataSource = listacurso;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os dados do curso" + erro.Message);
            }
        }
        private void BuscarCurso_Grid()
        {
            IList<Camadas.DTO.CursoDTO> listacurso = new List<Camadas.DTO.CursoDTO>();
            {
                cursodto.Curso = txtCurso.Text;
                listacurso = new Camadas.Model.CursoModel().BuscarCurso(cursodto);
                dgvConsulta.AutoGenerateColumns = false;
                dgvConsulta.DataSource = listacurso;
            }
        }

        private void txtCurso_TextChanged(object sender, EventArgs e)
        {
            BuscarCurso_Grid();
        }
    }
}
