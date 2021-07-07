
namespace ProjetCabinetDentaire.Docteur
{
    partial class Patient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ButtonRech = new Guna.UI2.WinForms.Guna2Button();
            this.labelNmPat = new System.Windows.Forms.Label();
            this.TextBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComboBoxSort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelSort = new System.Windows.Forms.Label();
            this.BoxReturn = new System.Windows.Forms.PictureBox();
            this.dataGridViewListePatients = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.Num_Doss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIN_Passeport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCopyright = new System.Windows.Forms.Panel();
            this.BoxDroitsLogo = new System.Windows.Forms.PictureBox();
            this.labelVersoin = new System.Windows.Forms.Label();
            this.labelDroitsReserves = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.ButtonAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonMod = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSupp = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBoxAcc = new System.Windows.Forms.PictureBox();
            this.ButtonRDV = new Guna.UI2.WinForms.Guna2Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListePatients)).BeginInit();
            this.panelCopyright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxDroitsLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelMenu.Controls.Add(this.ButtonRech);
            this.panelMenu.Controls.Add(this.labelNmPat);
            this.panelMenu.Controls.Add(this.TextBoxSearch);
            this.panelMenu.Controls.Add(this.ComboBoxSort);
            this.panelMenu.Controls.Add(this.labelSort);
            this.panelMenu.Controls.Add(this.BoxReturn);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1064, 50);
            this.panelMenu.TabIndex = 5;
            // 
            // ButtonRech
            // 
            this.ButtonRech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRech.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonRech.BorderRadius = 5;
            this.ButtonRech.BorderThickness = 1;
            this.ButtonRech.CheckedState.Parent = this.ButtonRech;
            this.ButtonRech.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRech.CustomImages.Parent = this.ButtonRech;
            this.ButtonRech.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonRech.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonRech.ForeColor = System.Drawing.Color.White;
            this.ButtonRech.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(199)))), ((int)(((byte)(178)))));
            this.ButtonRech.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(199)))), ((int)(((byte)(178)))));
            this.ButtonRech.HoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonRech.HoverState.Parent = this.ButtonRech;
            this.ButtonRech.Location = new System.Drawing.Point(945, 7);
            this.ButtonRech.Name = "ButtonRech";
            this.ButtonRech.ShadowDecoration.Parent = this.ButtonRech;
            this.ButtonRech.Size = new System.Drawing.Size(107, 35);
            this.ButtonRech.TabIndex = 16;
            this.ButtonRech.Text = "Rechercher";
            this.ButtonRech.Click += new System.EventHandler(this.ButtonRech_Click);
            // 
            // labelNmPat
            // 
            this.labelNmPat.AutoSize = true;
            this.labelNmPat.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNmPat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(199)))), ((int)(((byte)(178)))));
            this.labelNmPat.Location = new System.Drawing.Point(509, 14);
            this.labelNmPat.Name = "labelNmPat";
            this.labelNmPat.Size = new System.Drawing.Size(132, 21);
            this.labelNmPat.TabIndex = 11;
            this.labelNmPat.Text = "Nombres Patients";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.AutoRoundedCorners = true;
            this.TextBoxSearch.BorderRadius = 17;
            this.TextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearch.DefaultText = "";
            this.TextBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSearch.DisabledState.Parent = this.TextBoxSearch;
            this.TextBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSearch.FocusedState.Parent = this.TextBoxSearch;
            this.TextBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSearch.HoverState.Parent = this.TextBoxSearch;
            this.TextBoxSearch.IconLeft = global::ProjetCabinetDentaire.Properties.Resources.search;
            this.TextBoxSearch.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.TextBoxSearch.IconLeftSize = new System.Drawing.Size(15, 15);
            this.TextBoxSearch.Location = new System.Drawing.Point(718, 7);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.PasswordChar = '\0';
            this.TextBoxSearch.PlaceholderText = "Rechercher";
            this.TextBoxSearch.SelectedText = "";
            this.TextBoxSearch.ShadowDecoration.Parent = this.TextBoxSearch;
            this.TextBoxSearch.Size = new System.Drawing.Size(221, 36);
            this.TextBoxSearch.TabIndex = 10;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // ComboBoxSort
            // 
            this.ComboBoxSort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ComboBoxSort.BorderColor = System.Drawing.Color.LightGray;
            this.ComboBoxSort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSort.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ComboBoxSort.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxSort.FocusedState.Parent = this.ComboBoxSort;
            this.ComboBoxSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxSort.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxSort.FormattingEnabled = true;
            this.ComboBoxSort.HoverState.Parent = this.ComboBoxSort;
            this.ComboBoxSort.ItemHeight = 30;
            this.ComboBoxSort.Items.AddRange(new object[] {
            "CIN ou Passport",
            "Nom",
            "Numéro dossier",
            "Prénom"});
            this.ComboBoxSort.ItemsAppearance.Parent = this.ComboBoxSort;
            this.ComboBoxSort.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Black;
            this.ComboBoxSort.Location = new System.Drawing.Point(223, 6);
            this.ComboBoxSort.Name = "ComboBoxSort";
            this.ComboBoxSort.ShadowDecoration.Parent = this.ComboBoxSort;
            this.ComboBoxSort.Size = new System.Drawing.Size(200, 36);
            this.ComboBoxSort.StartIndex = 0;
            this.ComboBoxSort.TabIndex = 9;
            this.ComboBoxSort.TextOffset = new System.Drawing.Point(2, 0);
            this.ComboBoxSort.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSort_SelectedIndexChanged);
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSort.Location = new System.Drawing.Point(146, 15);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(71, 20);
            this.labelSort.TabIndex = 7;
            this.labelSort.Text = "Trier par :";
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
            this.BoxReturn.Click += new System.EventHandler(this.BoxReturn_Click);
            // 
            // dataGridViewListePatients
            // 
            this.dataGridViewListePatients.AllowUserToAddRows = false;
            this.dataGridViewListePatients.AllowUserToDeleteRows = false;
            this.dataGridViewListePatients.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewListePatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewListePatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListePatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListePatients.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListePatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListePatients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewListePatients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListePatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewListePatients.ColumnHeadersHeight = 40;
            this.dataGridViewListePatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Photo,
            this.Num_Doss,
            this.Prenom,
            this.Nom,
            this.CIN_Passeport,
            this.Date_Naissance,
            this.Telephone});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListePatients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewListePatients.EnableHeadersVisualStyles = false;
            this.dataGridViewListePatients.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListePatients.Location = new System.Drawing.Point(12, 56);
            this.dataGridViewListePatients.Name = "dataGridViewListePatients";
            this.dataGridViewListePatients.ReadOnly = true;
            this.dataGridViewListePatients.RowHeadersVisible = false;
            this.dataGridViewListePatients.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10);
            this.dataGridViewListePatients.RowTemplate.Height = 55;
            this.dataGridViewListePatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListePatients.Size = new System.Drawing.Size(1040, 425);
            this.dataGridViewListePatients.TabIndex = 6;
            this.dataGridViewListePatients.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridViewListePatients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewListePatients.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewListePatients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewListePatients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewListePatients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewListePatients.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListePatients.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListePatients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListePatients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewListePatients.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewListePatients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewListePatients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewListePatients.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridViewListePatients.ThemeStyle.ReadOnly = true;
            this.dataGridViewListePatients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewListePatients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewListePatients.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewListePatients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewListePatients.ThemeStyle.RowsStyle.Height = 55;
            this.dataGridViewListePatients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.dataGridViewListePatients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewListePatients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListePatients_CellDoubleClick);
            // 
            // Photo
            // 
            this.Photo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Photo.FillWeight = 121.8274F;
            this.Photo.HeaderText = "";
            this.Photo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Photo.MinimumWidth = 45;
            this.Photo.Name = "Photo";
            this.Photo.ReadOnly = true;
            this.Photo.Width = 45;
            // 
            // Num_Doss
            // 
            this.Num_Doss.FillWeight = 95.63452F;
            this.Num_Doss.HeaderText = "Numéro dossier";
            this.Num_Doss.Name = "Num_Doss";
            this.Num_Doss.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.FillWeight = 95.63452F;
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.FillWeight = 95.63452F;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // CIN_Passeport
            // 
            this.CIN_Passeport.HeaderText = "CIN ou Passeport";
            this.CIN_Passeport.Name = "CIN_Passeport";
            this.CIN_Passeport.ReadOnly = true;
            // 
            // Date_Naissance
            // 
            this.Date_Naissance.FillWeight = 95.63452F;
            this.Date_Naissance.HeaderText = "Date de naissance";
            this.Date_Naissance.Name = "Date_Naissance";
            this.Date_Naissance.ReadOnly = true;
            // 
            // Telephone
            // 
            this.Telephone.FillWeight = 95.63452F;
            this.Telephone.HeaderText = "Télephone";
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            // 
            // panelCopyright
            // 
            this.panelCopyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelCopyright.Controls.Add(this.BoxDroitsLogo);
            this.panelCopyright.Controls.Add(this.labelVersoin);
            this.panelCopyright.Controls.Add(this.labelDroitsReserves);
            this.panelCopyright.Controls.Add(this.labelCopyright);
            this.panelCopyright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCopyright.Location = new System.Drawing.Point(0, 541);
            this.panelCopyright.Name = "panelCopyright";
            this.panelCopyright.Size = new System.Drawing.Size(1064, 29);
            this.panelCopyright.TabIndex = 7;
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
            // ButtonAjouter
            // 
            this.ButtonAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAjouter.BorderColor = System.Drawing.Color.LimeGreen;
            this.ButtonAjouter.BorderRadius = 5;
            this.ButtonAjouter.BorderThickness = 1;
            this.ButtonAjouter.CheckedState.Parent = this.ButtonAjouter;
            this.ButtonAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAjouter.CustomImages.Parent = this.ButtonAjouter;
            this.ButtonAjouter.FillColor = System.Drawing.Color.Transparent;
            this.ButtonAjouter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAjouter.ForeColor = System.Drawing.Color.LimeGreen;
            this.ButtonAjouter.HoverState.FillColor = System.Drawing.Color.LimeGreen;
            this.ButtonAjouter.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ButtonAjouter.HoverState.Parent = this.ButtonAjouter;
            this.ButtonAjouter.Location = new System.Drawing.Point(704, 487);
            this.ButtonAjouter.Name = "ButtonAjouter";
            this.ButtonAjouter.ShadowDecoration.Parent = this.ButtonAjouter;
            this.ButtonAjouter.Size = new System.Drawing.Size(107, 35);
            this.ButtonAjouter.TabIndex = 8;
            this.ButtonAjouter.Text = "Ajouter";
            this.ButtonAjouter.Click += new System.EventHandler(this.ButtonAjouter_Click);
            // 
            // ButtonMod
            // 
            this.ButtonMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMod.BorderColor = System.Drawing.Color.Orange;
            this.ButtonMod.BorderRadius = 5;
            this.ButtonMod.BorderThickness = 1;
            this.ButtonMod.CheckedState.Parent = this.ButtonMod;
            this.ButtonMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMod.CustomImages.Parent = this.ButtonMod;
            this.ButtonMod.FillColor = System.Drawing.Color.Transparent;
            this.ButtonMod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonMod.ForeColor = System.Drawing.Color.Orange;
            this.ButtonMod.HoverState.FillColor = System.Drawing.Color.Orange;
            this.ButtonMod.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ButtonMod.HoverState.Parent = this.ButtonMod;
            this.ButtonMod.Location = new System.Drawing.Point(817, 487);
            this.ButtonMod.Name = "ButtonMod";
            this.ButtonMod.ShadowDecoration.Parent = this.ButtonMod;
            this.ButtonMod.Size = new System.Drawing.Size(107, 35);
            this.ButtonMod.TabIndex = 9;
            this.ButtonMod.Text = "Modifier";
            this.ButtonMod.Click += new System.EventHandler(this.ButtonMod_Click);
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
            this.ButtonSupp.Location = new System.Drawing.Point(931, 487);
            this.ButtonSupp.Name = "ButtonSupp";
            this.ButtonSupp.ShadowDecoration.Parent = this.ButtonSupp;
            this.ButtonSupp.Size = new System.Drawing.Size(107, 35);
            this.ButtonSupp.TabIndex = 10;
            this.ButtonSupp.Text = "Supprimer";
            this.ButtonSupp.Click += new System.EventHandler(this.ButtonSupp_Click);
            // 
            // pictureBoxAcc
            // 
            this.pictureBoxAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxAcc.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAcc.Image = global::ProjetCabinetDentaire.Properties.Resources.sync;
            this.pictureBoxAcc.Location = new System.Drawing.Point(12, 487);
            this.pictureBoxAcc.Name = "pictureBoxAcc";
            this.pictureBoxAcc.Size = new System.Drawing.Size(45, 36);
            this.pictureBoxAcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAcc.TabIndex = 11;
            this.pictureBoxAcc.TabStop = false;
            this.pictureBoxAcc.Click += new System.EventHandler(this.pictureBoxAcc_Click);
            // 
            // ButtonRDV
            // 
            this.ButtonRDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonRDV.BorderColor = System.Drawing.Color.Orange;
            this.ButtonRDV.BorderRadius = 5;
            this.ButtonRDV.BorderThickness = 1;
            this.ButtonRDV.CheckedState.Parent = this.ButtonRDV;
            this.ButtonRDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRDV.CustomImages.Parent = this.ButtonRDV;
            this.ButtonRDV.FillColor = System.Drawing.Color.Transparent;
            this.ButtonRDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonRDV.ForeColor = System.Drawing.Color.Orange;
            this.ButtonRDV.HoverState.FillColor = System.Drawing.Color.Orange;
            this.ButtonRDV.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ButtonRDV.HoverState.Parent = this.ButtonRDV;
            this.ButtonRDV.Location = new System.Drawing.Point(91, 487);
            this.ButtonRDV.Name = "ButtonRDV";
            this.ButtonRDV.ShadowDecoration.Parent = this.ButtonRDV;
            this.ButtonRDV.Size = new System.Drawing.Size(169, 35);
            this.ButtonRDV.TabIndex = 12;
            this.ButtonRDV.Text = "Choisir Rendez-vous";
            this.ButtonRDV.Click += new System.EventHandler(this.ButtonRDV_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1064, 570);
            this.Controls.Add(this.ButtonRDV);
            this.Controls.Add(this.pictureBoxAcc);
            this.Controls.Add(this.ButtonSupp);
            this.Controls.Add(this.ButtonMod);
            this.Controls.Add(this.ButtonAjouter);
            this.Controls.Add(this.panelCopyright);
            this.Controls.Add(this.dataGridViewListePatients);
            this.Controls.Add(this.panelMenu);
            this.Name = "Patient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListePatients)).EndInit();
            this.panelCopyright.ResumeLayout(false);
            this.panelCopyright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxDroitsLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox BoxReturn;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelSort;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxSort;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewListePatients;
        private System.Windows.Forms.Panel panelCopyright;
        private System.Windows.Forms.PictureBox BoxDroitsLogo;
        private System.Windows.Forms.Label labelVersoin;
        private System.Windows.Forms.Label labelDroitsReserves;
        private System.Windows.Forms.Label labelCopyright;
        private Guna.UI2.WinForms.Guna2Button ButtonAjouter;
        private Guna.UI2.WinForms.Guna2Button ButtonMod;
        private Guna.UI2.WinForms.Guna2Button ButtonSupp;
        private System.Windows.Forms.PictureBox pictureBoxAcc;
        private System.Windows.Forms.Label labelNmPat;
        private Guna.UI2.WinForms.Guna2Button ButtonRech;
        private Guna.UI2.WinForms.Guna2Button ButtonRDV;
        private System.Windows.Forms.DataGridViewImageColumn Photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Doss;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIN_Passeport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Naissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
    }
}