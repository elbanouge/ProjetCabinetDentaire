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
    public partial class Logo : Form
    {
        public Logo()
        {
            InitializeComponent();
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("dddd MM MMMM yyyy");
            labelHeure.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Logo_Load(object sender, EventArgs e)
        {

        }
    }
}
