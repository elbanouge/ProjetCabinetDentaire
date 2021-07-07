using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCabinetDentaire.Docteur
{
    public partial class RDV : Form
    {
        public RDV()
        {
            InitializeComponent();
        }

        Classes.Connection cnx = new Classes.Connection();
        List<FlowLayoutPanel> LstLayoutPanels = new List<FlowLayoutPanel>();
        DateTime datenow = DateTime.Today;

        public void CourantDate()
        {
            int premierjourmois = PremierDayMonth();
            int totaljourmois = DernierPremierDayMonth();

            ComboBoxMonth.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(datenow.Month);
            ComboBoxYear.Text = datenow.Year.ToString();
            AjouterLabelDay(premierjourmois, totaljourmois);
            ListRendezVous(premierjourmois);
        }
        public void NextMonth()
        {
            datenow = datenow.AddMonths(1);
            CourantDate();
        }
        public void PrevouisMonth()
        {
            datenow = datenow.AddMonths(-1);
            CourantDate();
        }
        public void Today()
        {
            datenow = DateTime.Today;
            CourantDate();
        }
        public int PremierDayMonth()
        {
            DateTime firstdateTime = new DateTime(datenow.Year, datenow.Month, 1);
            return (int)firstdateTime.DayOfWeek + 1;
        }
        public int DernierPremierDayMonth()
        {
            DateTime lastdateTime = new DateTime(datenow.Year, datenow.Month, 1);
            return lastdateTime.AddMonths(1).AddDays(-1).Day;
        }
        public void GenerPanel(int TotalDays)
        {
            flDays.Controls.Clear();
            LstLayoutPanels.Clear();
            for (int i = 1; i <= TotalDays; i++)
            {
                FlowLayoutPanel flPanel = new FlowLayoutPanel();
                flPanel.Name = "flDay" + i;
                flPanel.Size = new Size(142, 170);
                flPanel.BackColor = Color.Transparent;
                flPanel.BorderStyle = BorderStyle.FixedSingle;
                flPanel.Cursor = Cursors.Hand;
                flPanel.AutoScroll = true;
                flPanel.FlowDirection = FlowDirection.RightToLeft;
                flPanel.BackgroundImage = Properties.Resources.add;
                flPanel.BackgroundImageLayout = ImageLayout.None;

                flPanel.Click += new EventHandler(AjouterDetailsRDv_Click);
                flDays.Controls.Add(flPanel);
                LstLayoutPanels.Add(flPanel);
            }
        }
        public void AjouterLabelDay(int StartDay, int TotalDaysMonth)
        {
            foreach (FlowLayoutPanel fl in LstLayoutPanels)
            {
                fl.Controls.Clear();
                fl.Tag = 0;
                fl.BackColor = Color.White;
            }
            for (int i = 1; i <= TotalDaysMonth; i++)
            {
                Label lb = new Label();
                lb.Name = "lbDay" + i;
                lb.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lb.TextAlign = ContentAlignment.MiddleLeft;
                lb.Cursor = Cursors.Default;
                lb.Size = new Size(30, 23);
                lb.Text = i.ToString();
                LstLayoutPanels[(i - 1) + (StartDay - 1)].Tag = i;
                LstLayoutPanels[(i - 1) + (StartDay - 1)].Controls.Add(lb);

                DateTime daten = new DateTime(datenow.Year, datenow.Month, i);
                if (daten == DateTime.Today)
                {
                    LstLayoutPanels[(i - 1) + (StartDay - 1)].BackColor = Color.Gainsboro;
                }
            }
        }

        public void ListRendezVous(int StartDayNumber)
        {
            DateTime premierdate = new DateTime(datenow.Year, datenow.Month, 1);
            DateTime deuxiemedate = premierdate.AddMonths(1).AddDays(-1);

            var r = from rdv in cnx.cabinet_Dentaire.rendez_vous.Where(xt => xt.Date_RDV >= premierdate && xt.Date_RDV <= deuxiemedate) select rdv;

            foreach (var rd in r.ToList())
            {
                DateTime date = rd.Date_RDV.Value;
                LinkLabel lnl = new LinkLabel();
                lnl.Tag = rd.ID_RDV;
                lnl.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                lnl.TextAlign = ContentAlignment.MiddleLeft;
                lnl.LinkColor = Color.FromArgb(46, 171, 235);
                lnl.BackColor = Color.Transparent;
                lnl.Size = new Size(116, 23);
                lnl.Name = "link" + rd.ID_RDV;
                DateTime heure = DateTime.Parse(rd.Horaire_RDV.ToString());
                if(heure.Minute == 0)
                {
                    lnl.Text = "- " + heure.Hour + " : " + heure.Minute + "0 * " + rd.paitent.Prenom_Pat;
                }
                else
                {
                    lnl.Text = "- " + heure.Hour + " : " + heure.Minute + " * " + rd.paitent.Prenom_Pat;
                }
                lnl.Click += new EventHandler(AfficherRDV_Click);
                LstLayoutPanels[(date.Day - 1) + (StartDayNumber - 1)].Controls.Add(lnl);
            }
        }
        public void SupprimerIcons()
        {
            foreach (FlowLayoutPanel fl in LstLayoutPanels)
            {
                if (fl.Controls.Count == 0)
                {
                    fl.BackgroundImage = null;
                    fl.Enabled = false;
                }
                else
                {
                    fl.Enabled = true;
                    fl.BackgroundImage = Properties.Resources.add;
                    fl.BackgroundImageLayout = ImageLayout.None;
                }
            }
        }
        public void SupprimerDim()
        {
            int i = 0;
            int sem = 0;
            foreach (FlowLayoutPanel fl in LstLayoutPanels)
            {
                if (sem == i)
                {
                    fl.BackgroundImage = null;
                    fl.Enabled = false;
                    sem += 7;
                }
                i++;
            }
        }
        private void RDV_Load(object sender, EventArgs e)
        {
            AjouterPat pat = new AjouterPat();
            pat.RemplirAnneeDate();
            ComboBoxYear.DataSource = pat.annee;
            ComboBoxMonth.DataSource = pat.mois;
            GenerPanel(42);
            CourantDate();
            SupprimerIcons();
            SupprimerDim();
        }
        public static string combo;
        private void AfficherRDV_Click(object sender, EventArgs e)
        {
            try
            {
                DetailsRDV drdv = new DetailsRDV();

                LinkLabel llp = (LinkLabel)sender;
                int idrdv = (int)llp.Tag;

                var r = from rdv in cnx.cabinet_Dentaire.rendez_vous.Where(xt => xt.ID_RDV == idrdv) select rdv;

                foreach (var rd in r.ToList())
                {
                    drdv.IdRDV = idrdv;
                    drdv.DateTimePickerDate.Value = rd.Date_RDV.Value;
                    drdv.ComboBoxHeure.Text = rd.Horaire_RDV.Value.Hours + " :";
                    if(rd.Horaire_RDV.Value.Minutes == 0)
                    {
                        drdv.ComboBoxMinute.Text = rd.Horaire_RDV.Value.Minutes + "0 H";
                    }
                    else
                    {
                        drdv.ComboBoxMinute.Text = rd.Horaire_RDV.Value.Minutes + " H";
                    }
                    drdv.TextBoxDescr.Text = rd.Description_RDV.ToString();
                    drdv.LabelNmRDV.Text = rd.ID_RDV.ToString();
                    string pat = cnx.cabinet_Dentaire.paitent.Where(xt => xt.Num_Dossier == rd.NumPtRdv).Select(xt => xt.Prenom_Pat + " " + xt.Nom_Pat + " | " + xt.Num_Dossier).FirstOrDefault();
                    drdv.TextBoxPat.Text = pat;

                    drdv.FormBorderStyle = FormBorderStyle.None;
                    drdv.ShowDialog();
                    CourantDate();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void AjouterDetailsRDv_Click(object sender, EventArgs e)
        {
            try
            {
                DetailsRDV hrdv = new DetailsRDV();
                FlowLayoutPanel flp = (FlowLayoutPanel)sender;
                int day = (int)flp.Tag;

                if (day != 0)
                {
                    hrdv.IdRDV = 0;
                    hrdv.TextBoxPat.Text = "";
                    hrdv.TextBoxDescr.Clear();

                    hrdv.DateTimePickerDate.Value = new DateTime(datenow.Year, datenow.Month, day);
                    hrdv.FormBorderStyle = FormBorderStyle.None;
                    hrdv.ShowDialog();
                    CourantDate();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : " + exc.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BoxReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonPreveuis_Click(object sender, EventArgs e)
        {
            PrevouisMonth();
            SupprimerIcons();
            SupprimerDim();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            NextMonth();
            SupprimerIcons();
            SupprimerDim();
        }

        private void ButtonToday_Click(object sender, EventArgs e)
        {
            Today();
            SupprimerIcons();
            SupprimerDim();
        }

        private void ButtonSearchDate_Click(object sender, EventArgs e)
        {
            datenow = DateTime.Parse("01/" + ComboBoxMonth.Text + "/" + ComboBoxYear.Text);
            CourantDate();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
