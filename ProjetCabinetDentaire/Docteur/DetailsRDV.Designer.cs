
namespace ProjetCabinetDentaire.Docteur
{
    partial class DetailsRDV
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
            this.DateTimePickerDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panelDRDV = new System.Windows.Forms.Panel();
            this.LabelNmRDVTit = new Guna.UI.WinForms.GunaLabel();
            this.LabelNmRDV = new Guna.UI.WinForms.GunaLabel();
            this.ComboBoxMinute = new System.Windows.Forms.ComboBox();
            this.ComboBoxHeure = new System.Windows.Forms.ComboBox();
            this.TextBoxPat = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxDescr = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonEnvSMS = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonAnnuler = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSupp = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonValider = new Guna.UI2.WinForms.Guna2Button();
            this.LabelDescr = new Guna.UI.WinForms.GunaLabel();
            this.LabelPat = new Guna.UI.WinForms.GunaLabel();
            this.LabelHeure = new Guna.UI.WinForms.GunaLabel();
            this.LabelDate = new Guna.UI.WinForms.GunaLabel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.ButtonClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ButtonTitle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TextBoxHeure = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelDRDV.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateTimePickerDate
            // 
            this.DateTimePickerDate.BackColor = System.Drawing.Color.Transparent;
            this.DateTimePickerDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(199)))), ((int)(((byte)(178)))));
            this.DateTimePickerDate.BorderRadius = 5;
            this.DateTimePickerDate.BorderThickness = 1;
            this.DateTimePickerDate.CheckedState.Parent = this.DateTimePickerDate;
            this.DateTimePickerDate.FillColor = System.Drawing.Color.White;
            this.DateTimePickerDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePickerDate.HoverState.Parent = this.DateTimePickerDate;
            this.DateTimePickerDate.Location = new System.Drawing.Point(173, 113);
            this.DateTimePickerDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerDate.Name = "DateTimePickerDate";
            this.DateTimePickerDate.ShadowDecoration.Parent = this.DateTimePickerDate;
            this.DateTimePickerDate.Size = new System.Drawing.Size(281, 36);
            this.DateTimePickerDate.TabIndex = 213;
            this.DateTimePickerDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateTimePickerDate.Value = new System.DateTime(2021, 1, 28, 13, 31, 44, 723);
            // 
            // panelDRDV
            // 
            this.panelDRDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDRDV.Controls.Add(this.LabelNmRDVTit);
            this.panelDRDV.Controls.Add(this.LabelNmRDV);
            this.panelDRDV.Controls.Add(this.ComboBoxMinute);
            this.panelDRDV.Controls.Add(this.ComboBoxHeure);
            this.panelDRDV.Controls.Add(this.TextBoxPat);
            this.panelDRDV.Controls.Add(this.TextBoxDescr);
            this.panelDRDV.Controls.Add(this.ButtonEnvSMS);
            this.panelDRDV.Controls.Add(this.ButtonAnnuler);
            this.panelDRDV.Controls.Add(this.ButtonSupp);
            this.panelDRDV.Controls.Add(this.ButtonValider);
            this.panelDRDV.Controls.Add(this.LabelDescr);
            this.panelDRDV.Controls.Add(this.LabelPat);
            this.panelDRDV.Controls.Add(this.LabelHeure);
            this.panelDRDV.Controls.Add(this.LabelDate);
            this.panelDRDV.Controls.Add(this.DateTimePickerDate);
            this.panelDRDV.Controls.Add(this.panelHeader);
            this.panelDRDV.Controls.Add(this.TextBoxHeure);
            this.panelDRDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDRDV.Location = new System.Drawing.Point(0, 0);
            this.panelDRDV.Name = "panelDRDV";
            this.panelDRDV.Size = new System.Drawing.Size(497, 486);
            this.panelDRDV.TabIndex = 212;
            // 
            // LabelNmRDVTit
            // 
            this.LabelNmRDVTit.AutoSize = true;
            this.LabelNmRDVTit.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNmRDVTit.ForeColor = System.Drawing.Color.Gray;
            this.LabelNmRDVTit.Location = new System.Drawing.Point(15, 62);
            this.LabelNmRDVTit.Name = "LabelNmRDVTit";
            this.LabelNmRDVTit.Size = new System.Drawing.Size(124, 18);
            this.LabelNmRDVTit.TabIndex = 246;
            this.LabelNmRDVTit.Text = "Numéro RDV :";
            // 
            // LabelNmRDV
            // 
            this.LabelNmRDV.AutoSize = true;
            this.LabelNmRDV.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNmRDV.ForeColor = System.Drawing.Color.Gray;
            this.LabelNmRDV.Location = new System.Drawing.Point(145, 62);
            this.LabelNmRDV.Name = "LabelNmRDV";
            this.LabelNmRDV.Size = new System.Drawing.Size(41, 18);
            this.LabelNmRDV.TabIndex = 245;
            this.LabelNmRDV.Text = "123";
            // 
            // ComboBoxMinute
            // 
            this.ComboBoxMinute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxMinute.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.ComboBoxMinute.FormattingEnabled = true;
            this.ComboBoxMinute.Location = new System.Drawing.Point(286, 173);
            this.ComboBoxMinute.Name = "ComboBoxMinute";
            this.ComboBoxMinute.Size = new System.Drawing.Size(61, 24);
            this.ComboBoxMinute.TabIndex = 244;
            this.ComboBoxMinute.Text = "00 H";
            // 
            // ComboBoxHeure
            // 
            this.ComboBoxHeure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxHeure.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.ComboBoxHeure.FormattingEnabled = true;
            this.ComboBoxHeure.Location = new System.Drawing.Point(219, 173);
            this.ComboBoxHeure.Name = "ComboBoxHeure";
            this.ComboBoxHeure.Size = new System.Drawing.Size(61, 24);
            this.ComboBoxHeure.TabIndex = 241;
            this.ComboBoxHeure.Text = "8 :";
            // 
            // TextBoxPat
            // 
            this.TextBoxPat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.TextBoxPat.BorderRadius = 5;
            this.TextBoxPat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPat.DefaultText = "";
            this.TextBoxPat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxPat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxPat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPat.DisabledState.Parent = this.TextBoxPat;
            this.TextBoxPat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.TextBoxPat.FocusedState.Parent = this.TextBoxPat;
            this.TextBoxPat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.TextBoxPat.ForeColor = System.Drawing.Color.Black;
            this.TextBoxPat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPat.HoverState.Parent = this.TextBoxPat;
            this.TextBoxPat.Location = new System.Drawing.Point(173, 224);
            this.TextBoxPat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxPat.Name = "TextBoxPat";
            this.TextBoxPat.PasswordChar = '\0';
            this.TextBoxPat.PlaceholderText = "";
            this.TextBoxPat.SelectedText = "";
            this.TextBoxPat.ShadowDecoration.Parent = this.TextBoxPat;
            this.TextBoxPat.Size = new System.Drawing.Size(281, 36);
            this.TextBoxPat.TabIndex = 242;
            this.TextBoxPat.TextOffset = new System.Drawing.Point(5, 0);
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
            this.TextBoxDescr.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.TextBoxDescr.ForeColor = System.Drawing.Color.Black;
            this.TextBoxDescr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDescr.HoverState.Parent = this.TextBoxDescr;
            this.TextBoxDescr.Location = new System.Drawing.Point(173, 287);
            this.TextBoxDescr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxDescr.Multiline = true;
            this.TextBoxDescr.Name = "TextBoxDescr";
            this.TextBoxDescr.PasswordChar = '\0';
            this.TextBoxDescr.PlaceholderText = "";
            this.TextBoxDescr.SelectedText = "";
            this.TextBoxDescr.ShadowDecoration.Parent = this.TextBoxDescr;
            this.TextBoxDescr.Size = new System.Drawing.Size(281, 100);
            this.TextBoxDescr.TabIndex = 238;
            this.TextBoxDescr.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // ButtonEnvSMS
            // 
            this.ButtonEnvSMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEnvSMS.BorderColor = System.Drawing.Color.Orange;
            this.ButtonEnvSMS.BorderRadius = 5;
            this.ButtonEnvSMS.BorderThickness = 1;
            this.ButtonEnvSMS.CheckedState.Parent = this.ButtonEnvSMS;
            this.ButtonEnvSMS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEnvSMS.CustomImages.Parent = this.ButtonEnvSMS;
            this.ButtonEnvSMS.FillColor = System.Drawing.Color.Transparent;
            this.ButtonEnvSMS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonEnvSMS.ForeColor = System.Drawing.Color.Orange;
            this.ButtonEnvSMS.HoverState.FillColor = System.Drawing.Color.Orange;
            this.ButtonEnvSMS.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ButtonEnvSMS.HoverState.Parent = this.ButtonEnvSMS;
            this.ButtonEnvSMS.Location = new System.Drawing.Point(264, 54);
            this.ButtonEnvSMS.Name = "ButtonEnvSMS";
            this.ButtonEnvSMS.ShadowDecoration.Parent = this.ButtonEnvSMS;
            this.ButtonEnvSMS.Size = new System.Drawing.Size(220, 35);
            this.ButtonEnvSMS.TabIndex = 236;
            this.ButtonEnvSMS.Text = "Envoyer SMS";
            this.ButtonEnvSMS.Click += new System.EventHandler(this.ButtonEnvSMS_Click);
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
            this.ButtonAnnuler.Location = new System.Drawing.Point(153, 438);
            this.ButtonAnnuler.Name = "ButtonAnnuler";
            this.ButtonAnnuler.ShadowDecoration.Parent = this.ButtonAnnuler;
            this.ButtonAnnuler.Size = new System.Drawing.Size(107, 35);
            this.ButtonAnnuler.TabIndex = 235;
            this.ButtonAnnuler.Text = "Annuler";
            this.ButtonAnnuler.Click += new System.EventHandler(this.ButtonAnnuler_Click);
            // 
            // ButtonSupp
            // 
            this.ButtonSupp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSupp.BorderColor = System.Drawing.Color.Red;
            this.ButtonSupp.BorderRadius = 5;
            this.ButtonSupp.BorderThickness = 1;
            this.ButtonSupp.CheckedState.Parent = this.ButtonSupp;
            this.ButtonSupp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSupp.CustomImages.Parent = this.ButtonSupp;
            this.ButtonSupp.FillColor = System.Drawing.Color.Transparent;
            this.ButtonSupp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSupp.ForeColor = System.Drawing.Color.Red;
            this.ButtonSupp.HoverState.FillColor = System.Drawing.Color.Red;
            this.ButtonSupp.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ButtonSupp.HoverState.Parent = this.ButtonSupp;
            this.ButtonSupp.Location = new System.Drawing.Point(19, 438);
            this.ButtonSupp.Name = "ButtonSupp";
            this.ButtonSupp.ShadowDecoration.Parent = this.ButtonSupp;
            this.ButtonSupp.Size = new System.Drawing.Size(107, 35);
            this.ButtonSupp.TabIndex = 234;
            this.ButtonSupp.Text = "Supprimer";
            this.ButtonSupp.Click += new System.EventHandler(this.ButtonSupp_Click);
            // 
            // ButtonValider
            // 
            this.ButtonValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.ButtonValider.Location = new System.Drawing.Point(266, 438);
            this.ButtonValider.Name = "ButtonValider";
            this.ButtonValider.ShadowDecoration.Parent = this.ButtonValider;
            this.ButtonValider.Size = new System.Drawing.Size(107, 35);
            this.ButtonValider.TabIndex = 232;
            this.ButtonValider.Text = "Valider";
            this.ButtonValider.Click += new System.EventHandler(this.ButtonValider_Click);
            // 
            // LabelDescr
            // 
            this.LabelDescr.AutoSize = true;
            this.LabelDescr.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescr.ForeColor = System.Drawing.Color.Gray;
            this.LabelDescr.Location = new System.Drawing.Point(35, 303);
            this.LabelDescr.Name = "LabelDescr";
            this.LabelDescr.Size = new System.Drawing.Size(117, 18);
            this.LabelDescr.TabIndex = 231;
            this.LabelDescr.Text = "Description :";
            // 
            // LabelPat
            // 
            this.LabelPat.AutoSize = true;
            this.LabelPat.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPat.ForeColor = System.Drawing.Color.Gray;
            this.LabelPat.Location = new System.Drawing.Point(35, 229);
            this.LabelPat.Name = "LabelPat";
            this.LabelPat.Size = new System.Drawing.Size(82, 18);
            this.LabelPat.TabIndex = 227;
            this.LabelPat.Text = "Patient :";
            // 
            // LabelHeure
            // 
            this.LabelHeure.AutoSize = true;
            this.LabelHeure.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeure.ForeColor = System.Drawing.Color.Gray;
            this.LabelHeure.Location = new System.Drawing.Point(35, 173);
            this.LabelHeure.Name = "LabelHeure";
            this.LabelHeure.Size = new System.Drawing.Size(73, 18);
            this.LabelHeure.TabIndex = 225;
            this.LabelHeure.Text = "Heure :";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.ForeColor = System.Drawing.Color.Gray;
            this.LabelDate.Location = new System.Drawing.Point(35, 118);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(61, 18);
            this.LabelDate.TabIndex = 224;
            this.LabelDate.Text = "Date :";
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
            this.panelHeader.Size = new System.Drawing.Size(495, 48);
            this.panelHeader.TabIndex = 212;
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
            this.ButtonClose.Location = new System.Drawing.Point(440, 2);
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
            this.ButtonTitle.ButtonText = "Details de rendez-vous";
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
            this.ButtonTitle.Text = "Details de rendez-vous";
            this.ButtonTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonTitle.Textcolor = System.Drawing.Color.Black;
            this.ButtonTitle.TextFont = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonTitle.MouseDown += new System.EventHandler(this.ButtonTitle_MouseDown);
            // 
            // TextBoxHeure
            // 
            this.TextBoxHeure.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.TextBoxHeure.BorderRadius = 5;
            this.TextBoxHeure.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxHeure.DefaultText = "";
            this.TextBoxHeure.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.TextBoxHeure.DisabledState.FillColor = System.Drawing.Color.White;
            this.TextBoxHeure.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.TextBoxHeure.DisabledState.Parent = this.TextBoxHeure;
            this.TextBoxHeure.DisabledState.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.TextBoxHeure.Enabled = false;
            this.TextBoxHeure.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.TextBoxHeure.FocusedState.Parent = this.TextBoxHeure;
            this.TextBoxHeure.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.TextBoxHeure.ForeColor = System.Drawing.Color.Black;
            this.TextBoxHeure.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxHeure.HoverState.Parent = this.TextBoxHeure;
            this.TextBoxHeure.Location = new System.Drawing.Point(173, 168);
            this.TextBoxHeure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxHeure.Name = "TextBoxHeure";
            this.TextBoxHeure.PasswordChar = '\0';
            this.TextBoxHeure.PlaceholderText = "";
            this.TextBoxHeure.SelectedText = "";
            this.TextBoxHeure.ShadowDecoration.Parent = this.TextBoxHeure;
            this.TextBoxHeure.Size = new System.Drawing.Size(281, 36);
            this.TextBoxHeure.TabIndex = 243;
            this.TextBoxHeure.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // DetailsRDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(497, 486);
            this.Controls.Add(this.panelDRDV);
            this.Name = "DetailsRDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailsRDV";
            this.Load += new System.EventHandler(this.DetailsRDV_Load);
            this.panelDRDV.ResumeLayout(false);
            this.panelDRDV.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDRDV;
        private System.Windows.Forms.Panel panelHeader;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonClose;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonTitle;
        private Guna.UI.WinForms.GunaLabel LabelHeure;
        private Guna.UI.WinForms.GunaLabel LabelDate;
        private Guna.UI.WinForms.GunaLabel LabelPat;
        private Guna.UI.WinForms.GunaLabel LabelDescr;
        private Guna.UI2.WinForms.Guna2Button ButtonSupp;
        private Guna.UI2.WinForms.Guna2Button ButtonValider;
        private Guna.UI2.WinForms.Guna2Button ButtonAnnuler;
        private Guna.UI2.WinForms.Guna2Button ButtonEnvSMS;
        internal Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerDate;
        internal Guna.UI2.WinForms.Guna2TextBox TextBoxDescr;
        internal Guna.UI2.WinForms.Guna2TextBox TextBoxPat;
        internal System.Windows.Forms.ComboBox ComboBoxHeure;
        internal Guna.UI2.WinForms.Guna2TextBox TextBoxHeure;
        internal System.Windows.Forms.ComboBox ComboBoxMinute;
        private Guna.UI.WinForms.GunaLabel LabelNmRDVTit;
        internal Guna.UI.WinForms.GunaLabel LabelNmRDV;
    }
}