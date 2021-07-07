using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace ProjetCabinetDentaire.Docteur
{
    public partial class DetailsRDV : Form
    {
        public DetailsRDV()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        Classes.Connection cnx = new Classes.Connection();
        public string[] heure = new string[12];
        public string[] minute = new string[60];
        public void RemplirHeureJour(ComboBox combo)
        {
            int hr = 8;
            for (int i = 0; i < heure.Count(); i++)
            {
                heure[i] = hr.ToString() + " :";
                combo.Items.Add(heure[i]);
                hr++;
            }
        }
        public void RemplirMinuteJour(ComboBox combo)
        {
            int mn = 0;
            for (int i = 0; i < minute.Count(); i += 10)
            {
                minute[i] = mn.ToString() + "0 H";
                combo.Items.Add(minute[i]);
                mn++;
            }
        }
        public int IdRDV = 0;
        public string[] Pat;
        public void RecherchePat(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            var pa = cnx.cabinet_Dentaire.paitent.Select(xt => xt.Prenom_Pat + " " + xt.Nom_Pat + " | " + xt.Num_Dossier);
            var source = new AutoCompleteStringCollection();
            source.AddRange(pa.ToArray());
            Pat = pa.ToArray();
            textBox.AutoCompleteCustomSource = source;
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void DetailsRDV_Load(object sender, EventArgs e)
        {
            RecherchePat(TextBoxPat);

            RemplirHeureJour(ComboBoxHeure);
            RemplirMinuteJour(ComboBoxMinute);
            if (IdRDV == 0)
            {
                ButtonSupp.Visible = false;
                ButtonEnvSMS.Visible = false;
                LabelNmRDV.Visible = false;
                LabelNmRDVTit.Visible = false;
            }
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void ButtonValider_Click(object sender, EventArgs e)
        {
            if (IdRDV == 0)
            {
                try
                {
                    if (Pat.Contains(TextBoxPat.Text))
                    {
                        rendez_vous rdv = new rendez_vous();

                        rdv.Date_RDV = DateTime.Parse(DateTimePickerDate.Value.ToShortDateString());
                        string[] minute = ComboBoxMinute.Text.Split();
                        MessageBox.Show(minute[0].ToString());
                        DateTime heure = DateTime.Parse(ComboBoxHeure.Text + minute[0]);
                        rdv.Horaire_RDV = heure.TimeOfDay;
                        MessageBox.Show(heure.TimeOfDay.ToString());

                        string[] numpat = TextBoxPat.Text.Split('|');
                        int pat = int.Parse(numpat[1].Trim());
                        rdv.NumPtRdv = pat;
                        rdv.Description_RDV = TextBoxDescr.Text;
                        int doc = cnx.cabinet_Dentaire.employe.Where(xt => xt.Num_INP == 34175323).Select(xt => xt.Matricule).FirstOrDefault();
                        rdv.MatRDV = doc;

                        cnx.cabinet_Dentaire.rendez_vous.Add(rdv);
                        cnx.cabinet_Dentaire.SaveChanges();
                        MessageBox.Show("Vous avez ajouté un rendez-vous avec succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Vous voulez taper un nom patient validé", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    if (Pat.Contains(TextBoxPat.Text))
                    {
                        int num = int.Parse(LabelNmRDV.Text);
                        rendez_vous rdv = cnx.cabinet_Dentaire.rendez_vous.FirstOrDefault(xt => xt.ID_RDV == num);

                        rdv.Date_RDV = DateTime.Parse(DateTimePickerDate.Value.ToShortDateString());
                        DateTime heure = DateTime.Parse(ComboBoxHeure.Text + ComboBoxMinute.Text);
                        rdv.Horaire_RDV = heure.TimeOfDay;
                        string[] numpat = TextBoxPat.Text.Split('|');
                        int pat = int.Parse(numpat[1].Trim());
                        rdv.NumPtRdv = pat;
                        rdv.Description_RDV = TextBoxDescr.Text;
                        int doc = cnx.cabinet_Dentaire.employe.Where(xt => xt.Num_INP == 1234).Select(xt => xt.Matricule).FirstOrDefault();
                        rdv.MatRDV = doc;

                        cnx.cabinet_Dentaire.SaveChanges();
                        MessageBox.Show("Vous avez modifié un rendez-vous avec succes", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Vous voulez taper un nom patient validé", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonSupp_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Vous êtes en train supprimé un ou plusieurs patient", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int num = int.Parse(LabelNmRDV.Text);

                    rendez_vous rdv = cnx.cabinet_Dentaire.rendez_vous.FirstOrDefault(xt => xt.ID_RDV == num);

                    if (rdv != null)
                    {
                        cnx.cabinet_Dentaire.rendez_vous.Remove(rdv);
                        cnx.cabinet_Dentaire.SaveChanges();
                    }
                    MessageBox.Show("Vous avez supprimé rendez-vous numéro " + num + " avec succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ButtonTitle_MouseDown(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public static int numrdv;
        private void ButtonEnvSMS_Click(object sender, EventArgs e)
        {
            numrdv = int.Parse(LabelNmRDV.Text);
            if (numrdv != 0)
            {
                EnvoyerSMS sms = new EnvoyerSMS();                
                sms.StartPosition = FormStartPosition.CenterScreen;
                sms.FormBorderStyle = FormBorderStyle.None;
                sms.ShowDialog();
            }
        }
    }
}
