
namespace ProjetCabinetDentaire.Docteur
{
    partial class Statistiques
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
            this.panelCopyright = new System.Windows.Forms.Panel();
            this.BoxDroitsLogo = new System.Windows.Forms.PictureBox();
            this.labelVersoin = new System.Windows.Forms.Label();
            this.labelDroitsReserves = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.PanelHeaderMsg = new Guna.UI2.WinForms.Guna2Panel();
            this.BoxReturn = new System.Windows.Forms.PictureBox();
            this.panelCopyright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxDroitsLogo)).BeginInit();
            this.PanelHeaderMsg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCopyright
            // 
            this.panelCopyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelCopyright.Controls.Add(this.BoxDroitsLogo);
            this.panelCopyright.Controls.Add(this.labelVersoin);
            this.panelCopyright.Controls.Add(this.labelDroitsReserves);
            this.panelCopyright.Controls.Add(this.labelCopyright);
            this.panelCopyright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCopyright.Location = new System.Drawing.Point(0, 532);
            this.panelCopyright.Name = "panelCopyright";
            this.panelCopyright.Size = new System.Drawing.Size(1064, 29);
            this.panelCopyright.TabIndex = 21;
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
            // labelVersoin
            // 
            this.labelVersoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersoin.AutoSize = true;
            this.labelVersoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersoin.Location = new System.Drawing.Point(980, 8);
            this.labelVersoin.Name = "labelVersoin";
            this.labelVersoin.Size = new System.Drawing.Size(71, 13);
            this.labelVersoin.TabIndex = 5;
            this.labelVersoin.Text = "Version 1.0";
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
            // PanelHeaderMsg
            // 
            this.PanelHeaderMsg.BackColor = System.Drawing.SystemColors.Control;
            this.PanelHeaderMsg.Controls.Add(this.BoxReturn);
            this.PanelHeaderMsg.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeaderMsg.Location = new System.Drawing.Point(0, 0);
            this.PanelHeaderMsg.Name = "PanelHeaderMsg";
            this.PanelHeaderMsg.ShadowDecoration.Parent = this.PanelHeaderMsg;
            this.PanelHeaderMsg.Size = new System.Drawing.Size(1064, 50);
            this.PanelHeaderMsg.TabIndex = 20;
            // 
            // BoxReturn
            // 
            this.BoxReturn.BackColor = System.Drawing.Color.Transparent;
            this.BoxReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoxReturn.Image = global::ProjetCabinetDentaire.Properties.Resources.undo;
            this.BoxReturn.Location = new System.Drawing.Point(9, 6);
            this.BoxReturn.Name = "BoxReturn";
            this.BoxReturn.Size = new System.Drawing.Size(45, 36);
            this.BoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BoxReturn.TabIndex = 14;
            this.BoxReturn.TabStop = false;
            this.BoxReturn.Click += new System.EventHandler(this.BoxReturn_Click);
            // 
            // Statistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.panelCopyright);
            this.Controls.Add(this.PanelHeaderMsg);
            this.Name = "Statistiques";
            this.Text = "Statistiques";
            this.Load += new System.EventHandler(this.Statistiques_Load);
            this.panelCopyright.ResumeLayout(false);
            this.panelCopyright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxDroitsLogo)).EndInit();
            this.PanelHeaderMsg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BoxReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCopyright;
        private System.Windows.Forms.PictureBox BoxDroitsLogo;
        private System.Windows.Forms.Label labelVersoin;
        private System.Windows.Forms.Label labelDroitsReserves;
        private System.Windows.Forms.Label labelCopyright;
        private Guna.UI2.WinForms.Guna2Panel PanelHeaderMsg;
        private System.Windows.Forms.PictureBox BoxReturn;
    }
}