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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez vous quiter l'application", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                timerLogin.Start();
            }
        }

        private void pictureBoxShowHide_Click(object sender, EventArgs e)
        {
            if(TextBoxPass.UseSystemPasswordChar == true)
            {
                pictureBoxShowHide.Image = ProjetCabinetDentaire.Properties.Resources._private;
                TextBoxPass.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBoxShowHide.Image = ProjetCabinetDentaire.Properties.Resources.show;
                TextBoxPass.UseSystemPasswordChar = true;
            }
        }

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            Bienvenue pr = new Bienvenue();
            this.Hide();
            pr.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                Application.Exit();
            }
        }
        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBoxBack_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
