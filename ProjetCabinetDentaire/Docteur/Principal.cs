using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjetCabinetDentaire.Docteur
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void LogoPrincipal()
        {
            ToolTip toolTip  = new ToolTip();

            toolTip.SetToolTip(this.ButtonUsers, "Employés");
            toolTip.SetToolTip(this.ButtonProfil, "Profil");

            ActiverForm(new Logo());
            ButtonHome.Iconimage = Properties.Resources.home;
            ButtonHome.Text = "Accueil";
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            TransitionHide.HideSync(ShadowPanelProfil);
            LogoPrincipal();
        }
        public void LogoPrincipalEvent(object sender, FormClosedEventArgs e)
        {
            LogoPrincipal();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(panelMenu.Width == 220)
            {
                panelMenu.Width = 82;
                panelProfil.Visible = false;
                ShadowPanelProfil.Visible = false;
            }
            else
            {
                panelProfil.Visible = true;
                panelMenu.Width = 220;
            }
        }

        int lx, ly;
        int sw, sh;
        private void panelBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void ActiverForm(object form)
        {
            if (this.panelForm.Controls.Count > 0)
            {
                this.panelForm.Controls.RemoveAt(0);
            }

            Form fr = form as Form;
            fr.TopLevel = false;
            fr.FormBorderStyle = FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            this.panelForm.Controls.Add(fr);
            this.panelForm.Tag = fr;
            fr.Show();
        }
        private void ButtonPat_Click(object sender, EventArgs e)
        {
            Patient pt = new Patient();
            pt.FormClosed += new FormClosedEventHandler(LogoPrincipalEvent);
            ActiverForm(pt);
            ButtonPat.Active = true;
            ButtonHome.Iconimage = Properties.Resources.dentist;
            ButtonHome.Text = " Patients";
        }

        private void ButtonRDV_Click(object sender, EventArgs e)
        {
            RDV rdv = new RDV();
            rdv.FormClosed += new FormClosedEventHandler(LogoPrincipalEvent);
            rdv.ButtonClose.Visible = false;
            rdv.PanelHeaderRDV.BorderThickness = 0;
            ActiverForm(rdv);
            ButtonRDV.Active = true;
            ButtonHome.Iconimage = Properties.Resources.dentist_date;
            ButtonHome.Text = " Rendez-vous";
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonMax_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            ButtonMax.Visible = false;
            ButtonMin.Visible = true;
        }

        private void ButtonRed_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonMin_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            ButtonMax.Visible = true;
            ButtonMin.Visible = false;
        }

        private void ButtonHome_MouseDown(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ButtonMsg_Click(object sender, EventArgs e)
        {
            ListeAttente liste = new ListeAttente();
            liste.FormClosed += new FormClosedEventHandler(LogoPrincipalEvent);
            ActiverForm(liste);
            ButtonMsg.Active = true;
            ButtonHome.Iconimage = Properties.Resources.waiting_room;
            ButtonHome.Text = "Salle d'attente";
        }

        private void ButtonStat_Click(object sender, EventArgs e)
        {
            Statistiques stat = new Statistiques();
            stat.FormClosed += new FormClosedEventHandler(LogoPrincipalEvent);
            ActiverForm(stat);
            ButtonStat.Active = true;
            ButtonHome.Iconimage = Properties.Resources.statistics;
            ButtonHome.Text = " Statistiques";
        }

        private void ButtonCons_Click(object sender, EventArgs e)
        {
            Consultation cons = new Consultation();
            cons.FormClosed += new FormClosedEventHandler(LogoPrincipalEvent);
            ActiverForm(cons);
            ButtonCons.Active = true;
            ButtonHome.Iconimage = Properties.Resources.dentist;
            ButtonHome.Text = " Consultations";
        }

        private void ButtonParam_Click(object sender, EventArgs e)
        {
            TransitionShow.ShowSync(ShadowPanelProfil);
        }

        private void ImageButtonClose_Click(object sender, EventArgs e)
        {
            TransitionHide.HideSync(ShadowPanelProfil);
        }

        private void ButtonUsers_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.FormClosed += new FormClosedEventHandler(LogoPrincipalEvent);
            ActiverForm(users);

            ButtonHome.Iconimage = Properties.Resources.group;
            ButtonHome.Text = "Employés";
        }

        private void ButtonProfil_Click(object sender, EventArgs e)
        {
            Users.index = 100;
            AfficherEmp emp = new AfficherEmp();
            emp.FormBorderStyle = FormBorderStyle.None;
            emp.StartPosition = FormStartPosition.CenterParent;
            emp.ShowDialog();
        }

        private void ButtonPay_Click(object sender, EventArgs e)
        {
            StockMateriel stock = new StockMateriel();
            stock.FormClosed += new FormClosedEventHandler(LogoPrincipalEvent);
            ActiverForm(stock);
            ButtonStock.Active = true;
            ButtonHome.Iconimage = Properties.Resources.stock;
            ButtonHome.Text = " Stock Materiel";
        }

        private void ButtonDeconnect_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
