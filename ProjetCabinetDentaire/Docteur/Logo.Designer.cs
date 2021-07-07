
namespace ProjetCabinetDentaire.Docteur
{
    partial class Logo
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
            this.labelDate = new System.Windows.Forms.Label();
            this.labelHeure = new System.Windows.Forms.Label();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.panelDate = new System.Windows.Forms.Panel();
            this.Separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelDroitsReserves = new System.Windows.Forms.Label();
            this.labelVersoin = new System.Windows.Forms.Label();
            this.BoxDroitsLogo = new System.Windows.Forms.PictureBox();
            this.panelCopyright = new System.Windows.Forms.Panel();
            this.panelDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxDroitsLogo)).BeginInit();
            this.panelCopyright.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.labelDate.Location = new System.Drawing.Point(793, 63);
            this.labelDate.Margin = new System.Windows.Forms.Padding(3);
            this.labelDate.Name = "labelDate";
            this.labelDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDate.Size = new System.Drawing.Size(57, 25);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHeure
            // 
            this.labelHeure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeure.AutoSize = true;
            this.labelHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(199)))), ((int)(((byte)(178)))));
            this.labelHeure.Location = new System.Drawing.Point(803, 11);
            this.labelHeure.Margin = new System.Windows.Forms.Padding(3);
            this.labelHeure.Name = "labelHeure";
            this.labelHeure.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.labelHeure.Size = new System.Drawing.Size(138, 46);
            this.labelHeure.TabIndex = 2;
            this.labelHeure.Text = "Heure";
            this.labelHeure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerDate
            // 
            this.timerDate.Enabled = true;
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // panelDate
            // 
            this.panelDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDate.Controls.Add(this.labelHeure);
            this.panelDate.Controls.Add(this.labelDate);
            this.panelDate.Controls.Add(this.Separator);
            this.panelDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDate.Location = new System.Drawing.Point(0, 0);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(1044, 100);
            this.panelDate.TabIndex = 3;
            // 
            // Separator
            // 
            this.Separator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Separator.BackColor = System.Drawing.Color.Transparent;
            this.Separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Separator.LineThickness = 1;
            this.Separator.Location = new System.Drawing.Point(0, 82);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(1044, 35);
            this.Separator.TabIndex = 5;
            this.Separator.Transparency = 255;
            this.Separator.Vertical = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = global::ProjetCabinetDentaire.Properties.Resources.Logo_Trans;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 100);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(1044, 417);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.Location = new System.Drawing.Point(11, 8);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(106, 13);
            this.labelCopyright.TabIndex = 3;
            this.labelCopyright.Text = "Copyright © 2021";
            // 
            // labelDroitsReserves
            // 
            this.labelDroitsReserves.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDroitsReserves.AutoSize = true;
            this.labelDroitsReserves.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDroitsReserves.Location = new System.Drawing.Point(233, 8);
            this.labelDroitsReserves.Name = "labelDroitsReserves";
            this.labelDroitsReserves.Size = new System.Drawing.Size(126, 13);
            this.labelDroitsReserves.TabIndex = 4;
            this.labelDroitsReserves.Text = "Tous droits réservés.";
            // 
            // labelVersoin
            // 
            this.labelVersoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersoin.AutoSize = true;
            this.labelVersoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersoin.Location = new System.Drawing.Point(960, 8);
            this.labelVersoin.Name = "labelVersoin";
            this.labelVersoin.Size = new System.Drawing.Size(71, 13);
            this.labelVersoin.TabIndex = 5;
            this.labelVersoin.Text = "Version 1.0";
            // 
            // BoxDroitsLogo
            // 
            this.BoxDroitsLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BoxDroitsLogo.Image = global::ProjetCabinetDentaire.Properties.Resources.LogoText;
            this.BoxDroitsLogo.Location = new System.Drawing.Point(121, 4);
            this.BoxDroitsLogo.Name = "BoxDroitsLogo";
            this.BoxDroitsLogo.Size = new System.Drawing.Size(114, 22);
            this.BoxDroitsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BoxDroitsLogo.TabIndex = 6;
            this.BoxDroitsLogo.TabStop = false;
            // 
            // panelCopyright
            // 
            this.panelCopyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelCopyright.Controls.Add(this.BoxDroitsLogo);
            this.panelCopyright.Controls.Add(this.labelVersoin);
            this.panelCopyright.Controls.Add(this.labelDroitsReserves);
            this.panelCopyright.Controls.Add(this.labelCopyright);
            this.panelCopyright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCopyright.Location = new System.Drawing.Point(0, 517);
            this.panelCopyright.Name = "panelCopyright";
            this.panelCopyright.Size = new System.Drawing.Size(1044, 29);
            this.panelCopyright.TabIndex = 4;
            // 
            // Logo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 546);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.panelCopyright);
            this.Controls.Add(this.panelDate);
            this.Name = "Logo";
            this.Text = "Logo";
            this.Load += new System.EventHandler(this.Logo_Load);
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxDroitsLogo)).EndInit();
            this.panelCopyright.ResumeLayout(false);
            this.panelCopyright.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelHeure;
        private System.Windows.Forms.Timer timerDate;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelDroitsReserves;
        private System.Windows.Forms.Label labelVersoin;
        private System.Windows.Forms.PictureBox BoxDroitsLogo;
        private System.Windows.Forms.Panel panelCopyright;
        private Bunifu.Framework.UI.BunifuSeparator Separator;
    }
}