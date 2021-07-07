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
using System.Globalization;
using MySql.Data.MySqlClient;

namespace ProjetCabinetDentaire.Docteur
{
    public partial class AfficherPat : Form
    {
        public AfficherPat()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        Classes.Connection cnx = new Classes.Connection();
        public static bool bl = false;
        public int NumPat = 0;
        public int NumEtat = 0;
        public int NumTut = 0;
        public void Afficher()
        {
            string sexe = "";
            string sexeTut = "";
            int CINOrPass = 0;

            cnx.cmd.Connection = cnx.con;
            cnx.cmd.CommandText = "AfficherPatient";
            cnx.cmd.CommandType = CommandType.StoredProcedure;
            cnx.cmd.Parameters.AddWithValue("NumPat", Patient.index);

            cnx.parameter.ParameterName = "rt";
            cnx.parameter.MySqlDbType = MySqlDbType.Int32;
            cnx.parameter.Direction = ParameterDirection.Output;
            cnx.cmd.Parameters.Add(cnx.parameter);
            cnx.Connecter();
            cnx.cmd.ExecuteNonQuery();
            cnx.Deconnecter();
            cnx.Connecter();
            cnx.dr = cnx.cmd.ExecuteReader();

            if (cnx.dr.Read())
            {
                LabelNmDossier.Text = cnx.dr[0].ToString();
                NumPat = int.Parse(cnx.dr[0].ToString());
                TextBoxNom.Text = cnx.dr[1].ToString();
                TextBoxPrenom.Text = cnx.dr[2].ToString();

                sexe = cnx.dr[3].ToString();
                if (sexe == "Masculin")
                {
                    RadioButtonMas.Checked = true;
                }
                else if (sexe == "Féminin")
                {
                    RadioButtonFem.Checked = true;
                }

                CINOrPass = int.Parse(cnx.dr[4].ToString());
                if (CINOrPass == 1)
                {
                    RadioButtonCNE.Checked = true;
                }
                else
                {
                    RadioButtonPass.Checked = true;
                }

                TextBoxCINPass.Text = cnx.dr[5].ToString();

                DateTime date = DateTime.Parse(cnx.dr[6].ToString());

                ComboBoxMois.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(date.Month);
                ComboBoxJour.Text = date.Day.ToString();
                ComboBoxAnnee.Text = date.Year.ToString();

                TextBoxAdresse.Text = cnx.dr[7].ToString();
                TextBoxEmail.Text = cnx.dr[8].ToString();
                ComboBoxNat.Text = cnx.dr[9].ToString();

                if (!cnx.dr.IsDBNull(10))
                {
                    Byte[] data = (Byte[])(cnx.dr[10]);
                    MemoryStream mem = new MemoryStream(data);
                    pictureBoxImg.Image = Image.FromStream(mem);
                }
                else 
                {
                    pictureBoxImg.Image = Properties.Resources.User;
                }

                maskedTextBoxTel.Text = cnx.dr[11].ToString();
                ComboBoxNomAss.Text = cnx.dr[12].ToString();

                NumEtat = int.Parse(cnx.dr[13].ToString());
                if (cnx.dr[14].ToString() == "1")
                {
                    RadioButtonTraitOui.Checked = true;
                }
                if (cnx.dr[15].ToString() == "1")
                {
                    RadioButtonAllegOui.Checked = true;
                }
                if (cnx.dr[16].ToString() == "1")
                {
                    RadioButtonSegOui.Checked = true;
                }
                if (cnx.dr[17].ToString() == "1")
                {
                    RadioButtonEncOui.Checked = true;
                }

                if (cnx.dr[18].ToString() != "")
                {
                    CheckBoxProb.Checked = true;
                    TextBoxProb.Text = cnx.dr[18].ToString();
                }

                if (cnx.parameter.Value.ToString() == "1")
                {
                    NumTut = int.Parse(cnx.dr[20].ToString());
                    CheckBoxTuteur.Checked = true;
                    TextBoxNomTut.Text = cnx.dr[21].ToString();
                    TextBoxPrTut.Text = cnx.dr[22].ToString();

                    sexeTut = cnx.dr[23].ToString();
                    if (sexeTut == "Masculin")
                    {
                        RadioButtonMasTut.Checked = true;
                    }
                    else if (sexeTut == "Féminin")
                    {
                        RadioButtonFesTut.Checked = true;
                    }
                    ComboBoxTut.Text = cnx.dr[24].ToString();
                    TextBoxCNETut.Text = cnx.dr[25].ToString();
                }
            }
            cnx.dr.Close();
            cnx.Deconnecter();
        }
        private void AfficherPat_Load(object sender, EventArgs e)
        {
            AjouterPat ajouterPat = new AjouterPat();
            ajouterPat.RemplirJourDate();
            ajouterPat.RemplirAnneeDate();

            ComboBoxMois.DataSource = ajouterPat.mois;
            ComboBoxJour.DataSource = ajouterPat.jour;
            ComboBoxAnnee.DataSource = ajouterPat.annee;
            ComboBoxNat.DataSource = ajouterPat.RemplirNat();
            ajouterPat.RemplirComboAss(ComboBoxNomAss);
            ajouterPat.RemplirComboTut(ComboBoxTut);
            ButtonModTut.Visible = false;
            TransitionHide.HideSync(ShadowPanelAss);
            this.ActiveControl = TextBoxNom;
            Afficher();

            if (CheckBoxTuteur.Checked == false)
            {
                groupBoxTuteur.Enabled = false;
                ButtonModTut.Visible = false;
            }
            pictureBoxImg.ImageLocation = Application.StartupPath + @"\User.png";
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAnnuler_Click(object sender, EventArgs e)
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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImg.ImageLocation = openFileDialog.FileName;
            }
        }
        private void ButtonModifier_Click(object sender, EventArgs e)
        {
            AjouterPat Ajpat = new AjouterPat();

            string sexe = "";
            bool CINOrPass = false;
            bool nom = Ajpat.VerText(TextBoxNom.Text);
            bool prenom = Ajpat.VerText(TextBoxPrenom.Text);
            bool cinpass = Ajpat.VerText(TextBoxCINPass.Text);
            bool email = Ajpat.EmailVer(TextBoxEmail.Text);
            bool cinpassver = Ajpat.CinPassVer(TextBoxCINPass.Text);

            bool alg = false;
            bool enc = false;
            bool sgn = false;
            bool trt = false;
            string prob = "";

            try
            {
                if (nom == true && prenom == true && cinpass == true && email == true && cinpassver == true && maskedTextBoxTel.MaskFull == true)
                {
                    paitent paitent = cnx.cabinet_Dentaire.paitent.FirstOrDefault(xt => xt.Num_Dossier == NumPat);

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

                    System.IO.FileStream fs = new FileStream(pictureBoxImg.ImageLocation, FileMode.Open, FileAccess.Read);
                    byte[] t = new byte[fs.Length];
                    fs.Read(t, 0, (int)fs.Length);

                    paitent.Photo_Pat = t;

                    if (ComboBoxNomAss.Text != "Aucune")
                    {
                        paitent.Nature_Ass = ComboBoxNomAss.Text;
                    }
                    else
                    {
                        paitent.Nature_Ass = "";
                    }

                    etat_paitent etat_paitent = cnx.cabinet_Dentaire.etat_paitent.FirstOrDefault(xt => xt.Num_Etat == NumEtat);

                    if (RadioButtonAllegOui.Checked == true)
                    {
                        alg = true;
                    }
                    etat_paitent.Allergie = alg;

                    if (RadioButtonEncOui.Checked == true)
                    {
                        enc = true;
                    }
                    etat_paitent.Enceinte = enc;

                    if (RadioButtonSegOui.Checked == true)
                    {
                        sgn = true;
                    }
                    etat_paitent.Saignement = sgn;

                    if (RadioButtonTraitOui.Checked == true)
                    {
                        trt = true;
                    }
                    etat_paitent.Anesthesie = trt;

                    if (TextBoxProb.Text.Trim() != "" && CheckBoxProb.Checked == true)
                    {
                        prob = TextBoxProb.Text;
                    }

                    etat_paitent.Autre_Etat = prob;
                    etat_paitent.NumPatEt = NumPat;
                    cnx.cabinet_Dentaire.SaveChanges();

                    bl = true;
                    MessageBox.Show("Vous avez modifié un patient avec succès", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void CheckBoxProb_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxProb.Checked == true)
            {
                TextBoxProb.Enabled = true;
            }
            else if (CheckBoxProb.Checked == false)
            {
                TextBoxProb.Enabled = false;
                TextBoxProb.Clear();
            }
        }

        private void CheckBoxTuteur_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxTuteur.Checked == true)
            {
                groupBoxTuteur.Enabled = true;
                ButtonModTut.Visible = true;
            }
            else
            {
                groupBoxTuteur.Enabled = false;
                ButtonModTut.Visible = false;
            }
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

        private void ImageButtonBoxAssPlus_Click(object sender, EventArgs e)
        {
            TransitionShow.ShowSync(ShadowPanelAss);
            TextBoxNonAssTut.PlaceholderText = "Nature Assurance";
        }

        private void ImageButtonTut_Click(object sender, EventArgs e)
        {
            TransitionShow.ShowSync(ShadowPanelAss);
            TextBoxNonAssTut.PlaceholderText = "Lien Tuteur";
        }

        private void ImageButtonClose_Click(object sender, EventArgs e)
        {
            TransitionHide.HideSync(ShadowPanelAss);
        }

        private void ButtonModTut_Click(object sender, EventArgs e)
        {
            AjouterPat Ajpat = new AjouterPat();

            try
            {
                bool nomtut = Ajpat.VerText(TextBoxNomTut.Text);
                bool prenomtut = Ajpat.VerText(TextBoxPrTut.Text);
                bool cintut = Ajpat.VerText(TextBoxCNETut.Text);
                bool cinver = Ajpat.CinPassVer(TextBoxCNETut.Text);
                bool nom = Ajpat.VerText(TextBoxNomTut.Text);
                bool prenom = Ajpat.VerText(TextBoxPrTut.Text);
                bool cinpass = Ajpat.VerText(TextBoxCNETut.Text);
                string genre = "";

                if (CheckBoxTuteur.Checked == true)
                {
                    tuteur tut = cnx.cabinet_Dentaire.tuteur.FirstOrDefault(xt=> xt.Num_Tuteur == NumTut);

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
                        tut.NumPatTut = NumPat;

                        cnx.cabinet_Dentaire.SaveChanges();
                        bl = true;
                        MessageBox.Show("Vous avez modifié un tuteur avec succès", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TextBoxCNETut_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void TextBoxPrTut_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void TextBoxNomTut_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void maskedTextBoxTel_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void TextBoxCINPass_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void TextBoxPrenom_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void TextBoxNom_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }
    }
}
