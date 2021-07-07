
namespace ProjetCabinetDentaire.Docteur
{
    partial class Bienvenue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerBn = new System.Windows.Forms.Timer(this.components);
            this.CircleProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.LabelLoad = new Guna.UI.WinForms.GunaLabel();
            this.PictureBoxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gunaLabelVal = new Guna.UI.WinForms.GunaLabel();
            this.CircleProgressBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // timerBn
            // 
            this.timerBn.Interval = 10;
            this.timerBn.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CircleProgressBar
            // 
            this.CircleProgressBar.BackColor = System.Drawing.Color.White;
            this.CircleProgressBar.Controls.Add(this.LabelLoad);
            this.CircleProgressBar.Controls.Add(this.PictureBoxLogo);
            this.CircleProgressBar.Controls.Add(this.gunaLabelVal);
            this.CircleProgressBar.FillColor = System.Drawing.Color.White;
            this.CircleProgressBar.FillThickness = 800;
            this.CircleProgressBar.Location = new System.Drawing.Point(10, -350);
            this.CircleProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.CircleProgressBar.Name = "CircleProgressBar";
            this.CircleProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.CircleProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(199)))), ((int)(((byte)(178)))));
            this.CircleProgressBar.ProgressThickness = 450;
            this.CircleProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CircleProgressBar.ShadowDecoration.Parent = this.CircleProgressBar;
            this.CircleProgressBar.Size = new System.Drawing.Size(1167, 1170);
            this.CircleProgressBar.TabIndex = 1;
            // 
            // LabelLoad
            // 
            this.LabelLoad.AutoSize = true;
            this.LabelLoad.BackColor = System.Drawing.Color.Transparent;
            this.LabelLoad.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLoad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelLoad.Location = new System.Drawing.Point(539, 670);
            this.LabelLoad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelLoad.Name = "LabelLoad";
            this.LabelLoad.Size = new System.Drawing.Size(95, 19);
            this.LabelLoad.TabIndex = 6;
            this.LabelLoad.Text = "Loading ......";
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxLogo.Image = global::ProjetCabinetDentaire.Properties.Resources.Logo_Lang;
            this.PictureBoxLogo.Location = new System.Drawing.Point(501, 491);
            this.PictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.ShadowDecoration.Parent = this.PictureBoxLogo;
            this.PictureBoxLogo.Size = new System.Drawing.Size(173, 148);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogo.TabIndex = 5;
            this.PictureBoxLogo.TabStop = false;
            // 
            // gunaLabelVal
            // 
            this.gunaLabelVal.AutoSize = true;
            this.gunaLabelVal.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabelVal.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabelVal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabelVal.Location = new System.Drawing.Point(164, 679);
            this.gunaLabelVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabelVal.Name = "gunaLabelVal";
            this.gunaLabelVal.Size = new System.Drawing.Size(60, 77);
            this.gunaLabelVal.TabIndex = 3;
            this.gunaLabelVal.Text = "0";
            // 
            // Bienvenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 455);
            this.Controls.Add(this.CircleProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bienvenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenue";
            this.Load += new System.EventHandler(this.Bienvenue_Load);
            this.CircleProgressBar.ResumeLayout(false);
            this.CircleProgressBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerBn;
        private Guna.UI2.WinForms.Guna2CircleProgressBar CircleProgressBar;
        private Guna.UI.WinForms.GunaLabel LabelLoad;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxLogo;
        private Guna.UI.WinForms.GunaLabel gunaLabelVal;
    }
}