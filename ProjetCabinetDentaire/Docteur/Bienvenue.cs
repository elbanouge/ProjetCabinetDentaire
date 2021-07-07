using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCabinetDentaire.Docteur
{
    public partial class Bienvenue : Form
    {
        public Bienvenue()
        {
            InitializeComponent();
        }

        private void Bienvenue_Load(object sender, EventArgs e)
        {
            timerBn.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CircleProgressBar.Value == 100)
            {
                timerBn.Stop();
                Principal pr = new Principal();
                this.Hide();
                pr.Show();
            }
            else
            {
                CircleProgressBar.Value += 1;
                gunaLabelVal.Text = (Convert.ToInt32(gunaLabelVal.Text) + 1).ToString();
            }
        }
    }
}
