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
    public partial class AjouterOrd : Form
    {
        public AjouterOrd()
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
        private void AjouterOrd_Load(object sender, EventArgs e)
        {
            this.ActiveControl = TextBoxNomMed;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonVider_Click(object sender, EventArgs e)
        {
            pat.ViderChamps(this);
        }

        private void ButtonValider_Click(object sender, EventArgs e)
        {
            medicament_details medicament = new medicament_details();

            bool nomord = pat.VerText(TextBoxNomMed.Text);
            int qteord;
            bool qteordb = int.TryParse(TextBoxQteOrd.Text, out qteord);

            try
            {
                if (nomord == true && qteordb == true)
                {
                    medicament.Nom_Med = TextBoxNomMed.Text;
                    if(qteordb == false)
                    {
                        medicament.Quantite = 0;
                    }
                    else
                    {
                        medicament.Quantite = qteord;
                    }
                    medicament.Description_Med = TextBoxDescr.Text;

                    cnx.cabinet_Dentaire.medicament_details.Add(medicament);
                    cnx.cabinet_Dentaire.SaveChanges();

                    bl = true;
                    MessageBox.Show("Vous avez ajouté un service avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pat.ViderChamps(this);
                    this.Close();
                }
                else if (nomord == false)
                {
                    LabelErreur.Visible = true;
                    LabelErreur.Text = "* Ce champ nom médicament est obligatoire.";
                }
                else if (qteordb == false)
                {
                    LabelErreur.Visible = true;
                    LabelErreur.Text = "* Vérifier le champ quantité qui saisis";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TextBoxNomMed_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void TextBoxQteOrd_TextChanged(object sender, EventArgs e)
        {
            LabelErreur.Visible = false;
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
