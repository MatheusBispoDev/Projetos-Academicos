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

namespace SistemaGerenciadorEscolar.Splash
{
    public partial class Splash : MetroForm
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (metroProgressSpinner1.Value < 100)
            {
                metroProgressSpinner1.Value = metroProgressSpinner1.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                Login Login = new Login();
                Login.ShowDialog();
            }
        }
    }
}
