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
    public partial class ConsultaClasse : MetroForm
    {
        public ConsultaClasse()
        {
            InitializeComponent();
        }
        Camadas.DTO.ClasseDTO classedto = new Camadas.DTO.ClasseDTO();
        Camadas.Model.ClasseModel classemodel = new Camadas.Model.ClasseModel();       
        private void ConsultaClasse_Load(object sender, EventArgs e)
        {
            Carregar_Grid();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CONSULTACLASE" E ABRE O FORM "CONSULTA"
            Consulta Consulta = new Consulta();
            Consulta.Show();
            this.Close();
        }
        private void BuscarClasse_Grid()
        {
            IList<Camadas.DTO.ClasseDTO> listaclasse = new List<Camadas.DTO.ClasseDTO>();
            {
                classedto.Classe = txtClasse.Text;
                listaclasse = new Camadas.Model.ClasseModel().BuscarClasse(classedto);
                dgvConsulta.AutoGenerateColumns = false;
                dgvConsulta.DataSource = listaclasse;
            }
        }
        private void Carregar_Grid()
        {
            IList<Camadas.DTO.ClasseDTO> listaclasse = new List<Camadas.DTO.ClasseDTO>();
            {
                listaclasse = new Camadas.Model.ClasseModel().ConsultarClasse();
                dgvConsulta.AutoGenerateColumns = false;
                dgvConsulta.DataSource = listaclasse;
            }
        }

        private void txtClasse_TextChanged(object sender, EventArgs e)
        {
            BuscarClasse_Grid();
        }
    }
}
