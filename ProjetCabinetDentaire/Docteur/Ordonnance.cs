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
    public partial class Ordonnance : Form
    {
        public Ordonnance()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        Classes.Connection cnx = new Classes.Connection();
        public static int index = -1;

        public void RemlpirListeOrd()
        {
            try
            {
                var o = from ord in cnx.cabinet_Dentaire.medicament_details select new { ord.ID_Med, ord.Nom_Med, ord.Quantite };

                dataGridViewListeOrd.Rows.Clear();
                foreach (var ord in o.ToList())
                {
                    dataGridViewListeOrd.Rows.Add(ord.ID_Med, ord.Nom_Med, ord.Quantite);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static bool bl = false;
        private void Ordonnance_Load(object sender, EventArgs e)
        {
            RemlpirListeOrd();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBoxAcc_Click(object sender, EventArgs e)
        {
            RemlpirListeOrd();
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                AjouterOrd ajp = new AjouterOrd();
                ajp.FormBorderStyle = FormBorderStyle.None;
                ajp.StartPosition = FormStartPosition.CenterParent;
                ajp.ShowDialog();
                if (AjouterOrd.bl == true)
                {
                    RemlpirListeOrd();
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
                if (dataGridViewListeOrd.Rows.Count > 0)
                {
                    index = int.Parse(dataGridViewListeOrd.CurrentRow.Cells[0].Value.ToString());
                    if (index != 0)
                    {
                        AfficherOrd afficher = new AfficherOrd();
                        afficher.FormBorderStyle = FormBorderStyle.None;
                        afficher.StartPosition = FormStartPosition.CenterParent;
                        afficher.ShowDialog();
                        if (AfficherOrd.bl == true)
                        {
                            RemlpirListeOrd();
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewListeOrd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewListeOrd.Rows.Count > 0)
                {
                    index = int.Parse(dataGridViewListeOrd.CurrentRow.Cells[0].Value.ToString());
                    if (index != 0)
                    {
                        AfficherOrd afficher = new AfficherOrd();
                        afficher.FormBorderStyle = FormBorderStyle.None;
                        afficher.StartPosition = FormStartPosition.CenterParent;
                        afficher.ShowDialog();
                        if (AfficherOrd.bl == true)
                        {
                            RemlpirListeOrd();
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
                if (dataGridViewListeOrd.Rows.Count > 0)
                {
                    if (MessageBox.Show("Vous êtes en train supprimé un ou plusieurs médicaments ", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        index = int.Parse(dataGridViewListeOrd.SelectedCells[0].Value.ToString());

                        medicament_details medicament = cnx.cabinet_Dentaire.medicament_details.FirstOrDefault(xt => xt.ID_Med == index);

                        if (medicament != null)
                        {
                            cnx.cabinet_Dentaire.medicament_details.Remove(medicament);
                            cnx.cabinet_Dentaire.SaveChanges();
                        }
                        MessageBox.Show("Vous avez supprimé médicament numéro " + index + " avec succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RemlpirListeOrd();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void RechercheOrdonnance()
        {
            try
            {
                var o = from ord in cnx.cabinet_Dentaire.medicament_details select new { ord.ID_Med, ord.Nom_Med, ord.Quantite };

                dataGridViewListeOrd.Rows.Clear();
                foreach (var ord in o.ToList())
                {
                    if (ord.Nom_Med.ToLower().StartsWith(TextBoxSearch.Text.ToLower()))
                    {
                        dataGridViewListeOrd.Rows.Add(ord.ID_Med, ord.Nom_Med, ord.Quantite);
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
                RechercheOrdonnance();
            }
            else
            {
                RemlpirListeOrd();
            }
        }

        private void ButtonRech_Click(object sender, EventArgs e)
        {
            RechercheOrdonnance();
        }
    }
}
