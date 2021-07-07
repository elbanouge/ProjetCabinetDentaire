
namespace ProjetCabinetDentaire.Docteur
{
    partial class AjouterOrd
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxDesr = new System.Windows.Forms.GroupBox();
            this.TextBoxQteOrd = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxNomMed = new Guna.UI2.WinForms.Guna2TextBox();
            this.LabelNomOrd = new Guna.UI.WinForms.GunaLabel();
            this.groupBoxButton = new System.Windows.Forms.GroupBox();
            this.ButtonVider = new Guna.UI2.WinForms.Guna2Button();
            this.LabelErreur = new Guna.UI.WinForms.GunaLabel();
            this.ButtonAnnuler = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonValider = new Guna.UI2.WinForms.Guna2Button();
            this.LabelQteOrd = new Guna.UI.WinForms.GunaLabel();
            this.LabelNomMedO = new Guna.UI.WinForms.GunaLabel();
            this.panelServ = new System.Windows.Forms.Panel();
            this.ButtonClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ButtonTitle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LabelQteO = new Guna.UI.WinForms.GunaLabel();
            this.TextBoxDescr = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelHeader.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxDesr.SuspendLayout();
            this.groupBoxButton.SuspendLayout();
            this.panelServ.SuspendLayout();
            this.SuspendLayout();
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
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.LabelQteO);
            this.groupBoxInfo.Controls.Add(this.groupBoxDesr);
            this.groupBoxInfo.Controls.Add(this.TextBoxQteOrd);
            this.groupBoxInfo.Controls.Add(this.TextBoxNomMed);
            this.groupBoxInfo.Controls.Add(this.LabelNomOrd);
            this.groupBoxInfo.Controls.Add(this.groupBoxButton);
            this.groupBoxInfo.Controls.Add(this.LabelQteOrd);
            this.groupBoxInfo.Controls.Add(this.LabelNomMedO);
            this.groupBoxInfo.Location = new System.Drawing.Point(11, 54);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(694, 322);
            this.groupBoxInfo.TabIndex = 184;
            this.groupBoxInfo.TabStop = false;
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
            // TextBoxQteOrd
            // 
            this.TextBoxQteOrd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.TextBoxQteOrd.BorderRadius = 5;
            this.TextBoxQteOrd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxQteOrd.DefaultText = "0";
            this.TextBoxQteOrd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxQteOrd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxQteOrd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxQteOrd.DisabledState.Parent = this.TextBoxQteOrd;
            this.TextBoxQteOrd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxQteOrd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.TextBoxQteOrd.FocusedState.Parent = this.TextBoxQteOrd;
            this.TextBoxQteOrd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxQteOrd.ForeColor = System.Drawing.Color.Black;
            this.TextBoxQteOrd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxQteOrd.HoverState.Parent = this.TextBoxQteOrd;
            this.TextBoxQteOrd.Location = new System.Drawing.Point(24, 137);
            this.TextBoxQteOrd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxQteOrd.Name = "TextBoxQteOrd";
            this.TextBoxQteOrd.PasswordChar = '\0';
            this.TextBoxQteOrd.PlaceholderText = "";
            this.TextBoxQteOrd.SelectedText = "";
            this.TextBoxQteOrd.SelectionStart = 1;
            this.TextBoxQteOrd.ShadowDecoration.Parent = this.TextBoxQteOrd;
            this.TextBoxQteOrd.Size = new System.Drawing.Size(315, 36);
            this.TextBoxQteOrd.TabIndex = 245;
            this.TextBoxQteOrd.TextOffset = new System.Drawing.Point(5, 0);
            this.TextBoxQteOrd.TextChanged += new System.EventHandler(this.TextBoxQteOrd_TextChanged);
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
            // LabelNomOrd
            // 
            this.LabelNomOrd.AutoSize = true;
            this.LabelNomOrd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomOrd.ForeColor = System.Drawing.Color.Gray;
            this.LabelNomOrd.Location = new System.Drawing.Point(47, 18);
            this.LabelNomOrd.Name = "LabelNomOrd";
            this.LabelNomOrd.Size = new System.Drawing.Size(187, 18);
            this.LabelNomOrd.TabIndex = 166;
            this.LabelNomOrd.Text = "Nom de médicament";
            // 
            // groupBoxButton
            // 
            this.groupBoxButton.Controls.Add(this.ButtonVider);
            this.groupBoxButton.Controls.Add(this.LabelErreur);
            this.groupBoxButton.Controls.Add(this.ButtonAnnuler);
            this.groupBoxButton.Controls.Add(this.ButtonValider);
            this.groupBoxButton.Location = new System.Drawing.Point(10, 189);
            this.groupBoxButton.Name = "groupBoxButton";
            this.groupBoxButton.Size = new System.Drawing.Size(671, 117);
            this.groupBoxButton.TabIndex = 12;
            this.groupBoxButton.TabStop = false;
            // 
            // ButtonVider
            // 
            this.ButtonVider.BorderColor = System.Drawing.Color.Orange;
            this.ButtonVider.BorderRadius = 5;
            this.ButtonVider.BorderThickness = 1;
            this.ButtonVider.CheckedState.Parent = this.ButtonVider;
            this.ButtonVider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonVider.CustomImages.Parent = this.ButtonVider;
            this.ButtonVider.FillColor = System.Drawing.Color.Transparent;
            this.ButtonVider.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonVider.ForeColor = System.Drawing.Color.Orange;
            this.ButtonVider.HoverState.FillColor = System.Drawing.Color.Orange;
            this.ButtonVider.HoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonVider.HoverState.Parent = this.ButtonVider;
            this.ButtonVider.Location = new System.Drawing.Point(26, 20);
            this.ButtonVider.Name = "ButtonVider";
            this.ButtonVider.ShadowDecoration.Parent = this.ButtonVider;
            this.ButtonVider.Size = new System.Drawing.Size(157, 37);
            this.ButtonVider.TabIndex = 189;
            this.ButtonVider.Text = "Vider les champs";
            this.ButtonVider.Click += new System.EventHandler(this.ButtonVider_Click);
            // 
            // LabelErreur
            // 
            this.LabelErreur.AutoSize = true;
            this.LabelErreur.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelErreur.ForeColor = System.Drawing.Color.Red;
            this.LabelErreur.Location = new System.Drawing.Point(57, 80);
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
            this.ButtonValider.BorderColor = System.Drawing.Color.LimeGreen;
            this.ButtonValider.BorderRadius = 5;
            this.ButtonValider.BorderThickness = 1;
            this.ButtonValider.CheckedState.Parent = this.ButtonValider;
            this.ButtonValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonValider.CustomImages.Parent = this.ButtonValider;
            this.ButtonValider.FillColor = System.Drawing.Color.Transparent;
            this.ButtonValider.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonValider.ForeColor = System.Drawing.Color.LimeGreen;
            this.ButtonValider.HoverState.FillColor = System.Drawing.Color.LimeGreen;
            this.ButtonValider.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ButtonValider.HoverState.Parent = this.ButtonValider;
            this.ButtonValider.Location = new System.Drawing.Point(521, 20);
            this.ButtonValider.Name = "ButtonValider";
            this.ButtonValider.ShadowDecoration.Parent = this.ButtonValider;
            this.ButtonValider.Size = new System.Drawing.Size(118, 37);
            this.ButtonValider.TabIndex = 1;
            this.ButtonValider.Text = "Ajouter";
            this.ButtonValider.Click += new System.EventHandler(this.ButtonValider_Click);
            // 
            // LabelQteOrd
            // 
            this.LabelQteOrd.AutoSize = true;
            this.LabelQteOrd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQteOrd.ForeColor = System.Drawing.Color.Gray;
            this.LabelQteOrd.Location = new System.Drawing.Point(47, 107);
            this.LabelQteOrd.Name = "LabelQteOrd";
            this.LabelQteOrd.Size = new System.Drawing.Size(84, 18);
            this.LabelQteOrd.TabIndex = 178;
            this.LabelQteOrd.Text = "Quantité";
            // 
            // LabelNomMedO
            // 
            this.LabelNomMedO.AutoSize = true;
            this.LabelNomMedO.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomMedO.ForeColor = System.Drawing.Color.Red;
            this.LabelNomMedO.Location = new System.Drawing.Point(240, 16);
            this.LabelNomMedO.Name = "LabelNomMedO";
            this.LabelNomMedO.Size = new System.Drawing.Size(17, 16);
            this.LabelNomMedO.TabIndex = 187;
            this.LabelNomMedO.Text = "*";
            // 
            // panelServ
            // 
            this.panelServ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelServ.Controls.Add(this.groupBoxInfo);
            this.panelServ.Controls.Add(this.panelHeader);
            this.panelServ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelServ.Location = new System.Drawing.Point(0, 0);
            this.panelServ.Name = "panelServ";
            this.panelServ.Size = new System.Drawing.Size(715, 386);
            this.panelServ.TabIndex = 187;
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
            this.ButtonClose.Location = new System.Drawing.Point(658, 3);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.PressedState.Parent = this.ButtonClose;
            this.ButtonClose.Size = new System.Drawing.Size(50, 42);
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
            this.ButtonTitle.ButtonText = "Nouveau Médicament";
            this.ButtonTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonTitle.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonTitle.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonTitle.Iconimage = global::ProjetCabinetDentaire.Properties.Resources.prescription;
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
            this.ButtonTitle.Size = new System.Drawing.Size(256, 42);
            this.ButtonTitle.TabIndex = 29;
            this.ButtonTitle.Text = "Nouveau Médicament";
            this.ButtonTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonTitle.Textcolor = System.Drawing.Color.Black;
            this.ButtonTitle.TextFont = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
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
            this.TextBoxDescr.TabIndex = 4;
            this.TextBoxDescr.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // AjouterOrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 386);
            this.Controls.Add(this.panelServ);
            this.Name = "AjouterOrd";
            this.Text = "AjouterOrd";
            this.Load += new System.EventHandler(this.AjouterOrd_Load);
            this.panelHeader.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxDesr.ResumeLayout(false);
            this.groupBoxButton.ResumeLayout(false);
            this.groupBoxButton.PerformLayout();
            this.panelServ.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton ButtonTitle;
        private System.Windows.Forms.Panel panelHeader;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonClose;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.GroupBox groupBoxDesr;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxQteOrd;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxNomMed;
        private Guna.UI.WinForms.GunaLabel LabelNomOrd;
        private System.Windows.Forms.GroupBox groupBoxButton;
        private Guna.UI2.WinForms.Guna2Button ButtonVider;
        private Guna.UI.WinForms.GunaLabel LabelErreur;
        private Guna.UI2.WinForms.Guna2Button ButtonAnnuler;
        private Guna.UI2.WinForms.Guna2Button ButtonValider;
        private Guna.UI.WinForms.GunaLabel LabelQteOrd;
        private Guna.UI.WinForms.GunaLabel LabelNomMedO;
        private System.Windows.Forms.Panel panelServ;
        private Guna.UI.WinForms.GunaLabel LabelQteO;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxDescr;
    }
}