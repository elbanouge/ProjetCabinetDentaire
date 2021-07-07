using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCabinetDentaire.Docteur
{
    public partial class AjouterService : Form
    {
        public AjouterService()
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
        private void AjouterService_Load(object sender, EventArgs e)
        {
            this.ActiveControl = TextBoxNomServ;
        }
        private void ButtonValider_Click(object sender, EventArgs e)
        {
            service_employe service = new service_employe();

            bool nomserv = pat.VerText(TextBoxNomServ.Text);
            decimal prixor;
            bool prixorb = decimal.TryParse(TextBoxPrixOrd.Text, out prixor);

            try
            {
                if (nomserv == true && prixorb == true )
                {
                    service.Nom_Ser = TextBoxNomServ.Text;
                    service.Prix_Origine = prixor;
                    service.Description_Ser = TextBoxDescr.Text;
                    int doc = cnx.cabinet_Dentaire.employe.Where(xt => xt.Num_INP == 34175323).Select(xt => xt.Matricule).FirstOrDefault();
                    service.MatServ = doc;

                    cnx.cabinet_Dentaire.service_employe.Add(service);
                    cnx.cabinet_Dentaire.SaveChanges();

                    bl = true;
                    MessageBox.Show("Vous avez ajouté un service avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pat.ViderChamps(this);
                    this.Close();
                }
                else if (nomserv == false)
                {
                    LabelErreur.Visible = true;
                    LabelErreur.Text = "* Ce champ nature d'operation est obligatoire.";
                }
                else if (prixorb == false)
                {
                    LabelErreur.Visible = true;
                    LabelErreur.Text = "* Ce champ prix origine est obligatoire ou vérifier le prix saisis";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxNomServ_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void TextBoxPrixOrd_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonVider_Click(object sender, EventArgs e)
        {
            pat.ViderChamps(this);
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
