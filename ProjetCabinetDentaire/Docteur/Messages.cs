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
    public partial class Messages : Form
    {
        public Messages()
        {
            InitializeComponent();
        }

        private void BoxReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Messages_Load(object sender, EventArgs e)
        {

        }
    }
}
