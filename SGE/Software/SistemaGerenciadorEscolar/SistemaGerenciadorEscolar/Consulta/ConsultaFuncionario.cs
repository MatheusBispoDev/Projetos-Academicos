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
    public partial class ConsultaFuncionario : MetroForm
    {
        public ConsultaFuncionario()
        {
            InitializeComponent();
        }

        Camadas.DTO.FuncionarioDTO funcdto = new Camadas.DTO.FuncionarioDTO();
        Camadas.Model.FuncionarioModel funcmodel = new Camadas.Model.FuncionarioModel();
        private void ConsultaFuncionario_Load(object sender, EventArgs e)
        {
            Carregar_Grid();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "CONSULTAFUNCIONARIO" E ABRE O FORM "CONSULTA"
            Consulta Consulta = new Consulta();
            Consulta.Show();
            this.Close();
        }
        private void Carregar_Grid()
        {
            IList<Camadas.DTO.FuncionarioDTO> listafunc = new List<Camadas.DTO.FuncionarioDTO>();
            {
                listafunc = new Camadas.Model.FuncionarioModel().ConsultaFuncionario();
                dgvConsulta.AutoGenerateColumns = false;
                dgvConsulta.DataSource = listafunc;
            }
        }
        private void BuscarNome_Grid()
        {
            IList<Camadas.DTO.FuncionarioDTO> listafunc = new List<Camadas.DTO.FuncionarioDTO>();
            {
                funcdto.Nome_func = txtFunc.Text;
                listafunc = new Camadas.Model.FuncionarioModel().BuscarFuncionarioNome(funcdto);
                dgvConsulta.DataSource = listafunc;
            }
        }      

        private void txtFunc_TextChanged(object sender, EventArgs e)
        {
            BuscarNome_Grid();
        }
    }
}
