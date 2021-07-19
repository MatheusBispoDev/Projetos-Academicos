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
    public partial class Sobre : MetroForm
    {
        public Sobre()
        {
            InitializeComponent();
        }

        private void Sobre_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //FECHA O FORM "SOBRE" E ABRE O FORM "SISTEMAGERENCIADORESCOLAR"
            SistemaGerenciadorEscolar SGE = new SistemaGerenciadorEscolar();
            SGE.Show();
            this.Close();
        }
    }
}
