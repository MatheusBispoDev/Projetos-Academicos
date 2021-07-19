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
    public partial class Professor : MetroForm
    {
        public Professor()
        {
            InitializeComponent();
        }

        private void Professor_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "PROFESSOR" E ABRE O FORM "CHAMADA"
            Mencao Mencao = new Mencao();
            Mencao.Show();
            this.Hide();
        }

        private void tileChamada_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "PROFESSOR" E ABRE O FORM "CHAMADA"
            Chamada Chamada = new Chamada();
            Chamada.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "PROFESSOR" E ABRE O FORM "SISTEMAGERENCIADORESCOLAR"
            SistemaGerenciadorEscolar SGE = new SistemaGerenciadorEscolar();
            SGE.Show();
            this.Close();
        }
    }
}
