using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCabinetDentaire.Docteur
{
    public partial class AjouterEmp : Form
    {
        public AjouterEmp()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        Classes.Connection cnx = new Classes.Connection();
        public static bool bl = false;

        AjouterPat pat = new AjouterPat();
        private void AjouterEmp_Load(object sender, EventArgs e)
        {
            if (ComboBoxFon.Text == "Docteur")
            {
                TextBoxINPE.Enabled = true;
                ButtonAjtLogin.Enabled = true;
                groupBoxLogin.Enabled = true;
                ComboBoxTypeEmp.Text = "Admin";
            }
            pat.RemplirJourDate();
            pat.RemplirAnneeDate();

            ComboBoxMois.DataSource = pat.mois;
            ComboBoxJour.DataSource = pat.jour;
            ComboBoxAnnee.DataSource = pat.annee;

            ComboBoxDAcMois.DataSource = pat.mois;
            ComboBoxDAcJour.DataSource = pat.jour;
            ComboBoxDAcAnnee.DataSource = pat.annee;

            ComboBoxDFinMois.DataSource = pat.mois;
            ComboBoxDFinJour.DataSource = pat.jour;
            ComboBoxDFinAnnee.DataSource = pat.annee;

            this.ActiveControl = TextBoxNom;
            pictureBoxImg.ImageLocation = Application.StartupPath + @"\User.png";
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

        private void ButtonVider_Click(object sender, EventArgs e)
        {
            pat.ViderChamps(this);
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
        public bool ajpemp = false;
        public int idEmp = 0;
        private void ButtonValider_Click(object sender, EventArgs e)
        {
            employe employe = new employe();

            string sexe = "";
            bool nom = pat.VerText(TextBoxNom.Text);
            bool prenom = pat.VerText(TextBoxPrenom.Text);
            bool cin = pat.VerText(TextBoxCNE.Text);
            bool cinver = pat.CinPassVer(TextBoxCNE.Text);
            int num;
            bool num_INPTE = int.TryParse(TextBoxINPE.Text, out num);
            decimal sal;
            bool salaire = decimal.TryParse(TextBoxSalaire.Text, out sal);

            try
            {
                if (nom == true && prenom == true && cin == true && cinver == true && maskedTextBoxTel.MaskFull == true)
                {
                    if (num_INPTE == true)
                    {
                        employe.Num_INP = num;
                    }
                    else
                    {
                        employe.Num_INP = 0;
                    }
                    employe.Titre_cour = ComboBoxTitrcor.Text;
                    employe.Nom_Emp = TextBoxNom.Text;
                    employe.Prenom_Emp = TextBoxPrenom.Text;
                    employe.Fonction = ComboBoxFon.Text;

                    if (RadioButtonMas.Checked == true)
                    {
                        sexe = "Masculin";
                    }
                    else if (RadioButtonFem.Checked == true)
                    {
                        sexe = "Féminin";
                    }

                    employe.Sexe_Emp = sexe;
                    employe.CIN_Emp = TextBoxCNE.Text;

                    if (salaire == true)
                    {
                        employe.Salaire = sal;
                    }
                    else
                    {
                        employe.Salaire = 0;
                    }
                    employe.Type_Emp = ComboBoxTypeEmp.Text;
                    employe.Date_Naissance_Emp = DateTime.Parse(ComboBoxJour.Text + "/" + (ComboBoxMois.SelectedIndex + 1) + "/" + ComboBoxAnnee.Text);
                    employe.Date_Embache = DateTime.Parse(ComboBoxDAcJour.Text + "/" + (ComboBoxDAcMois.SelectedIndex + 1) + "/" + ComboBoxDAcAnnee.Text);
                    employe.Date_Fin_Activite = DateTime.Parse(ComboBoxDFinJour.Text + "/" + (ComboBoxDFinMois.SelectedIndex + 1) + "/" + ComboBoxDFinAnnee.Text);
                    employe.Adresse_Emp = TextBoxAdresse.Text;

                    string[] table = maskedTextBoxTel.Text.Split('-');
                    employe.Telephone_Emp = table[0].Trim() + "-" + table[1].Trim() + "-" + table[2].Trim() + "-" + table[3].Trim();

                    if (openFileDialog.FileName != "")
                    {
                        System.IO.FileStream fs = new FileStream(pictureBoxImg.ImageLocation, FileMode.Open, FileAccess.Read);
                        byte[] t = new byte[fs.Length];
                        fs.Read(t, 0, (int)fs.Length);
                        employe.Photo_Emp = t;
                    }
                    else
                    {
                        employe.Photo_Emp = null;
                    }

                    cnx.cabinet_Dentaire.employe.Add(employe);
                    cnx.cabinet_Dentaire.SaveChanges();
                    idEmp = cnx.cabinet_Dentaire.employe.Max(p => p.Matricule);

                    ajpemp = true;
                    bl = true;
                    MessageBox.Show("Vous avez ajouté un employé avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pat.ViderChamps(this);
                }
                else if (nom == false)
                {
                    LabelErreur.Visible = true;
                    LabelErreur.Text = "* Ce champ nom employe est obligatoire.";
                }
                else if (prenom == false)
                {
                    LabelErreur.Visible = true;
                    LabelErreur.Text = "* Ce champ prénom employe est obligatoire.";
                }
                else if (cin == false)
                {
                    LabelErreur.Visible = true;
                    LabelErreur.Text = "* Ce champ carte d'identité nationale employe est obligatoire.";
                }
                else if (cinver == false)
                {
                    LabelErreur.Visible = true;
                    LabelErreur.Text = "* Vérifie format de champ carte d'identité nationale employe.";
                }
                else if (maskedTextBoxTel.MaskFull == false)
                {
                    LabelErreur.Visible = true;
                    LabelErreur.Text = "* Vérifie format de champ numéro télephone employe.";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ComboBoxFon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxFon.Text == "Docteur")
            {
                TextBoxINPE.Enabled = true;
                ButtonAjtLogin.Visible = true;
                groupBoxLogin.Enabled = true;
                ComboBoxTypeEmp.Text = "Admin";
            }
            else if (ComboBoxFon.Text == "Secrétariat")
            {
                TextBoxINPE.Enabled = false;
                ButtonAjtLogin.Visible = true;
                groupBoxLogin.Enabled = true;
                ComboBoxTypeEmp.Text = "User";
            }
            else if (ComboBoxFon.Text == "Autres")
            {
                TextBoxINPE.Enabled = false;
                ButtonAjtLogin.Visible = false;
                groupBoxLogin.Enabled = false;
                ComboBoxTypeEmp.Text = "User";
            }
        }

        private void ButtonAjtLogin_Click(object sender, EventArgs e)
        {
            login_emp login = new login_emp();

            try
            {
                bool user = pat.VerText(TextBoxNomUser.Text);
                bool password = pat.VerText(TextBoxMdpUser.Text);

                if (ajpemp == true)
                {
                    if (user == true && password == true)
                    {
                        login.User_Log = TextBoxNomUser.Text;
                        login.Mot_Passe = TextBoxMdpUser.Text;
                        login.MatEmpL = idEmp;

                        if (TextBoxMdpUser.Text.Equals(TextBoxCMdp.Text))
                        {
                            cnx.cabinet_Dentaire.login_emp.Add(login);
                            cnx.cabinet_Dentaire.SaveChanges();

                            int NumEmp = cnx.cabinet_Dentaire.employe.Max(emp => emp.Matricule);
                            string NomEmp = cnx.cabinet_Dentaire.employe.Where(xt => xt.Matricule == NumEmp).Select(emp => emp.Nom_Emp).FirstOrDefault();

                            MessageBox.Show("Vous avez ajouté login aux " + NomEmp + " avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            pat.ViderChamps(this);
                            this.Close();
                        }
                        else
                        {
                            LabelErreur.Visible = true;
                            LabelErreur.Text = "* Les mots de passe saisis ne sont pas identiques.";
                        }
                    }
                    else if (user == false)
                    {
                        LabelErreur.Visible = true;
                        LabelErreur.Text = "* Ce champ nom d'utilisateur employe est obligatoire.";
                    }
                    else if (password == false)
                    {
                        LabelErreur.Visible = true;
                        LabelErreur.Text = "* Ce champ mot de passe employe est obligatoire.";
                    }
                }
                else
                {
                    MessageBox.Show("Ajouter d'abord le employe", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void TextBoxPrenom_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void TextBoxCNE_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void TextBoxNomUser_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void TextBoxMdpUser_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void TextBoxCMdp_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void TextBoxCMdp_Click(object sender, EventArgs e)
        {
            TextBoxCMdp.UseSystemPasswordChar = false;
            TextBoxCMdp.IconRight = Properties.Resources._private;
        }

        private void TextBoxCMdp_DoubleClick(object sender, EventArgs e)
        {
            TextBoxCMdp.UseSystemPasswordChar = true;
            TextBoxCMdp.IconRight = Properties.Resources.show;
        }

        private void TextBoxMdpUser_Click(object sender, EventArgs e)
        {
            TextBoxMdpUser.UseSystemPasswordChar = false;
            TextBoxMdpUser.IconRight = Properties.Resources._private;
        }

        private void TextBoxMdpUser_DoubleClick(object sender, EventArgs e)
        {
            TextBoxMdpUser.UseSystemPasswordChar = true;
            TextBoxMdpUser.IconRight = Properties.Resources.show;
        }
    }
}
