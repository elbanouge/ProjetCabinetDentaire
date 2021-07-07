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
    public partial class Consultation : Form
    {
        public Consultation()
        {
            InitializeComponent();
        }

        private void Consultation_Load(object sender, EventArgs e)
        {

        }

        private void BoxReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            NouveauConsultation nouveauConsultation = new NouveauConsultation();
            nouveauConsultation.FormBorderStyle = FormBorderStyle.None;
            nouveauConsultation.ShowDialog();
        }

        private void ButtonOrd_Click(object sender, EventArgs e)
        {
            try
            {
                Ordonnance ordonnance = new Ordonnance();
                ordonnance.FormBorderStyle = FormBorderStyle.None;
                ordonnance.ShowDialog();
                ordonnance.StartPosition = FormStartPosition.CenterParent;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonServ_Click(object sender, EventArgs e)
        {
            try
            {
                ServicesEmp services = new ServicesEmp();
                services.FormBorderStyle = FormBorderStyle.None;
                services.StartPosition = FormStartPosition.CenterParent;
                services.ShowDialog();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
