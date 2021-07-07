using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCabinetDentaire.Docteur
{
    public partial class NouveauConsultation : Form
    {
        public NouveauConsultation()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        Classes.Connection cnx = new Classes.Connection();

        public static int numdent = 0;
        public static bool bl = false;
        DetailsRDV RDV = new DetailsRDV();
        private void NouveauConsultation_Load(object sender, EventArgs e)
        {
            ComboBoxServices.DataSource = cnx.cabinet_Dentaire.service_employe.Select(xt => xt.Nom_Ser).ToList();
            ComboBoxOrd.DataSource = cnx.cabinet_Dentaire.medicament_details.Select(xt => xt.Nom_Med).ToList();

            RDV.RecherchePat(TextBoxNom);
            if (RadioButtonAdulte.Checked == true)
            {
                GroupBoxAdulte.Visible = true;
                GroupBoxAdulte.Location = new Point(18, 45);
                GroupBoxEnfant.Visible = false;
            }
            else if (RadioButtonEnfant.Checked == true)
            {
                GroupBoxAdulte.Visible = false;
                GroupBoxEnfant.Visible = true;
                GroupBoxEnfant.Location = new Point(18, 45);
            }
            DateTimePickerCons.Value = DateTime.Now;
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RadioButtonAdulte_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonAdulte.Checked == true)
            {
                GroupBoxAdulte.Visible = true;
                GroupBoxAdulte.Location = new Point(18, 45);
                GroupBoxEnfant.Visible = false;
            }
            else if (RadioButtonEnfant.Checked == true)
            {
                GroupBoxAdulte.Visible = false;
                GroupBoxEnfant.Visible = true;
                GroupBoxEnfant.Location = new Point(18, 45);
            }
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ImageButtonServiceAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AjouterService ajp = new AjouterService();
                ajp.FormBorderStyle = FormBorderStyle.None;
                ajp.StartPosition = FormStartPosition.CenterParent;
                ajp.ShowDialog();
                if (AjouterService.bl == true)
                {
                    ComboBoxServices.DataSource = cnx.cabinet_Dentaire.service_employe.Select(xt => xt.Nom_Ser).ToList();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Dent_55_Click(object sender, EventArgs e)
        {
            Dent_55.Image = Properties.Resources.ToothFail;
            string[] dent = Dent_55.Name.Split('_');
            numdent = int.Parse(dent[1]);
        }

        private void Dent_55_DoubleClick(object sender, EventArgs e)
        {
            Dent_55.Image = Properties.Resources._55;
        }

        AjouterPat ajouterPat = new AjouterPat();
        private void ButtonValider_Click(object sender, EventArgs e)
        {
            traiter trt = new traiter();

            bool nomcomplet = ajouterPat.VerText(TextBoxNom.Text);
            decimal MontPaye;
            bool MontPayeB = decimal.TryParse(TextBoxMontPaye.Text, out MontPaye); 
            decimal MontRecu;
            bool MontRecuB = decimal.TryParse(TextBoxMontantRecu.Text, out MontRecu); 
            decimal MontReste;
            bool MontResteB = decimal.TryParse(TextBoxMontantReste.Text, out MontReste);

            try
            {
                if (nomcomplet == true && MontPayeB == true && MontRecuB == true && MontResteB == true)
                {
                    int doc = cnx.cabinet_Dentaire.employe.Where(xt => xt.Num_INP == 34175323).Select(xt => xt.Matricule).FirstOrDefault();
                    trt.MatTrEmp = doc;

                    int idser = cnx.cabinet_Dentaire.service_employe.Where(xt => xt.Nom_Ser == ComboBoxServices.Text).Select(xt => xt.ID_Ser).FirstOrDefault();
                    trt.IDTrSer = idser;

                    string[] numpat = TextBoxNom.Text.Split('|');
                    int pat = int.Parse(numpat[1].Trim());
                    trt.NumTrPat = pat;

                        diagnostique diag = new diagnostique();

                        diag.Date_Diag = DateTimePickerCons.Value;

                            medicament_details ord = new medicament_details();

                            int qteOrd = cnx.cabinet_Dentaire.medicament_details.Where(xt => xt.Nom_Med == ComboBoxOrd.Text).Select(xt => xt.Quantite).FirstOrDefault();

                            ord.Nom_Med = ComboBoxOrd.Text;
                            ord.Quantite = qteOrd;
                            cnx.cabinet_Dentaire.medicament_details.Add(ord);

                            int idOrd = cnx.cabinet_Dentaire.medicament_details.Max(p => p.ID_Med);

                        diag.IdMedDiag = idOrd;

                            dent dent = new dent();
                            dent.Num_Dent = numdent;
                            cnx.cabinet_Dentaire.dent.Add(dent);
                    
                            int idDent = cnx.cabinet_Dentaire.dent.Max(p => p.ID_Dt);

                        diag.IdDentDiag = idDent;
                        cnx.cabinet_Dentaire.diagnostique.Add(diag);

                        int idDiag = cnx.cabinet_Dentaire.diagnostique.Max(p => p.ID_Diag);

                    trt.IDTrDiag = idDiag;
                    cnx.cabinet_Dentaire.traiter.Add(trt);

                    scanner scan = new scanner();
                    scan.IdScDiag = idDiag;
                    if (openFileDialog.FileName != "")
                    {
                        System.IO.FileStream fs = new FileStream(pictureBoxImg.ImageLocation, FileMode.Open, FileAccess.Read);
                        byte[] t = new byte[fs.Length];
                        fs.Read(t, 0, (int)fs.Length);

                        scan.Image_Scan = t;
                    }
                    else
                    {
                        scan.Image_Scan = null;
                    }

                    cnx.cabinet_Dentaire.scanner.Add(scan);

                    payement pay = new payement();

                    pay.MontantPay = MontPaye;
                    pay.Avance = MontRecu;
                    pay.Datepay = DateTimePickerCons.Value;
                    pay.IdPyDiag = idDiag;

                    cnx.cabinet_Dentaire.payement.Add(pay);

                    cnx.cabinet_Dentaire.SaveChanges();
                    bl = true;
                    MessageBox.Show("Vous avez ajouté une consultation avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ajouterPat.ViderChamps(this);
                }
                else if (nomcomplet == false)
                {
                    LabelErreur.Visible = true;
                    LabelErreur.Text = "* Ce champ nom employe est obligatoire.";
                }
                else if (MontPayeB == false)
                {
                    LabelErreur.Visible = true;
                    LabelErreur.Text = "* Ce champ prénom employe est obligatoire.";
                }
                else if (MontRecuB == false)
                {
                    LabelErreur.Visible = true;
                    LabelErreur.Text = "* Ce champ carte d'identité nationale employe est obligatoire.";
                }
                else if (MontResteB == false)
                {
                    LabelErreur.Visible = true;
                    LabelErreur.Text = "* Vérifie format de champ carte d'identité nationale employe.";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ComboBoxServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            service_employe ser = cnx.cabinet_Dentaire.service_employe.Where(xt => xt.Nom_Ser == ComboBoxServices.Text).FirstOrDefault();
            TextBoxMontPaye.Text = ser.Prix_Origine.ToString();
        }

        private void ButtonAddOrd_Click(object sender, EventArgs e)
        {
            try
            {
                Ordonnance ord = new Ordonnance();
                ord.FormBorderStyle = FormBorderStyle.None;
                ord.StartPosition = FormStartPosition.CenterParent;
                ord.ShowDialog();
                if (Ordonnance.bl == true)
                {
                    ComboBoxOrd.DataSource = cnx.cabinet_Dentaire.medicament_details.Select(xt => xt.Nom_Med).ToList();
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

        private void TextBoxMontPaye_TextChanged(object sender, EventArgs e)
        {
            decimal MontPaye;
            bool MontPayeB = decimal.TryParse(TextBoxMontPaye.Text, out MontPaye);
            decimal MontRecu;
            bool MontRecuB = decimal.TryParse(TextBoxMontantRecu.Text, out MontRecu);
            decimal MontReste;
            bool MontResteB = decimal.TryParse(TextBoxMontantReste.Text, out MontReste);


            if (TextBoxMontPaye.Text.Trim() !="" && TextBoxMontantRecu.Text.Trim() != "")
            {
                if (MontPayeB == true && MontRecuB == true && MontResteB == true)
                {
                    MontReste = MontPaye - MontRecu;
                    TextBoxMontantReste.Text = MontReste.ToString();
                }
            }
        }

        private void TextBoxMontantRecu_TextChanged(object sender, EventArgs e)
        {
            decimal MontPaye;
            bool MontPayeB = decimal.TryParse(TextBoxMontPaye.Text, out MontPaye);
            decimal MontRecu;
            bool MontRecuB = decimal.TryParse(TextBoxMontantRecu.Text, out MontRecu);
            decimal MontReste;
            bool MontResteB = decimal.TryParse(TextBoxMontantReste.Text, out MontReste);


            if (TextBoxMontPaye.Text.Trim() != "" && TextBoxMontantRecu.Text.Trim() != "")
            {
                if (MontPayeB == true && MontRecuB == true && MontResteB == true)
                {
                    MontReste = MontPaye - MontRecu;
                    TextBoxMontantReste.Text = MontReste.ToString();
                }
            }
        }
    }
}
