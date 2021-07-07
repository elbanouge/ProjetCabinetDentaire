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
    public partial class ServicesEmp : Form
    {
        public ServicesEmp()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        Classes.Connection cnx = new Classes.Connection();
        public void RemlpirListeServ()
        {
            try
            {
                var s = from ser in cnx.cabinet_Dentaire.service_employe select new { ser.ID_Ser, ser.Nom_Ser, ser.Prix_Origine };

                dataGridViewListeServices.Rows.Clear();
                foreach (var ser in s.ToList())
                {
                    dataGridViewListeServices.Rows.Add(ser.ID_Ser, ser.Nom_Ser, ser.Prix_Origine);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static int index = -1;
        private void ServicesEmp_Load(object sender, EventArgs e)
        {
            RemlpirListeServ();
        }
        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                AjouterService ajp = new AjouterService();
                ajp.FormBorderStyle = FormBorderStyle.None;
                ajp.StartPosition = FormStartPosition.CenterParent;
                ajp.ShowDialog();
                if (AjouterService.bl == true)
                {
                    RemlpirListeServ();
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
                if (dataGridViewListeServices.Rows.Count > 0)
                {
                    index = int.Parse(dataGridViewListeServices.CurrentRow.Cells[0].Value.ToString());
                    if (index != 0)
                    {
                        AfficherService afficher = new AfficherService();
                        afficher.FormBorderStyle = FormBorderStyle.None;
                        afficher.StartPosition = FormStartPosition.CenterParent;
                        afficher.ShowDialog();
                        if (AfficherService.bl == true)
                        {
                            RemlpirListeServ();
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewListeServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewListeServices.Rows.Count > 0)
                {
                    index = int.Parse(dataGridViewListeServices.CurrentRow.Cells[0].Value.ToString());
                    if (index != 0)
                    {
                        AfficherService afficher = new AfficherService();
                        afficher.FormBorderStyle = FormBorderStyle.None;
                        afficher.StartPosition = FormStartPosition.CenterParent;
                        afficher.ShowDialog();
                        if (AfficherService.bl == true)
                        {
                            RemlpirListeServ();
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
                if (dataGridViewListeServices.Rows.Count > 0)
                {
                    if (MessageBox.Show("Vous êtes en train supprimé un ou plusieurs services ", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        index = int.Parse(dataGridViewListeServices.SelectedCells[0].Value.ToString());

                        service_employe service = cnx.cabinet_Dentaire.service_employe.FirstOrDefault(xt => xt.ID_Ser == index);

                        if (service != null)
                        {
                            cnx.cabinet_Dentaire.service_employe.Remove(service);
                            cnx.cabinet_Dentaire.SaveChanges();
                        }
                        MessageBox.Show("Vous avez supprimé service numéro " + index + " avec succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RemlpirListeServ();
                    }
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

        private void pictureBoxAcc_Click(object sender, EventArgs e)
        {
            RemlpirListeServ();
        }

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
