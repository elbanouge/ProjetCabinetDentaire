using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCabinetDentaire.Docteur
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        Classes.Connection cnx = new Classes.Connection();
        public void RemlpirListeEmp()
        {
            try
            {
                var em = from emp in cnx.cabinet_Dentaire.employe select new { emp.Photo_Emp, emp.Matricule, emp.Prenom_Emp, emp.Nom_Emp, emp.Type_Emp, emp.Telephone_Emp, emp.Date_Naissance_Emp, emp.Num_INP };

                dataGridViewListeEmployes.Rows.Clear();
                foreach (var emp in em.ToList())
                {
                    dataGridViewListeEmployes.Rows.Add(emp.Photo_Emp, emp.Matricule, emp.Prenom_Emp, emp.Nom_Emp, emp.Type_Emp, emp.Telephone_Emp, emp.Date_Naissance_Emp, "0" + emp.Num_INP);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static int index = -1;

        private void Users_Load(object sender, EventArgs e)
        {
            RemlpirListeEmp();
        }

        private void BoxReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void RechercheEmploye()
        {
            try
            {
                dataGridViewListeEmployes.Rows.Clear();

                var em = from emp in cnx.cabinet_Dentaire.employe select new { emp.Photo_Emp, emp.Matricule, emp.Prenom_Emp, emp.Nom_Emp, emp.Num_INP, emp.Date_Naissance_Emp, emp.Telephone_Emp, emp.Type_Emp };

                foreach (var emp in em.ToList())
                {
                    if (emp.Type_Emp.ToLower().StartsWith(TextBoxSearch.Text.ToLower()) || emp.Nom_Emp.ToLower().StartsWith(TextBoxSearch.Text.ToLower()) || emp.Prenom_Emp.ToLower().StartsWith(TextBoxSearch.Text.ToLower()))
                    {
                        dataGridViewListeEmployes.Rows.Add(emp.Photo_Emp, emp.Matricule, emp.Prenom_Emp, emp.Nom_Emp, emp.Num_INP, emp.Date_Naissance_Emp, emp.Telephone_Emp);
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
                RechercheEmploye();
            }
            else
            {
                RechercheEmploye();
            }
        }

        private void ButtonRech_Click(object sender, EventArgs e)
        {
            RechercheEmploye();
        }

        private void pictureBoxAcc_Click(object sender, EventArgs e)
        {
            RemlpirListeEmp();
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                AjouterEmp emp = new AjouterEmp();
                emp.FormBorderStyle = FormBorderStyle.None;
                emp.StartPosition = FormStartPosition.CenterParent;
                emp.ShowDialog();

                if (AjouterEmp.bl == true)
                {
                    RemlpirListeEmp();
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
                if (dataGridViewListeEmployes.Rows.Count > 0)
                {
                    if (MessageBox.Show("Vous êtes en train supprimé un ou plusieurs employe", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        index = int.Parse(dataGridViewListeEmployes.SelectedCells[1].Value.ToString());

                        employe emp = cnx.cabinet_Dentaire.employe.FirstOrDefault(xt => xt.Matricule == index);

                        if (emp != null)
                        {
                            cnx.cabinet_Dentaire.employe.Remove(emp);
                            cnx.cabinet_Dentaire.SaveChanges();
                        }
                        MessageBox.Show("Vous avez supprimé employe numéro " + index + " avec succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RemlpirListeEmp();
                    }
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
                if (dataGridViewListeEmployes.Rows.Count > 0)
                {
                    index = int.Parse(dataGridViewListeEmployes.CurrentRow.Cells[1].Value.ToString());
                    if (index != 0)
                    {
                        AfficherEmp profil = new AfficherEmp();
                        profil.FormBorderStyle = FormBorderStyle.None;
                        profil.StartPosition = FormStartPosition.CenterParent;
                        profil.ShowDialog();

                        if (AfficherEmp.bl == true)
                        {
                            RemlpirListeEmp();
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewListeEmployes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewListeEmployes.Rows.Count > 0)
                {
                    index = int.Parse(dataGridViewListeEmployes.CurrentRow.Cells[1].Value.ToString());
                    if (index != 0)
                    {
                        AfficherEmp profil = new AfficherEmp();
                        profil.FormBorderStyle = FormBorderStyle.None;
                        profil.StartPosition = FormStartPosition.CenterParent;
                        profil.ShowDialog();

                        if (AfficherEmp.bl == true)
                        {
                            RemlpirListeEmp();
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
