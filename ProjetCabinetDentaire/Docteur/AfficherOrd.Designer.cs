
namespace ProjetCabinetDentaire.Docteur
{
    partial class AfficherOrd
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
            this.panelServ = new System.Windows.Forms.Panel();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.LabelQteO = new Guna.UI.WinForms.GunaLabel();
            this.groupBoxDesr = new System.Windows.Forms.GroupBox();
            this.TextBoxDescr = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxOteOrd = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxNomMed = new Guna.UI2.WinForms.Guna2TextBox();
            this.LabelNomMed = new Guna.UI.WinForms.GunaLabel();
            this.groupBoxButton = new System.Windows.Forms.GroupBox();
            this.LabelErreur = new Guna.UI.WinForms.GunaLabel();
            this.ButtonAnnuler = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonValider = new Guna.UI2.WinForms.Guna2Button();
            this.LabelOte = new Guna.UI.WinForms.GunaLabel();
            this.LabelNomMedO = new Guna.UI.WinForms.GunaLabel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.ButtonClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ButtonTitle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelServ.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxDesr.SuspendLayout();
            this.groupBoxButton.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelServ
            // 
            this.panelServ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelServ.Controls.Add(this.groupBoxInfo);
            this.panelServ.Controls.Add(this.panelHeader);
            this.panelServ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelServ.Location = new System.Drawing.Point(0, 0);
            this.panelServ.Name = "panelServ";
            this.panelServ.Size = new System.Drawing.Size(715, 363);
            this.panelServ.TabIndex = 188;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.LabelQteO);
            this.groupBoxInfo.Controls.Add(this.groupBoxDesr);
            this.groupBoxInfo.Controls.Add(this.TextBoxOteOrd);
            this.groupBoxInfo.Controls.Add(this.TextBoxNomMed);
            this.groupBoxInfo.Controls.Add(this.LabelNomMed);
            this.groupBoxInfo.Controls.Add(this.groupBoxButton);
            this.groupBoxInfo.Controls.Add(this.LabelOte);
            this.groupBoxInfo.Controls.Add(this.LabelNomMedO);
            this.groupBoxInfo.Location = new System.Drawing.Point(11, 54);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(694, 299);
            this.groupBoxInfo.TabIndex = 184;
            this.groupBoxInfo.TabStop = false;
            // 
            // LabelQteO
            // 
            this.LabelQteO.AutoSize = true;
            this.LabelQteO.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQteO.ForeColor = System.Drawing.Color.Red;
            this.LabelQteO.Location = new System.Drawing.Point(137, 107);
            this.LabelQteO.Name = "LabelQteO";
            this.LabelQteO.Size = new System.Drawing.Size(17, 16);
            this.LabelQteO.TabIndex = 247;
            this.LabelQteO.Text = "*";
            // 
            // groupBoxDesr
            // 
            this.groupBoxDesr.Controls.Add(this.TextBoxDescr);
            this.groupBoxDesr.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxDesr.ForeColor = System.Drawing.Color.Gray;
            this.groupBoxDesr.Location = new System.Drawing.Point(385, 23);
            this.groupBoxDesr.Name = "groupBoxDesr";
            this.groupBoxDesr.Size = new System.Drawing.Size(296, 150);
            this.groupBoxDesr.TabIndex = 246;
            this.groupBoxDesr.TabStop = false;
            this.groupBoxDesr.Text = "Description";
            // 
            // TextBoxDescr
            // 
            this.TextBoxDescr.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.TextBoxDescr.BorderRadius = 5;
            this.TextBoxDescr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDescr.DefaultText = "";
            this.TextBoxDescr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxDescr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxDescr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDescr.DisabledState.Parent = this.TextBoxDescr;
            this.TextBoxDescr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDescr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.TextBoxDescr.FocusedState.Parent = this.TextBoxDescr;
            this.TextBoxDescr.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDescr.ForeColor = System.Drawing.Color.Black;
            this.TextBoxDescr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDescr.HoverState.Parent = this.TextBoxDescr;
            this.TextBoxDescr.Location = new System.Drawing.Point(14, 28);
            this.TextBoxDescr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxDescr.Multiline = true;
            this.TextBoxDescr.Name = "TextBoxDescr";
            this.TextBoxDescr.PasswordChar = '\0';
            this.TextBoxDescr.PlaceholderText = "";
            this.TextBoxDescr.SelectedText = "";
            this.TextBoxDescr.ShadowDecoration.Parent = this.TextBoxDescr;
            this.TextBoxDescr.Size = new System.Drawing.Size(269, 106);
            this.TextBoxDescr.TabIndex = 3;
            this.TextBoxDescr.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // TextBoxOteOrd
            // 
            this.TextBoxOteOrd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.TextBoxOteOrd.BorderRadius = 5;
            this.TextBoxOteOrd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxOteOrd.DefaultText = "";
            this.TextBoxOteOrd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxOteOrd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxOteOrd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxOteOrd.DisabledState.Parent = this.TextBoxOteOrd;
            this.TextBoxOteOrd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxOteOrd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.TextBoxOteOrd.FocusedState.Parent = this.TextBoxOteOrd;
            this.TextBoxOteOrd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxOteOrd.ForeColor = System.Drawing.Color.Black;
            this.TextBoxOteOrd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxOteOrd.HoverState.Parent = this.TextBoxOteOrd;
            this.TextBoxOteOrd.Location = new System.Drawing.Point(24, 137);
            this.TextBoxOteOrd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxOteOrd.Name = "TextBoxOteOrd";
            this.TextBoxOteOrd.PasswordChar = '\0';
            this.TextBoxOteOrd.PlaceholderText = "";
            this.TextBoxOteOrd.SelectedText = "";
            this.TextBoxOteOrd.ShadowDecoration.Parent = this.TextBoxOteOrd;
            this.TextBoxOteOrd.Size = new System.Drawing.Size(315, 36);
            this.TextBoxOteOrd.TabIndex = 245;
            this.TextBoxOteOrd.TextOffset = new System.Drawing.Point(5, 0);
            this.TextBoxOteOrd.TextChanged += new System.EventHandler(this.TextBoxOteOrd_TextChanged);
            // 
            // TextBoxNomMed
            // 
            this.TextBoxNomMed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.TextBoxNomMed.BorderRadius = 5;
            this.TextBoxNomMed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxNomMed.DefaultText = "";
            this.TextBoxNomMed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxNomMed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxNomMed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNomMed.DisabledState.Parent = this.TextBoxNomMed;
            this.TextBoxNomMed.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNomMed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.TextBoxNomMed.FocusedState.Parent = this.TextBoxNomMed;
            this.TextBoxNomMed.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNomMed.ForeColor = System.Drawing.Color.Black;
            this.TextBoxNomMed.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxNomMed.HoverState.Parent = this.TextBoxNomMed;
            this.TextBoxNomMed.Location = new System.Drawing.Point(24, 48);
            this.TextBoxNomMed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxNomMed.Name = "TextBoxNomMed";
            this.TextBoxNomMed.PasswordChar = '\0';
            this.TextBoxNomMed.PlaceholderText = "";
            this.TextBoxNomMed.SelectedText = "";
            this.TextBoxNomMed.ShadowDecoration.Parent = this.TextBoxNomMed;
            this.TextBoxNomMed.Size = new System.Drawing.Size(315, 36);
            this.TextBoxNomMed.TabIndex = 1;
            this.TextBoxNomMed.TextOffset = new System.Drawing.Point(5, 0);
            this.TextBoxNomMed.TextChanged += new System.EventHandler(this.TextBoxNomMed_TextChanged);
            // 
            // LabelNomMed
            // 
            this.LabelNomMed.AutoSize = true;
            this.LabelNomMed.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomMed.ForeColor = System.Drawing.Color.Gray;
            this.LabelNomMed.Location = new System.Drawing.Point(47, 18);
            this.LabelNomMed.Name = "LabelNomMed";
            this.LabelNomMed.Size = new System.Drawing.Size(187, 18);
            this.LabelNomMed.TabIndex = 166;
            this.LabelNomMed.Text = "Nom de médicament";
            // 
            // groupBoxButton
            // 
            this.groupBoxButton.Controls.Add(this.LabelErreur);
            this.groupBoxButton.Controls.Add(this.ButtonAnnuler);
            this.groupBoxButton.Controls.Add(this.ButtonValider);
            this.groupBoxButton.Location = new System.Drawing.Point(10, 189);
            this.groupBoxButton.Name = "groupBoxButton";
            this.groupBoxButton.Size = new System.Drawing.Size(671, 99);
            this.groupBoxButton.TabIndex = 12;
            this.groupBoxButton.TabStop = false;
            // 
            // LabelErreur
            // 
            this.LabelErreur.AutoSize = true;
            this.LabelErreur.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelErreur.ForeColor = System.Drawing.Color.Red;
            this.LabelErreur.Location = new System.Drawing.Point(48, 61);
            this.LabelErreur.Name = "LabelErreur";
            this.LabelErreur.Size = new System.Drawing.Size(123, 16);
            this.LabelErreur.TabIndex = 188;
            this.LabelErreur.Text = "* Message Erreur";
            this.LabelErreur.Visible = false;
            // 
            // ButtonAnnuler
            // 
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
            this.ButtonAnnuler.Location = new System.Drawing.Point(386, 20);
            this.ButtonAnnuler.Name = "ButtonAnnuler";
            this.ButtonAnnuler.ShadowDecoration.Parent = this.ButtonAnnuler;
            this.ButtonAnnuler.Size = new System.Drawing.Size(118, 37);
            this.ButtonAnnuler.TabIndex = 185;
            this.ButtonAnnuler.Text = "Annuler";
            this.ButtonAnnuler.Click += new System.EventHandler(this.ButtonAnnuler_Click);
            // 
            // ButtonValider
            // 
            this.ButtonValider.BorderColor = System.Drawing.Color.Orange;
            this.ButtonValider.BorderRadius = 5;
            this.ButtonValider.BorderThickness = 1;
            this.ButtonValider.CheckedState.Parent = this.ButtonValider;
            this.ButtonValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonValider.CustomImages.Parent = this.ButtonValider;
            this.ButtonValider.FillColor = System.Drawing.Color.Transparent;
            this.ButtonValider.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonValider.ForeColor = System.Drawing.Color.Orange;
            this.ButtonValider.HoverState.FillColor = System.Drawing.Color.Orange;
            this.ButtonValider.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ButtonValider.HoverState.Parent = this.ButtonValider;
            this.ButtonValider.Location = new System.Drawing.Point(521, 20);
            this.ButtonValider.Name = "ButtonValider";
            this.ButtonValider.ShadowDecoration.Parent = this.ButtonValider;
            this.ButtonValider.Size = new System.Drawing.Size(118, 37);
            this.ButtonValider.TabIndex = 1;
            this.ButtonValider.Text = "Modifier";
            this.ButtonValider.Click += new System.EventHandler(this.ButtonValider_Click);
            // 
            // LabelOte
            // 
            this.LabelOte.AutoSize = true;
            this.LabelOte.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOte.ForeColor = System.Drawing.Color.Gray;
            this.LabelOte.Location = new System.Drawing.Point(47, 107);
            this.LabelOte.Name = "LabelOte";
            this.LabelOte.Size = new System.Drawing.Size(84, 18);
            this.LabelOte.TabIndex = 178;
            this.LabelOte.Text = "Quantité";
            // 
            // LabelNomMedO
            // 
            this.LabelNomMedO.AutoSize = true;
            this.LabelNomMedO.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomMedO.ForeColor = System.Drawing.Color.Red;
            this.LabelNomMedO.Location = new System.Drawing.Point(240, 18);
            this.LabelNomMedO.Name = "LabelNomMedO";
            this.LabelNomMedO.Size = new System.Drawing.Size(17, 16);
            this.LabelNomMedO.TabIndex = 187;
            this.LabelNomMedO.Text = "*";
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
            this.panelHeader.Size = new System.Drawing.Size(713, 48);
            this.panelHeader.TabIndex = 27;
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
            this.ButtonClose.Location = new System.Drawing.Point(659, 3);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.PressedState.Parent = this.ButtonClose;
            this.ButtonClose.Size = new System.Drawing.Size(50, 42);
            this.ButtonClose.TabIndex = 31;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonTitle
            // 
            this.ButtonTitle.Active = false;
            this.ButtonTitle.Activecolor = System.Drawing.Color.Transparent;
            this.ButtonTitle.BackColor = System.Drawing.Color.Transparent;
            this.ButtonTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonTitle.BorderRadius = 0;
            this.ButtonTitle.ButtonText = "Informations du médicament";
            this.ButtonTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonTitle.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonTitle.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonTitle.Iconimage = global::ProjetCabinetDentaire.Properties.Resources.information;
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
            this.ButtonTitle.Location = new System.Drawing.Point(11, 3);
            this.ButtonTitle.Name = "ButtonTitle";
            this.ButtonTitle.Normalcolor = System.Drawing.Color.Transparent;
            this.ButtonTitle.OnHovercolor = System.Drawing.Color.Transparent;
            this.ButtonTitle.OnHoverTextColor = System.Drawing.Color.Black;
            this.ButtonTitle.selected = false;
            this.ButtonTitle.Size = new System.Drawing.Size(320, 42);
            this.ButtonTitle.TabIndex = 29;
            this.ButtonTitle.Text = "Informations du médicament";
            this.ButtonTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonTitle.Textcolor = System.Drawing.Color.Black;
            this.ButtonTitle.TextFont = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            // 
            // AfficherOrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 363);
            this.Controls.Add(this.panelServ);
            this.Name = "AfficherOrd";
            this.Text = "AfficherOrd";
            this.Load += new System.EventHandler(this.AfficherOrd_Load);
            this.panelServ.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxDesr.ResumeLayout(false);
            this.groupBoxButton.ResumeLayout(false);
            this.groupBoxButton.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelServ;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private Guna.UI.WinForms.GunaLabel LabelQteO;
        private System.Windows.Forms.GroupBox groupBoxDesr;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxDescr;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxOteOrd;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxNomMed;
        private Guna.UI.WinForms.GunaLabel LabelNomMed;
        private System.Windows.Forms.GroupBox groupBoxButton;
        private Guna.UI.WinForms.GunaLabel LabelErreur;
        private Guna.UI2.WinForms.Guna2Button ButtonAnnuler;
        private Guna.UI2.WinForms.Guna2Button ButtonValider;
        private Guna.UI.WinForms.GunaLabel LabelOte;
        private Guna.UI.WinForms.GunaLabel LabelNomMedO;
        private System.Windows.Forms.Panel panelHeader;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonClose;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonTitle;
    }
}