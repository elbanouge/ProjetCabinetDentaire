
namespace ProjetCabinetDentaire.Docteur
{
    partial class EnvoyerSMS
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.ButtonClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ButtonTitle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TextBoxNomPt = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxTel = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxDoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxMesg = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonAnnuler = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonEnv = new Guna.UI2.WinForms.Guna2Button();
            this.LabelMesg = new Guna.UI.WinForms.GunaLabel();
            this.LabelDe = new Guna.UI.WinForms.GunaLabel();
            this.LabelTel = new Guna.UI.WinForms.GunaLabel();
            this.LabelNom = new Guna.UI.WinForms.GunaLabel();
            this.panelContent.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.panelHeader);
            this.panelContent.Controls.Add(this.TextBoxNomPt);
            this.panelContent.Controls.Add(this.TextBoxTel);
            this.panelContent.Controls.Add(this.TextBoxDoc);
            this.panelContent.Controls.Add(this.TextBoxMesg);
            this.panelContent.Controls.Add(this.ButtonAnnuler);
            this.panelContent.Controls.Add(this.ButtonEnv);
            this.panelContent.Controls.Add(this.LabelMesg);
            this.panelContent.Controls.Add(this.LabelDe);
            this.panelContent.Controls.Add(this.LabelTel);
            this.panelContent.Controls.Add(this.LabelNom);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(534, 449);
            this.panelContent.TabIndex = 258;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.ButtonClose);
            this.panelHeader.Controls.Add(this.ButtonTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(532, 48);
            this.panelHeader.TabIndex = 268;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.CheckedState.Parent = this.ButtonClose;
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonClose.HoverState.Parent = this.ButtonClose;
            this.ButtonClose.Image = global::ProjetCabinetDentaire.Properties.Resources.close;
            this.ButtonClose.ImageSize = new System.Drawing.Size(35, 35);
            this.ButtonClose.Location = new System.Drawing.Point(477, 2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.PressedState.Parent = this.ButtonClose;
            this.ButtonClose.Size = new System.Drawing.Size(50, 41);
            this.ButtonClose.TabIndex = 30;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonTitle
            // 
            this.ButtonTitle.Active = false;
            this.ButtonTitle.Activecolor = System.Drawing.Color.Transparent;
            this.ButtonTitle.BackColor = System.Drawing.Color.Transparent;
            this.ButtonTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonTitle.BorderRadius = 0;
            this.ButtonTitle.ButtonText = "Envoyer SMS a un patient";
            this.ButtonTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonTitle.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonTitle.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonTitle.Iconimage = global::ProjetCabinetDentaire.Properties.Resources.dentist_date;
            this.ButtonTitle.Iconimage_right = null;
            this.ButtonTitle.Iconimage_right_Selected = null;
            this.ButtonTitle.Iconimage_Selected = null;
            this.ButtonTitle.IconMarginLeft = 20;
            this.ButtonTitle.IconMarginRight = 0;
            this.ButtonTitle.IconRightVisible = true;
            this.ButtonTitle.IconRightZoom = 0D;
            this.ButtonTitle.IconVisible = true;
            this.ButtonTitle.IconZoom = 70D;
            this.ButtonTitle.IsTab = false;
            this.ButtonTitle.Location = new System.Drawing.Point(3, 2);
            this.ButtonTitle.Name = "ButtonTitle";
            this.ButtonTitle.Normalcolor = System.Drawing.Color.Transparent;
            this.ButtonTitle.OnHovercolor = System.Drawing.Color.Transparent;
            this.ButtonTitle.OnHoverTextColor = System.Drawing.Color.Black;
            this.ButtonTitle.selected = false;
            this.ButtonTitle.Size = new System.Drawing.Size(295, 41);
            this.ButtonTitle.TabIndex = 29;
            this.ButtonTitle.Text = "Envoyer SMS a un patient";
            this.ButtonTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonTitle.Textcolor = System.Drawing.Color.Black;
            this.ButtonTitle.TextFont = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonTitle.MouseDown += new System.EventHandler(this.ButtonTitle_MouseDown);
            // 
            // TextBoxNomPt
            // 
            this.TextBoxNomPt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.TextBoxNomPt.BorderRadius = 5;
            this.TextBoxNomPt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxNomPt.DefaultText = "";
            this.TextBoxNomPt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxNomPt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxNomPt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNomPt.DisabledState.Parent = this.TextBoxNomPt;
            this.TextBoxNomPt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNomPt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.TextBoxNomPt.FocusedState.Parent = this.TextBoxNomPt;
            this.TextBoxNomPt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.TextBoxNomPt.ForeColor = System.Drawing.Color.Black;
            this.TextBoxNomPt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxNomPt.HoverState.Parent = this.TextBoxNomPt;
            this.TextBoxNomPt.Location = new System.Drawing.Point(193, 80);
            this.TextBoxNomPt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxNomPt.Name = "TextBoxNomPt";
            this.TextBoxNomPt.PasswordChar = '\0';
            this.TextBoxNomPt.PlaceholderText = "";
            this.TextBoxNomPt.SelectedText = "";
            this.TextBoxNomPt.ShadowDecoration.Parent = this.TextBoxNomPt;
            this.TextBoxNomPt.Size = new System.Drawing.Size(281, 36);
            this.TextBoxNomPt.TabIndex = 267;
            this.TextBoxNomPt.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // TextBoxTel
            // 
            this.TextBoxTel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.TextBoxTel.BorderRadius = 5;
            this.TextBoxTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxTel.DefaultText = "";
            this.TextBoxTel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxTel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxTel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTel.DisabledState.Parent = this.TextBoxTel;
            this.TextBoxTel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.TextBoxTel.FocusedState.Parent = this.TextBoxTel;
            this.TextBoxTel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.TextBoxTel.ForeColor = System.Drawing.Color.Black;
            this.TextBoxTel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTel.HoverState.Parent = this.TextBoxTel;
            this.TextBoxTel.Location = new System.Drawing.Point(193, 136);
            this.TextBoxTel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxTel.Name = "TextBoxTel";
            this.TextBoxTel.PasswordChar = '\0';
            this.TextBoxTel.PlaceholderText = "";
            this.TextBoxTel.SelectedText = "";
            this.TextBoxTel.ShadowDecoration.Parent = this.TextBoxTel;
            this.TextBoxTel.Size = new System.Drawing.Size(281, 36);
            this.TextBoxTel.TabIndex = 266;
            this.TextBoxTel.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // TextBoxDoc
            // 
            this.TextBoxDoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.TextBoxDoc.BorderRadius = 5;
            this.TextBoxDoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDoc.DefaultText = "";
            this.TextBoxDoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxDoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxDoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDoc.DisabledState.Parent = this.TextBoxDoc;
            this.TextBoxDoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.TextBoxDoc.FocusedState.Parent = this.TextBoxDoc;
            this.TextBoxDoc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.TextBoxDoc.ForeColor = System.Drawing.Color.Black;
            this.TextBoxDoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDoc.HoverState.Parent = this.TextBoxDoc;
            this.TextBoxDoc.Location = new System.Drawing.Point(193, 197);
            this.TextBoxDoc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxDoc.Name = "TextBoxDoc";
            this.TextBoxDoc.PasswordChar = '\0';
            this.TextBoxDoc.PlaceholderText = "";
            this.TextBoxDoc.SelectedText = "";
            this.TextBoxDoc.ShadowDecoration.Parent = this.TextBoxDoc;
            this.TextBoxDoc.Size = new System.Drawing.Size(281, 36);
            this.TextBoxDoc.TabIndex = 265;
            this.TextBoxDoc.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // TextBoxMesg
            // 
            this.TextBoxMesg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.TextBoxMesg.BorderRadius = 5;
            this.TextBoxMesg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxMesg.DefaultText = "";
            this.TextBoxMesg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxMesg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxMesg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxMesg.DisabledState.Parent = this.TextBoxMesg;
            this.TextBoxMesg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxMesg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.TextBoxMesg.FocusedState.Parent = this.TextBoxMesg;
            this.TextBoxMesg.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.TextBoxMesg.ForeColor = System.Drawing.Color.Black;
            this.TextBoxMesg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxMesg.HoverState.Parent = this.TextBoxMesg;
            this.TextBoxMesg.Location = new System.Drawing.Point(193, 260);
            this.TextBoxMesg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxMesg.Multiline = true;
            this.TextBoxMesg.Name = "TextBoxMesg";
            this.TextBoxMesg.PasswordChar = '\0';
            this.TextBoxMesg.PlaceholderText = "";
            this.TextBoxMesg.SelectedText = "";
            this.TextBoxMesg.ShadowDecoration.Parent = this.TextBoxMesg;
            this.TextBoxMesg.Size = new System.Drawing.Size(281, 100);
            this.TextBoxMesg.TabIndex = 264;
            this.TextBoxMesg.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // ButtonAnnuler
            // 
            this.ButtonAnnuler.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonAnnuler.BorderColor = System.Drawing.Color.Gray;
            this.ButtonAnnuler.BorderRadius = 5;
            this.ButtonAnnuler.BorderThickness = 1;
            this.ButtonAnnuler.CheckedState.Parent = this.ButtonAnnuler;
            this.ButtonAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAnnuler.CustomImages.Parent = this.ButtonAnnuler;
            this.ButtonAnnuler.FillColor = System.Drawing.Color.Transparent;
            this.ButtonAnnuler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAnnuler.ForeColor = System.Drawing.Color.Gray;
            this.ButtonAnnuler.HoverState.FillColor = System.Drawing.Color.Gray;
            this.ButtonAnnuler.HoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonAnnuler.HoverState.Parent = this.ButtonAnnuler;
            this.ButtonAnnuler.Location = new System.Drawing.Point(135, 392);
            this.ButtonAnnuler.Name = "ButtonAnnuler";
            this.ButtonAnnuler.ShadowDecoration.Parent = this.ButtonAnnuler;
            this.ButtonAnnuler.Size = new System.Drawing.Size(107, 35);
            this.ButtonAnnuler.TabIndex = 263;
            this.ButtonAnnuler.Text = "Annuler";
            this.ButtonAnnuler.Click += new System.EventHandler(this.ButtonAnnuler_Click);
            // 
            // ButtonEnv
            // 
            this.ButtonEnv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEnv.BorderColor = System.Drawing.Color.LimeGreen;
            this.ButtonEnv.BorderRadius = 5;
            this.ButtonEnv.BorderThickness = 1;
            this.ButtonEnv.CheckedState.Parent = this.ButtonEnv;
            this.ButtonEnv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEnv.CustomImages.Parent = this.ButtonEnv;
            this.ButtonEnv.FillColor = System.Drawing.Color.Transparent;
            this.ButtonEnv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonEnv.ForeColor = System.Drawing.Color.LimeGreen;
            this.ButtonEnv.HoverState.FillColor = System.Drawing.Color.LimeGreen;
            this.ButtonEnv.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ButtonEnv.HoverState.Parent = this.ButtonEnv;
            this.ButtonEnv.Location = new System.Drawing.Point(263, 392);
            this.ButtonEnv.Name = "ButtonEnv";
            this.ButtonEnv.ShadowDecoration.Parent = this.ButtonEnv;
            this.ButtonEnv.Size = new System.Drawing.Size(107, 35);
            this.ButtonEnv.TabIndex = 262;
            this.ButtonEnv.Text = "Envoyer";
            this.ButtonEnv.Click += new System.EventHandler(this.ButtonEnv_Click);
            // 
            // LabelMesg
            // 
            this.LabelMesg.AutoSize = true;
            this.LabelMesg.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMesg.ForeColor = System.Drawing.Color.Gray;
            this.LabelMesg.Location = new System.Drawing.Point(55, 276);
            this.LabelMesg.Name = "LabelMesg";
            this.LabelMesg.Size = new System.Drawing.Size(96, 18);
            this.LabelMesg.TabIndex = 261;
            this.LabelMesg.Text = "Message :";
            // 
            // LabelDe
            // 
            this.LabelDe.AutoSize = true;
            this.LabelDe.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDe.ForeColor = System.Drawing.Color.Gray;
            this.LabelDe.Location = new System.Drawing.Point(55, 202);
            this.LabelDe.Name = "LabelDe";
            this.LabelDe.Size = new System.Drawing.Size(43, 18);
            this.LabelDe.TabIndex = 260;
            this.LabelDe.Text = "De :";
            // 
            // LabelTel
            // 
            this.LabelTel.AutoSize = true;
            this.LabelTel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTel.ForeColor = System.Drawing.Color.Gray;
            this.LabelTel.Location = new System.Drawing.Point(55, 146);
            this.LabelTel.Name = "LabelTel";
            this.LabelTel.Size = new System.Drawing.Size(112, 18);
            this.LabelTel.TabIndex = 259;
            this.LabelTel.Text = "Télephone :";
            // 
            // LabelNom
            // 
            this.LabelNom.AutoSize = true;
            this.LabelNom.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNom.ForeColor = System.Drawing.Color.Gray;
            this.LabelNom.Location = new System.Drawing.Point(55, 91);
            this.LabelNom.Name = "LabelNom";
            this.LabelNom.Size = new System.Drawing.Size(59, 18);
            this.LabelNom.TabIndex = 258;
            this.LabelNom.Text = "Nom :";
            // 
            // EnvoyerSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 449);
            this.Controls.Add(this.panelContent);
            this.Name = "EnvoyerSMS";
            this.Text = "EnvoyerSMS";
            this.Load += new System.EventHandler(this.EnvoyerSMS_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        internal Guna.UI2.WinForms.Guna2TextBox TextBoxNomPt;
        internal Guna.UI2.WinForms.Guna2TextBox TextBoxTel;
        internal Guna.UI2.WinForms.Guna2TextBox TextBoxDoc;
        internal Guna.UI2.WinForms.Guna2TextBox TextBoxMesg;
        private Guna.UI2.WinForms.Guna2Button ButtonAnnuler;
        private Guna.UI2.WinForms.Guna2Button ButtonEnv;
        private Guna.UI.WinForms.GunaLabel LabelMesg;
        private Guna.UI.WinForms.GunaLabel LabelDe;
        private Guna.UI.WinForms.GunaLabel LabelTel;
        private Guna.UI.WinForms.GunaLabel LabelNom;
        private System.Windows.Forms.Panel panelHeader;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonClose;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonTitle;
    }
}