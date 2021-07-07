using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCabinetDentaire.Docteur
{
    public partial class AfficherEmp : Form
    {
        public AfficherEmp()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public static bool bl = false;
        Classes.Connection cnx = new Classes.Connection();
        public int NumEmp = 0;
        public int NumLogin = 0;

        AjouterPat pat = new AjouterPat();
        public void Afficher()
        {
            string sexe = "";

            cnx.cmd.Connection = cnx.con;
            cnx.cmd.CommandText = "AfficherEmploye";
            cnx.cmd.CommandType = CommandType.StoredProcedure;
            cnx.cmd.Parameters.AddWithValue("NumEmp", Users.index);

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
                LabelMt.Text = cnx.dr[0].ToString();
                NumEmp = int.Parse(cnx.dr[0].ToString());
                TextBoxINPE.Text = cnx.dr[1].ToString();
                TextBoxNom.Text = cnx.dr[2].ToString();
                TextBoxPrenom.Text = cnx.dr[3].ToString();
                ComboBoxTitrcor.Text = cnx.dr[4].ToString();
                TextBoxCNE.Text = cnx.dr[5].ToString();
                ComboBoxFon.Text = cnx.dr[6].ToString();

                sexe = cnx.dr[7].ToString();
                if (sexe == "Masculin")
                {
                    RadioButtonMas.Checked = true;
                }
                else if (sexe == "Féminin")
                {
                    RadioButtonFem.Checked = true;
                }

                TextBoxSalaire.Text = cnx.dr[8].ToString();

                DateTime date = DateTime.Parse(cnx.dr[9].ToString());
                DateTime dateD = DateTime.Parse(cnx.dr[10].ToString());
                DateTime dateA = DateTime.Parse(cnx.dr[11].ToString());

                ComboBoxMois.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(date.Month);
                ComboBoxJour.Text = date.Day.ToString();
                ComboBoxAnnee.Text = date.Year.ToString();

                ComboBoxDAcMois.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dateD.Month);
                ComboBoxDAcJour.Text = dateD.Day.ToString();
                ComboBoxDAcAnnee.Text = dateD.Year.ToString();

                ComboBoxDFinMois.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dateA.Month);
                ComboBoxDFinJour.Text = dateA.Day.ToString();
                ComboBoxDFinAnnee.Text = dateA.Year.ToString();

                ComboBoxTypeEmp.Text = cnx.dr[12].ToString();
                maskedTextBoxTel.Text = cnx.dr[13].ToString();
                TextBoxAdresse.Text = cnx.dr[14].ToString();

                if (!cnx.dr.IsDBNull(15))
                {
                    Byte[] data = (Byte[])(cnx.dr[15]);
                    MemoryStream mem = new MemoryStream(data);
                    pictureBoxImg.Image = Image.FromStream(mem);
                }
                else
                {
                    pictureBoxImg.Image = Properties.Resources.User;
                }

                if (cnx.parameter.Value.ToString() == "1")
                {
                    NumLogin = int.Parse(cnx.dr[18].ToString());
                    TextBoxNomUser.Text = cnx.dr[19].ToString();
                    TextBoxMdpUser.Text = cnx.dr[20].ToString();
                }
            }
            cnx.dr.Close();
            cnx.Deconnecter();
        }
        private void AfficherEmp_Load(object sender, EventArgs e)
        {
            Afficher();
            pictureBoxImg.ImageLocation = Application.StartupPath + @"\User.png";
        }

        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BoxReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonValider_Click(object sender, EventArgs e)
        {
            login_emp login = cnx.cabinet_Dentaire.login_emp.FirstOrDefault(xt => xt.ID_Log == NumLogin);

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
        public bool ajpemp = false;
        public int idEmp = 0;
        private void ButtonMod_Click(object sender, EventArgs e)
        {
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
                    employe employe = cnx.cabinet_Dentaire.employe.FirstOrDefault(xt => xt.Matricule == idEmp);

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

        OpenFileDialog openFileDialog = new OpenFileDialog();
        private void ButtonPar_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe;*.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImg.ImageLocation = openFileDialog.FileName;
            }
        }

        private void ComboBoxFon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxFon.Text == "Docteur")
            {
                TextBoxINPE.Enabled = true;
                ButtonValider.Visible = true;
                groupBoxLogin.Enabled = true;
                ComboBoxTypeEmp.Text = "Admin";
            }
            else if (ComboBoxFon.Text == "Secrétariat")
            {
                TextBoxINPE.Enabled = false;
                ButtonValider.Visible = true;
                groupBoxLogin.Enabled = true;
                ComboBoxTypeEmp.Text = "User";
            }
            else if (ComboBoxFon.Text == "Autres")
            {
                TextBoxINPE.Enabled = false;
                ButtonValider.Visible = false;
                groupBoxLogin.Enabled = false;
                ComboBoxTypeEmp.Text = "User";
            }
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
