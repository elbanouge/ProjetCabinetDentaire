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
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace ProjetCabinetDentaire.Docteur
{
    public partial class AjouterPat : Form
    {
        public AjouterPat()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        Classes.Connection cnx = new Classes.Connection();

        public List<string> mois = new List<string>() { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
        public int[] jour = new int[31];
        public int[] annee = new int[DateTime.Now.Year - 1899];
        public static bool bl = false;
        public bool VerText(string text)
        {
            bool bl = false;

            if (text.Trim() != "")
            {
                bl = true;
            }
            return bl;
        }

        public void RemplirJourDate()
        {
            int jr = 1;
            for (int i = 0; i < jour.Count(); i++)
            {
                jour[i] = jr;
                jr++;
            }
        }
        public void RemplirAnneeDate()
        {
            int ann = DateTime.Now.Year;
            for (int i = 0; i < annee.Count(); i++)
            {
                annee[i] = ann;
                ann--;
            }
        }
        public List<string> RemplirNat()
        {
            List<string> Nationalite = new List<string>() { "Marocaine", "Afghane", "Albanaise", "Algerienne", "Allemande", "Americaine", "Andorrane", "Angolaise", "Antiguaise et barbudienne",
                    "Argentine", "Australienne", "Autrichienne", "Azerbaïdjanaise", "Bahamienne", "Bahreinienne", "Bangladaise", "Barbadienne", "Belge", "Belizienne",
                    "Beninoise", "Bhoutanaise", "Bielorusse", "Birmane", "Bissau-Guinéenne", "Bolivienne", "Bosnienne", "Botswanaise", "Bresilienne",
                    "Britannique", "Bruneienne", "Bulgare", "Burkinabe", "Burundaise", "Cambodgienne", "Camerounaise", "Canadienne", "Cap-verdienne", "Centrafricaine",
                    "Chilienne", "Chinoise", "Chypriote", "Colombienne", "Comorienne", "Congolaise", "Costaricaine", "Croate", "Cubaine", "Danoise", "Djiboutienne",
                    "Dominicaine", "Dominiquaise", "Egyptienne", "Emirienne", "Equato-guineenne", "Equatorienne", "Erythreenne", "Espagnole", "Est-timoraise",
                    "Estonienne", "Ethiopienne", "Fidjienne", "Finlandaise", "Française", "Gabonaise", "Gambienne", "Georgienne", "Ghaneenne", "Grenadienne",
                    "Guatemalteque", "Guineenne", "Guyanienne", "Haïtienne", "Hellenique", "Hondurienne", "Hongroise", "Indienne", "Indonesienne", "Irakienne",
                    "Irlandaise", "Islandaise", "Italienne", "Ivoirienne", "Jamaïcaine", "Japonaise", "Jordanienne", "Kazakhstanaise", "Kenyane", "Kirghize",
                    "Kiribatienne", "Kittitienne-et-nevicienne", "Kossovienne", "Koweitienne", "Laotienne", "Lesothane", "Lettone", "Libanaise", "Liberienne",
                    "Libyenne", "Liechtensteinoise", "Lituanienne", "Luxembourgeoise", "Macedonienne", "Malaisienne", "Malawienne", "Maldivienne", "Malgache",
                    "Malienne", "Maltaise", "Marshallaise", "Mauricienne", "Mauritanienne", "Mexicaine", "Micronesienne", "Moldave", "Monegasque",
                    "Mongole", "Montenegrine", "Mozambicaine", "Namibienne", "Nauruane", "Neerlandaise", "Neo-zelandaise", "Nepalaise", "Nicaraguayenne",
                    "Nigeriane", "Nigerienne", "Nord-coréenne", "Norvegienne", "Omanaise", "Ougandaise", "Ouzbeke", "Pakistanaise", "Palau", "Palestinienne",
                    "Panameenne", "Papouane-neoguineenne", "Paraguayenne", "Peruvienne", "Philippine", "Polonaise", "Portoricaine", "Portugaise", "Qatarienne",
                    "Roumaine", "Russe", "Rwandaise", "Saint-lucienne", "Saint-marinaise", "Saint-vincentaise-et-grenadine", "Salomonaise", "Salvadorienne",
                    "Samoane", "Santomeenne", "Saoudienne", "Senegalaise", "Serbe", "Seychelloise", "Sierra-leonaise", "Singapourienne", "Slovaque", "Slovene",
                    "Somalienne", "Soudanaise", "Sri-lankaise", "Sud-africaine", "Sud-coréenne", "Suedoise", "Suisse", "Surinamaise", "Swazie", "Syrienne",
                    "Tadjike", "Taiwanaise", "Tanzanienne", "Tchadienne", "Tcheque", "Thaïlandaise", "Togolaise", "Tonguienne", "Trinidadienne", "Tunisienne",
                    "Turkmene", "Turque", "Tuvaluane", "Ukrainienne", "Uruguayenne", "Vanuatuane", "Venezuelienne", "Vietnamienne", "Yemenite", "Zambienne", "Zimbabweenne" };
            return Nationalite;
        }

        public bool EmailVer(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            if (match.Success || email == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CinPassVer(string CinPass)
        {
            Regex regex = new Regex(@"^[a-zA-Z]{2,3}[0-9]{4,}$");
            Match match = regex.Match(CinPass);

            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void RemplirComboAss(ComboBox combo)
        {
            string[] ass = { "CNSS", "CNOPS", "ATLANTA", "WafaAssurance" };

            foreach (string a in ass)
            {
                combo.Items.Add(a);
            }
        }
        public void RemplirComboTut(ComboBox combo)
        {
            string[] lien = { "Marie", "Femme", "Fille" };

            foreach (string l in lien)
            {
                combo.Items.Add(l);
            }
        }

        public void ViderChamps(Control control)
        {
            foreach (Control ct in control.Controls)
            {
                if (ct is MaskedTextBox ||  ct is TextBox || ct is Guna.UI.WinForms.GunaTextBox || ct is Guna.UI2.WinForms.Guna2TextBox)
                {
                    ct.Text = string.Empty;
                }
                if (ct.Controls.Count != 0)
                {
                    ViderChamps(ct);
                }
            }
        }
        private void AjouterPat_Load(object sender, EventArgs e)
        {
            ButtonTut.Visible = false;
            RemplirJourDate();
            RemplirAnneeDate();

            ComboBoxMois.DataSource = mois;
            ComboBoxJour.DataSource = jour;
            ComboBoxAnnee.DataSource = annee;
            ComboBoxNat.DataSource = RemplirNat();
            RemplirComboTut(ComboBoxTut);
            RemplirComboAss(ComboBoxNomAss);
            this.ActiveControl = TextBoxNom;
            TransitionHide.HideSync(ShadowPanelAss);
            pictureBoxImg.ImageLocation = Application.StartupPath + @"\User.png";
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        OpenFileDialog openFileDialog = new OpenFileDialog();
        private void ButtonPar_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe;*.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImg.ImageLocation = openFileDialog.FileName;
            }
        }

        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int idPat = 0;
        public bool ajpat = false;
        private void ButtonValider_Click(object sender, EventArgs e)
        {
            bool ajout = false;
            string sexe = "";
            bool CINOrPass = false;
            bool nom = VerText(TextBoxNom.Text);
            bool prenom = VerText(TextBoxPrenom.Text);
            bool cinpass = VerText(TextBoxCINPass.Text);
            bool email = EmailVer(TextBoxEmail.Text);
            bool cinpassver = CinPassVer(TextBoxCINPass.Text);

            bool alg = false;
            bool enc = false;
            bool sgn = false;
            bool trt = false;
            string prob = "";

            paitent paitent = new paitent();
            etat_paitent etat_Paitent = new etat_paitent();

            try
            {
                if (nom == true && prenom == true && cinpass == true && email == true && cinpassver == true && maskedTextBoxTel.MaskFull == true)
                {
                    paitent.Nom_Pat = TextBoxNom.Text;
                    paitent.Prenom_Pat = TextBoxPrenom.Text;

                    if (RadioButtonMas.Checked == true)
                    {
                        sexe = "Masculin";
                    }
                    else if (RadioButtonFem.Checked == true)
                    {
                        sexe = "Féminin";
                    }
                    paitent.Sexe_Pat = sexe;

                    if (RadioButtonCNE.Checked == true)
                    {
                        CINOrPass = true;
                    }
                    paitent.CIN_Or_Pass = CINOrPass;
                    paitent.CIN_Pass = TextBoxCINPass.Text;

                    paitent.Date_Naissance_Pat = DateTime.Parse(ComboBoxJour.Text + "/" + (ComboBoxMois.SelectedIndex + 1) + "/" + ComboBoxAnnee.Text);
                    paitent.Adresse_Pat = TextBoxAdresse.Text;
                    paitent.Email = TextBoxEmail.Text;
                    paitent.Nationalite = ComboBoxNat.Text;

                    string[] table = maskedTextBoxTel.Text.Split('-');
                    paitent.Telephone_Pat = table[0].Trim() + "-" + table[1].Trim() + "-" + table[2].Trim() + "-" + table[3].Trim();

                    if (openFileDialog.FileName != "")
                    {
                        System.IO.FileStream fs = new FileStream(pictureBoxImg.ImageLocation, FileMode.Open, FileAccess.Read);
                        byte[] t = new byte[fs.Length];
                        fs.Read(t, 0, (int)fs.Length);
                        paitent.Photo_Pat = t;
                    }
                    else
                    {
                        paitent.Photo_Pat = null;
                    }

                    if (ComboBoxNomAss.Text != "Aucune")
                    {
                        paitent.Nature_Ass = ComboBoxNomAss.Text;
                    }
                    else
                    {
                        paitent.Nature_Ass = "";
                    }

                    cnx.cabinet_Dentaire.paitent.Add(paitent);
                    cnx.cabinet_Dentaire.SaveChanges();
                    ajpat = true;
                    ajout = true;

                    idPat = cnx.cabinet_Dentaire.paitent.Max(p => p.Num_Dossier);

                    if (ajout == true)
                    {
                        if (RadioButtonAllegOui.Checked == true)
                        {
                            alg = true;
                        }
                        etat_Paitent.Allergie = alg;

                        if (RadioButtonEncOui.Checked == true)
                        {
                            enc = true;
                        }
                        etat_Paitent.Enceinte = enc;

                        if (RadioButtonSegOui.Checked == true)
                        {
                            sgn = true;
                        }
                        etat_Paitent.Saignement = sgn;

                        if (RadioButtonTraitOui.Checked == true)
                        {
                            trt = true;
                        }
                        etat_Paitent.Anesthesie = trt;

                        if (TextBoxProb.Text.Trim() != "" && CheckBoxProb.Checked == true)
                        {
                            prob = TextBoxProb.Text;
                        }

                        etat_Paitent.Autre_Etat = prob;
                        etat_Paitent.NumPatEt = int.Parse(idPat.ToString());
                        cnx.cabinet_Dentaire.etat_paitent.Add(etat_Paitent);
                        cnx.cabinet_Dentaire.SaveChanges();
                    }

                    cnx.cabinet_Dentaire.SaveChanges();
                    bl = true;
                    MessageBox.Show("Vous avez ajouté un patient avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ViderChamps(this);
                    this.Close();
                }
                else if (nom == false)
                {
                    LabelErreur.Visible = true;
                    LabelErreur.Text = "* Ce champ nom patient est obligatoire.";
                }
                else if (prenom == false)
                {
                    LabelErreur.Visible = true;
                    LabelErreur.Text = "* Ce champ prénom patient est obligatoire.";
                }
                else if (cinpass == false)
                {
                    LabelErreur.Visible = true;
                    LabelErreur.Text = "* Ce champ CIN ou numéro passport patient est obligatoire.";
                }
                else if (cinpassver == false)
                {
                    LabelErreur.Visible = true;
                    LabelErreur.Text = "* Vérifie format de champ CIN ou numéro passport patient.";
                }
                else if (maskedTextBoxTel.MaskFull == false)
                {
                    LabelErreur.Visible = true;
                    LabelErreur.Text = "* Ce champ numéro télephone patient est obligatoire.";
                }
                else if (email == false)
                {
                    LabelErreur.Visible = true;
                    LabelErreur.Text = "* Vérifie format de champ email patient.";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TextBoxNom_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void TextBoxCINPass_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void maskedTextBoxTel_TextChanged(object sender, EventArgs e)
        {
            maskedTextBoxTel.Focus();
            LabelErreur.Visible = false;
        }

        private void CheckBoxTuteur_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxTuteur.Checked == true)
            {
                groupBoxTuteur.Enabled = true;
                ButtonTut.Visible = true;
            }
            else
            {
                groupBoxTuteur.Enabled = false;
                ButtonTut.Visible = false;
            }
        }

        private void ImageButtonBoxAssPlus_Click(object sender, EventArgs e)
        {
            TransitionShow.ShowSync(ShadowPanelAss);
            TextBoxNonAssTut.PlaceholderText = "Nature Assurance";
        }

        private void ImageButtonClose_Click(object sender, EventArgs e)
        {
            TransitionHide.HideSync(ShadowPanelAss);
        }

        private void ImageButtonValAss_Click(object sender, EventArgs e)
        {
            try
            {
                bool b = false;
                bool bol = false;

                if (TextBoxNonAssTut.PlaceholderText == "Nature Assurance")
                {
                    if (TextBoxNonAssTut.Text.Trim() != "")
                    {
                        foreach (string combo in ComboBoxNomAss.Items)
                        {
                            if (TextBoxNonAssTut.Text.ToUpper() == combo.ToUpper())
                            {
                                b = true;
                            }
                        }

                        if (b == false)
                        {
                            ComboBoxNomAss.Items.Add(TextBoxNonAssTut.Text);
                            TransitionHide.HideSync(ShadowPanelAss);
                            TextBoxNonAssTut.Clear();
                        }
                        else
                        {
                            MessageBox.Show("le nom de l'assurance saisies est déja exists", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TextBoxNonAssTut.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vérifier le nom de l'assurance ou lien tuteur saisies", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                if (TextBoxNonAssTut.PlaceholderText == "Lien Tuteur" && CheckBoxTuteur.Checked == true)
                {
                    if (TextBoxNonAssTut.Text.Trim() != "")
                    {
                        foreach (string comb in ComboBoxTut.Items)
                        {
                            if (TextBoxNonAssTut.Text.ToUpper() == comb.ToUpper())
                            {
                                bol = true;
                            }
                        }

                        if (bol == false)
                        {
                            ComboBoxTut.Items.Add(TextBoxNonAssTut.Text);
                            TransitionHide.HideSync(ShadowPanelAss);
                            TextBoxNonAssTut.Clear();
                        }
                        else
                        {
                            MessageBox.Show("le lien tuteur saisies est déja exists", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TextBoxNonAssTut.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vérifier le nom de l'assurance ou lien tuteur saisies", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CheckBoxProb_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxProb.Checked == true)
            {
                TextBoxProb.Enabled = true;
            }
            else
            {
                TextBoxProb.Enabled = false;
            }
        }

        private void ImageButtonTut_Click(object sender, EventArgs e)
        {
            TransitionShow.ShowSync(ShadowPanelAss);
            TextBoxNonAssTut.PlaceholderText = "Lien Tuteur";
        }

        private void ButtonTut_Click(object sender, EventArgs e)
        {
            tuteur tut = new tuteur();

            try
            {
                bool nomtut = VerText(TextBoxNomTut.Text);
                bool prenomtut = VerText(TextBoxPrTut.Text);
                bool cintut = VerText(TextBoxCNETut.Text);
                bool cinver = CinPassVer(TextBoxCNETut.Text);
                bool nom = VerText(TextBoxNomTut.Text);
                bool prenom = VerText(TextBoxPrTut.Text);
                bool cinpass = VerText(TextBoxCNETut.Text);
                string genre = "";

                if (ajpat == true)
                {
                    if (CheckBoxTuteur.Checked == true)
                    {
                        if (nom == true && cinver == true && prenom == true && cinpass == true)
                        {
                            tut.Nom_Tut = TextBoxNomTut.Text;
                            tut.Prenom_Tut = TextBoxPrTut.Text;

                            if (RadioButtonMasTut.Checked == true)
                            {
                                genre = "Masculin";
                            }
                            else if (RadioButtonFesTut.Checked == true)
                            {
                                genre = "Féminin";
                            }
                            tut.Sexe_Tut = genre;
                            tut.Lien_Tut = ComboBoxTut.Text;
                            tut.CIN_Tut = TextBoxCNETut.Text;
                            tut.NumPatTut = int.Parse(idPat.ToString());

                            cnx.cabinet_Dentaire.tuteur.Add(tut);
                            cnx.cabinet_Dentaire.SaveChanges();

                            MessageBox.Show("Vous avez ajouté un tuteur avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CheckBoxTuteur.Checked = false;
                            ViderChamps(this);
                            this.Close();
                        }
                        else if (nomtut == false)
                        {
                            LabelErreur.Visible = true;
                            LabelErreur.Text = "* Ce champ nom tuteur est obligatoire.";
                        }
                        else if (prenomtut == false)
                        {
                            LabelErreur.Visible = true;
                            LabelErreur.Text = "* Ce champ prénom tuteur est obligatoire.";
                        }
                        else if (cintut == false)
                        {
                            LabelErreur.Visible = true;
                            LabelErreur.Text = "* Ce champ CIN tuteur est obligatoire.";
                        }
                        else if (cinver == false)
                        {
                            LabelErreur.Visible = true;
                            LabelErreur.Text = "* Vérifie format de champ CIN de tuteur.";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ajouter d'abord le patient", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonVider_Click(object sender, EventArgs e)
        {
            ViderChamps(this);
        }

        private void TextBoxNomTut_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void TextBoxPrTut_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void TextBoxCNETut_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void TextBoxPrenom_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }
    }
}
