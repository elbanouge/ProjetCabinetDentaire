using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetCabinetDentaire.Docteur
{
    public partial class EnvoyerSMS : Form
    {
        public EnvoyerSMS()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Classes.Connection cnx = new Classes.Connection();
        private void EnvoyerSMS_Load(object sender, EventArgs e)
        {
            var pat = from rdv in cnx.cabinet_Dentaire.Set<rendez_vous>()
                      join pt in cnx.cabinet_Dentaire.Set<paitent>()
                          on rdv.NumPtRdv equals pt.Num_Dossier
                      join emp in cnx.cabinet_Dentaire.Set<employe>()
                          on rdv.MatRDV equals emp.Matricule
                      where rdv.ID_RDV == DetailsRDV.numrdv
                      select new
                      {
                          Nom = pt.Nom_Pat,
                          Prenom = pt.Prenom_Pat,
                          Tel = pt.Telephone_Pat,
                          NomDoc = emp.Nom_Emp,
                          PrenomDoc = emp.Prenom_Emp,
                      };

            foreach (var p in pat.ToList())
            {
                TextBoxNomPt.Text = p.Nom + " " + p.Prenom;
                TextBoxTel.Text = p.Tel;
                TextBoxDoc.Text = p.NomDoc + " " + p.PrenomDoc;
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

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonEnv_Click(object sender, EventArgs e)
        {
            //try
            //{
                var emp = cnx.cabinet_Dentaire.employe.Where(xt => xt.Num_INP == 1234).FirstOrDefault();

            //ApiKey = emp.ApiKey,
            //ApiSecret = emp.ApiSecret


            //var client = new Client(creds: new Nexmo.Api.Request.Credentials
            //{
            //    ApiKey = "4e3037f8",
            //    ApiSecret = "Mu3OhQueBx6ae0yg"
            //});
            //var results = client.SMS.Send(request: new SMS.SMSRequest
            //{
            //    from = "Vonage APIs",
            //    to = "212615764794",
            //    text = "Hello from Vonage SMS API"
            //});

            //if (results != null)
            //    {
            //        MessageBox.Show("Vous envoyé message avec succes", "Envoyer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }

            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
    }
}
