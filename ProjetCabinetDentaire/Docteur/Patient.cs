using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetCabinetDentaire.Docteur
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }
        Classes.Connection cnx = new Classes.Connection();
        public void RemlpirListePat()
        {
            try
            {
                var p = from pat in cnx.cabinet_Dentaire.paitent select new { pat.Photo_Pat, pat.Num_Dossier, pat.Prenom_Pat, pat.Nom_Pat, pat.CIN_Pass, pat.Date_Naissance_Pat, pat.Telephone_Pat };

                dataGridViewListePatients.Rows.Clear();
                foreach (var pat in p.ToList())
                {
                    dataGridViewListePatients.Rows.Add(pat.Photo_Pat, pat.Num_Dossier, pat.Prenom_Pat, pat.Nom_Pat, pat.CIN_Pass, pat.Date_Naissance_Pat.ToShortDateString(), pat.Telephone_Pat);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static int index = -1;
        private void Patient_Load(object sender, EventArgs e)
        {
            RemlpirListePat();
            labelNmPat.Text = dataGridViewListePatients.Rows.Count + "  Patients";
        }
        private void BoxReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                AjouterPat ajp = new AjouterPat();
                ajp.FormBorderStyle = FormBorderStyle.None;
                ajp.ShowDialog();
                if (AjouterPat.bl == true)
                {
                    RemlpirListePat();
                }
                labelNmPat.Text = dataGridViewListePatients.Rows.Count + "  Patients";

            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBoxAcc_Click(object sender, EventArgs e)
        {
            RemlpirListePat();
        }

        private void dataGridViewListePatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewListePatients.Rows.Count > 0)
                {
                    index = int.Parse(dataGridViewListePatients.CurrentRow.Cells[1].Value.ToString());
                    if (index != 0)
                    {
                        AfficherPat afficherPat = new AfficherPat();
                        afficherPat.FormBorderStyle = FormBorderStyle.None;
                        afficherPat.StartPosition = FormStartPosition.CenterScreen;
                        afficherPat.ShowDialog();
                        if (AfficherPat.bl == true)
                        {
                            RemlpirListePat();
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonMod_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewListePatients.Rows.Count > 0)
                {
                    index = int.Parse(dataGridViewListePatients.CurrentRow.Cells[1].Value.ToString());
                    if (index != 0)
                    {
                        AfficherPat afficherPat = new AfficherPat();
                        afficherPat.FormBorderStyle = FormBorderStyle.None;
                        afficherPat.StartPosition = FormStartPosition.CenterScreen;
                        afficherPat.ShowDialog();
                        if (AfficherPat.bl == true)
                        {
                            RemlpirListePat();
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonSupp_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewListePatients.Rows.Count > 0)
                {
                    if (MessageBox.Show("Vous êtes en train supprimé un ou plusieurs patient", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        index = int.Parse(dataGridViewListePatients.SelectedCells[1].Value.ToString());

                        paitent pat = cnx.cabinet_Dentaire.paitent.FirstOrDefault(xt => xt.Num_Dossier == index);

                        if (pat != null)
                        {
                            cnx.cabinet_Dentaire.paitent.Remove(pat);
                            cnx.cabinet_Dentaire.SaveChanges();
                        }
                        MessageBox.Show("Vous avez supprimé patient numéro " + index + " avec succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RemlpirListePat();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonRDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewListePatients.Rows.Count > 0)
                {
                    index = int.Parse(dataGridViewListePatients.CurrentRow.Cells[1].Value.ToString());
                    if (index != 0)
                    {
                        DetailsRDV rdv = new DetailsRDV();
                        string pat = cnx.cabinet_Dentaire.paitent.Where(xt => xt.Num_Dossier == index).Select(xt => xt.Prenom_Pat + " " + xt.Nom_Pat + " | " + xt.Num_Dossier).FirstOrDefault();
                        rdv.TextBoxPat.Text = pat;
                        rdv.DateTimePickerDate.Value = DateTime.Now;
                        rdv.StartPosition = FormStartPosition.CenterScreen;
                        rdv.FormBorderStyle = FormBorderStyle.None;
                        rdv.ShowDialog();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSort.Text == "Numéro dossier")
            {
                this.dataGridViewListePatients.Sort(this.dataGridViewListePatients.Columns["Num_Doss"], ListSortDirection.Ascending);
            }
            else if (ComboBoxSort.Text == "Prénom")
            {
                this.dataGridViewListePatients.Sort(this.dataGridViewListePatients.Columns["Prenom"], ListSortDirection.Ascending);
            }
            else if (ComboBoxSort.Text == "Nom")
            {
                this.dataGridViewListePatients.Sort(this.dataGridViewListePatients.Columns["Nom"], ListSortDirection.Ascending);
            }
            else if (ComboBoxSort.Text == "CIN ou Passport")
            {
                this.dataGridViewListePatients.Sort(this.dataGridViewListePatients.Columns["CIN_Passeport"], ListSortDirection.Ascending);
            }
        }
        public void RecherchePatient()
        {
            try
            {
                dataGridViewListePatients.Rows.Clear();

                var p = from pat in cnx.cabinet_Dentaire.paitent select new { pat.Photo_Pat, pat.Num_Dossier, pat.Prenom_Pat, pat.Nom_Pat, pat.CIN_Pass, pat.Date_Naissance_Pat, pat.Telephone_Pat };

                foreach (var pat in p.ToList())
                {
                    if (pat.CIN_Pass.ToLower().StartsWith(TextBoxSearch.Text.ToLower()) || pat.Nom_Pat.ToLower().StartsWith(TextBoxSearch.Text.ToLower()) || pat.Prenom_Pat.ToLower().StartsWith(TextBoxSearch.Text.ToLower()))
                    {
                        dataGridViewListePatients.Rows.Add(pat.Photo_Pat, pat.Num_Dossier, pat.Prenom_Pat, pat.Nom_Pat, pat.CIN_Pass, pat.Date_Naissance_Pat.ToShortDateString(), pat.Telephone_Pat);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text.Trim() != "")
            {
                RecherchePatient();
            }
            else
            {
                RemlpirListePat();
            }
        }

        private void ButtonRech_Click(object sender, EventArgs e)
        {
            RecherchePatient();
        }
    }
}
