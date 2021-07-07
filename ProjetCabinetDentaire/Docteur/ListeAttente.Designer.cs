
namespace ProjetCabinetDentaire.Docteur
{
    partial class ListeAttente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelContant = new System.Windows.Forms.Panel();
            this.panelCopyright = new System.Windows.Forms.Panel();
            this.BoxDroitsLogo = new System.Windows.Forms.PictureBox();
            this.labelVersoin = new System.Windows.Forms.Label();
            this.labelDroitsReserves = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.ButtonSupp = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonValider = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonAnnuler = new Guna.UI2.WinForms.Guna2Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BoxReturn = new System.Windows.Forms.PictureBox();
            this.dataGridViewListeConsultations = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Num_Doss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomComplet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Services = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seances = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxAcc = new System.Windows.Forms.PictureBox();
            this.TextBoxNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.DateTimePickerCons = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelContant.SuspendLayout();
            this.panelCopyright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxDroitsLogo)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeConsultations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContant
            // 
            this.panelContant.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContant.Controls.Add(this.guna2TextBox1);
            this.panelContant.Controls.Add(this.TextBoxNom);
            this.panelContant.Controls.Add(this.pictureBoxAcc);
            this.panelContant.Controls.Add(this.dataGridViewListeConsultations);
            this.panelContant.Controls.Add(this.panelCopyright);
            this.panelContant.Controls.Add(this.ButtonSupp);
            this.panelContant.Controls.Add(this.ButtonValider);
            this.panelContant.Controls.Add(this.ButtonAnnuler);
            this.panelContant.Controls.Add(this.panelMenu);
            this.panelContant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContant.Location = new System.Drawing.Point(0, 0);
            this.panelContant.Name = "panelContant";
            this.panelContant.Size = new System.Drawing.Size(1064, 611);
            this.panelContant.TabIndex = 29;
            // 
            // panelCopyright
            // 
            this.panelCopyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelCopyright.Controls.Add(this.BoxDroitsLogo);
            this.panelCopyright.Controls.Add(this.labelVersoin);
            this.panelCopyright.Controls.Add(this.labelDroitsReserves);
            this.panelCopyright.Controls.Add(this.labelCopyright);
            this.panelCopyright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCopyright.Location = new System.Drawing.Point(0, 582);
            this.panelCopyright.Name = "panelCopyright";
            this.panelCopyright.Size = new System.Drawing.Size(1064, 29);
            this.panelCopyright.TabIndex = 211;
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
            this.ButtonSupp.Location = new System.Drawing.Point(852, 541);
            this.ButtonSupp.Name = "ButtonSupp";
            this.ButtonSupp.ShadowDecoration.Parent = this.ButtonSupp;
            this.ButtonSupp.Size = new System.Drawing.Size(107, 35);
            this.ButtonSupp.TabIndex = 210;
            this.ButtonSupp.Text = "Supprimer";
            // 
            // ButtonValider
            // 
            this.ButtonValider.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.ButtonValider.Location = new System.Drawing.Point(739, 541);
            this.ButtonValider.Name = "ButtonValider";
            this.ButtonValider.ShadowDecoration.Parent = this.ButtonValider;
            this.ButtonValider.Size = new System.Drawing.Size(107, 35);
            this.ButtonValider.TabIndex = 209;
            this.ButtonValider.Text = "Valider";
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
            this.ButtonAnnuler.Location = new System.Drawing.Point(626, 541);
            this.ButtonAnnuler.Name = "ButtonAnnuler";
            this.ButtonAnnuler.ShadowDecoration.Parent = this.ButtonAnnuler;
            this.ButtonAnnuler.Size = new System.Drawing.Size(107, 35);
            this.ButtonAnnuler.TabIndex = 208;
            this.ButtonAnnuler.Text = "Annuler";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelMenu.Controls.Add(this.DateTimePickerCons);
            this.panelMenu.Controls.Add(this.BoxReturn);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1064, 50);
            this.panelMenu.TabIndex = 32;
            // 
            // BoxReturn
            // 
            this.BoxReturn.BackColor = System.Drawing.Color.Transparent;
            this.BoxReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoxReturn.Image = global::ProjetCabinetDentaire.Properties.Resources.undo;
            this.BoxReturn.Location = new System.Drawing.Point(12, 6);
            this.BoxReturn.Name = "BoxReturn";
            this.BoxReturn.Size = new System.Drawing.Size(45, 36);
            this.BoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BoxReturn.TabIndex = 4;
            this.BoxReturn.TabStop = false;
            // 
            // dataGridViewListeConsultations
            // 
            this.dataGridViewListeConsultations.AllowUserToAddRows = false;
            this.dataGridViewListeConsultations.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dataGridViewListeConsultations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewListeConsultations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListeConsultations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListeConsultations.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListeConsultations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListeConsultations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewListeConsultations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListeConsultations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewListeConsultations.ColumnHeadersHeight = 40;
            this.dataGridViewListeConsultations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num_Doss,
            this.NomComplet,
            this.Services,
            this.Seances,
            this.Payement});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListeConsultations.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewListeConsultations.EnableHeadersVisualStyles = false;
            this.dataGridViewListeConsultations.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListeConsultations.Location = new System.Drawing.Point(14, 56);
            this.dataGridViewListeConsultations.Name = "dataGridViewListeConsultations";
            this.dataGridViewListeConsultations.ReadOnly = true;
            this.dataGridViewListeConsultations.RowHeadersVisible = false;
            this.dataGridViewListeConsultations.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10);
            this.dataGridViewListeConsultations.RowTemplate.Height = 55;
            this.dataGridViewListeConsultations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListeConsultations.Size = new System.Drawing.Size(1037, 462);
            this.dataGridViewListeConsultations.TabIndex = 212;
            this.dataGridViewListeConsultations.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridViewListeConsultations.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewListeConsultations.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewListeConsultations.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewListeConsultations.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewListeConsultations.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewListeConsultations.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListeConsultations.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListeConsultations.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListeConsultations.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewListeConsultations.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewListeConsultations.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewListeConsultations.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewListeConsultations.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridViewListeConsultations.ThemeStyle.ReadOnly = true;
            this.dataGridViewListeConsultations.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewListeConsultations.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewListeConsultations.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewListeConsultations.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewListeConsultations.ThemeStyle.RowsStyle.Height = 55;
            this.dataGridViewListeConsultations.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.dataGridViewListeConsultations.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // Num_Doss
            // 
            this.Num_Doss.FillWeight = 95.63452F;
            this.Num_Doss.HeaderText = "Numéro dossier";
            this.Num_Doss.Name = "Num_Doss";
            this.Num_Doss.ReadOnly = true;
            // 
            // NomComplet
            // 
            this.NomComplet.FillWeight = 95.63452F;
            this.NomComplet.HeaderText = "Nom Complet";
            this.NomComplet.Name = "NomComplet";
            this.NomComplet.ReadOnly = true;
            // 
            // Services
            // 
            this.Services.HeaderText = "Services";
            this.Services.Name = "Services";
            this.Services.ReadOnly = true;
            // 
            // Seances
            // 
            this.Seances.HeaderText = "Seances";
            this.Seances.Name = "Seances";
            this.Seances.ReadOnly = true;
            // 
            // Payement
            // 
            this.Payement.HeaderText = "Payement";
            this.Payement.Name = "Payement";
            this.Payement.ReadOnly = true;
            // 
            // pictureBoxAcc
            // 
            this.pictureBoxAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxAcc.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAcc.Image = global::ProjetCabinetDentaire.Properties.Resources.sync;
            this.pictureBoxAcc.Location = new System.Drawing.Point(14, 540);
            this.pictureBoxAcc.Name = "pictureBoxAcc";
            this.pictureBoxAcc.Size = new System.Drawing.Size(45, 36);
            this.pictureBoxAcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAcc.TabIndex = 213;
            this.pictureBoxAcc.TabStop = false;
            // 
            // TextBoxNom
            // 
            this.TextBoxNom.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxNom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.TextBoxNom.BorderRadius = 5;
            this.TextBoxNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxNom.DefaultText = "";
            this.TextBoxNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNom.DisabledState.Parent = this.TextBoxNom;
            this.TextBoxNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.TextBoxNom.FocusedState.Parent = this.TextBoxNom;
            this.TextBoxNom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNom.ForeColor = System.Drawing.Color.Black;
            this.TextBoxNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxNom.HoverState.Parent = this.TextBoxNom;
            this.TextBoxNom.Location = new System.Drawing.Point(102, 540);
            this.TextBoxNom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxNom.Name = "TextBoxNom";
            this.TextBoxNom.PasswordChar = '\0';
            this.TextBoxNom.PlaceholderText = "";
            this.TextBoxNom.SelectedText = "";
            this.TextBoxNom.ShadowDecoration.Parent = this.TextBoxNom;
            this.TextBoxNom.Size = new System.Drawing.Size(154, 36);
            this.TextBoxNom.TabIndex = 289;
            this.TextBoxNom.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // DateTimePickerCons
            // 
            this.DateTimePickerCons.BackColor = System.Drawing.Color.Transparent;
            this.DateTimePickerCons.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.DateTimePickerCons.BorderRadius = 5;
            this.DateTimePickerCons.BorderThickness = 1;
            this.DateTimePickerCons.CheckedState.Parent = this.DateTimePickerCons;
            this.DateTimePickerCons.FillColor = System.Drawing.Color.White;
            this.DateTimePickerCons.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePickerCons.HoverState.Parent = this.DateTimePickerCons;
            this.DateTimePickerCons.Location = new System.Drawing.Point(814, 6);
            this.DateTimePickerCons.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerCons.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerCons.Name = "DateTimePickerCons";
            this.DateTimePickerCons.ShadowDecoration.Parent = this.DateTimePickerCons;
            this.DateTimePickerCons.Size = new System.Drawing.Size(186, 36);
            this.DateTimePickerCons.TabIndex = 300;
            this.DateTimePickerCons.Value = new System.DateTime(2021, 3, 17, 18, 57, 58, 360);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.guna2TextBox1.BorderRadius = 5;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(273, 540);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(154, 36);
            this.guna2TextBox1.TabIndex = 290;
            this.guna2TextBox1.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // ListeAttente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 611);
            this.Controls.Add(this.panelContant);
            this.Name = "ListeAttente";
            this.Text = "ListeAttente";
            this.panelContant.ResumeLayout(false);
            this.panelCopyright.ResumeLayout(false);
            this.panelCopyright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxDroitsLogo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BoxReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeConsultations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContant;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox BoxReturn;
        private Guna.UI2.WinForms.Guna2Button ButtonValider;
        private Guna.UI2.WinForms.Guna2Button ButtonAnnuler;
        private Guna.UI2.WinForms.Guna2Button ButtonSupp;
        private System.Windows.Forms.Panel panelCopyright;
        private System.Windows.Forms.PictureBox BoxDroitsLogo;
        private System.Windows.Forms.Label labelVersoin;
        private System.Windows.Forms.Label labelDroitsReserves;
        private System.Windows.Forms.Label labelCopyright;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewListeConsultations;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Doss;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomComplet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Services;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seances;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payement;
        private System.Windows.Forms.PictureBox pictureBoxAcc;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxNom;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerCons;
    }
}