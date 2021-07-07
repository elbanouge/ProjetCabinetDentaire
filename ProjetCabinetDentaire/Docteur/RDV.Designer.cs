
namespace ProjetCabinetDentaire.Docteur
{
    partial class RDV
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
            this.PanelHeaderRDV = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelPagination = new System.Windows.Forms.Panel();
            this.ButtonToday = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonPreveuis = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ButtonNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BoxReturn = new System.Windows.Forms.PictureBox();
            this.panelCopyright = new System.Windows.Forms.Panel();
            this.BoxDroitsLogo = new System.Windows.Forms.PictureBox();
            this.labelVersoin = new System.Windows.Forms.Label();
            this.labelDroitsReserves = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.PanelDate = new System.Windows.Forms.Panel();
            this.ButtonSearchDate = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ComboBoxYear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBoxMonth = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ButtonDim = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonLan = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSam = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonMardi = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonVend = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonJeudi = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonMerc = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonCalandrer = new Guna.UI2.WinForms.Guna2ImageButton();
            this.flDays = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.PanelHeaderRDV.SuspendLayout();
            this.PanelPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxReturn)).BeginInit();
            this.panelCopyright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxDroitsLogo)).BeginInit();
            this.PanelDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHeaderRDV
            // 
            this.PanelHeaderRDV.BackColor = System.Drawing.SystemColors.Control;
            this.PanelHeaderRDV.BorderColor = System.Drawing.Color.Black;
            this.PanelHeaderRDV.BorderThickness = 1;
            this.PanelHeaderRDV.Controls.Add(this.ButtonClose);
            this.PanelHeaderRDV.Controls.Add(this.BoxReturn);
            this.PanelHeaderRDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeaderRDV.Location = new System.Drawing.Point(0, 0);
            this.PanelHeaderRDV.Name = "PanelHeaderRDV";
            this.PanelHeaderRDV.ShadowDecoration.Parent = this.PanelHeaderRDV;
            this.PanelHeaderRDV.Size = new System.Drawing.Size(1076, 50);
            this.PanelHeaderRDV.TabIndex = 1;
            // 
            // PanelPagination
            // 
            this.PanelPagination.Controls.Add(this.ButtonToday);
            this.PanelPagination.Controls.Add(this.ButtonPreveuis);
            this.PanelPagination.Controls.Add(this.ButtonNext);
            this.PanelPagination.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelPagination.Location = new System.Drawing.Point(841, 0);
            this.PanelPagination.Name = "PanelPagination";
            this.PanelPagination.Size = new System.Drawing.Size(233, 120);
            this.PanelPagination.TabIndex = 15;
            // 
            // ButtonToday
            // 
            this.ButtonToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonToday.BackColor = System.Drawing.Color.Transparent;
            this.ButtonToday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonToday.BorderRadius = 5;
            this.ButtonToday.BorderThickness = 1;
            this.ButtonToday.CheckedState.Parent = this.ButtonToday;
            this.ButtonToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonToday.CustomImages.Parent = this.ButtonToday;
            this.ButtonToday.FillColor = System.Drawing.Color.Transparent;
            this.ButtonToday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonToday.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonToday.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonToday.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ButtonToday.HoverState.Parent = this.ButtonToday;
            this.ButtonToday.Image = global::ProjetCabinetDentaire.Properties.Resources.calendar;
            this.ButtonToday.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonToday.Location = new System.Drawing.Point(60, 8);
            this.ButtonToday.Name = "ButtonToday";
            this.ButtonToday.ShadowDecoration.Parent = this.ButtonToday;
            this.ButtonToday.Size = new System.Drawing.Size(114, 34);
            this.ButtonToday.TabIndex = 22;
            this.ButtonToday.Text = "Aujourd\'hui";
            this.ButtonToday.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonToday.Click += new System.EventHandler(this.ButtonToday_Click);
            // 
            // ButtonPreveuis
            // 
            this.ButtonPreveuis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPreveuis.CheckedState.Parent = this.ButtonPreveuis;
            this.ButtonPreveuis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPreveuis.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.ButtonPreveuis.HoverState.Parent = this.ButtonPreveuis;
            this.ButtonPreveuis.Image = global::ProjetCabinetDentaire.Properties.Resources.left_arrow;
            this.ButtonPreveuis.ImageSize = new System.Drawing.Size(25, 25);
            this.ButtonPreveuis.Location = new System.Drawing.Point(4, 8);
            this.ButtonPreveuis.Name = "ButtonPreveuis";
            this.ButtonPreveuis.PressedState.Parent = this.ButtonPreveuis;
            this.ButtonPreveuis.Size = new System.Drawing.Size(50, 34);
            this.ButtonPreveuis.TabIndex = 4;
            this.ButtonPreveuis.Click += new System.EventHandler(this.ButtonPreveuis_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNext.CheckedState.Parent = this.ButtonNext;
            this.ButtonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNext.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.ButtonNext.HoverState.Parent = this.ButtonNext;
            this.ButtonNext.Image = global::ProjetCabinetDentaire.Properties.Resources.right_arrow;
            this.ButtonNext.ImageSize = new System.Drawing.Size(25, 25);
            this.ButtonNext.Location = new System.Drawing.Point(180, 8);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.PressedState.Parent = this.ButtonNext;
            this.ButtonNext.Size = new System.Drawing.Size(50, 34);
            this.ButtonNext.TabIndex = 3;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
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
            this.panelCopyright.Size = new System.Drawing.Size(1076, 29);
            this.panelCopyright.TabIndex = 19;
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
            this.labelVersoin.Location = new System.Drawing.Point(992, 8);
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
            // PanelDate
            // 
            this.PanelDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDate.Controls.Add(this.ButtonSearchDate);
            this.PanelDate.Controls.Add(this.ComboBoxYear);
            this.PanelDate.Controls.Add(this.ComboBoxMonth);
            this.PanelDate.Controls.Add(this.ButtonDim);
            this.PanelDate.Controls.Add(this.ButtonLan);
            this.PanelDate.Controls.Add(this.ButtonSam);
            this.PanelDate.Controls.Add(this.ButtonMardi);
            this.PanelDate.Controls.Add(this.ButtonVend);
            this.PanelDate.Controls.Add(this.ButtonJeudi);
            this.PanelDate.Controls.Add(this.ButtonMerc);
            this.PanelDate.Controls.Add(this.ButtonCalandrer);
            this.PanelDate.Controls.Add(this.PanelPagination);
            this.PanelDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDate.Location = new System.Drawing.Point(0, 50);
            this.PanelDate.Name = "PanelDate";
            this.PanelDate.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.PanelDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PanelDate.Size = new System.Drawing.Size(1076, 122);
            this.PanelDate.TabIndex = 20;
            // 
            // ButtonSearchDate
            // 
            this.ButtonSearchDate.CheckedState.Parent = this.ButtonSearchDate;
            this.ButtonSearchDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSearchDate.HoverState.ImageSize = new System.Drawing.Size(45, 40);
            this.ButtonSearchDate.HoverState.Parent = this.ButtonSearchDate;
            this.ButtonSearchDate.Image = global::ProjetCabinetDentaire.Properties.Resources.SearchDate;
            this.ButtonSearchDate.ImageSize = new System.Drawing.Size(40, 35);
            this.ButtonSearchDate.Location = new System.Drawing.Point(397, 20);
            this.ButtonSearchDate.Name = "ButtonSearchDate";
            this.ButtonSearchDate.PressedState.Parent = this.ButtonSearchDate;
            this.ButtonSearchDate.Size = new System.Drawing.Size(54, 36);
            this.ButtonSearchDate.TabIndex = 41;
            this.ButtonSearchDate.Click += new System.EventHandler(this.ButtonSearchDate_Click);
            // 
            // ComboBoxYear
            // 
            this.ComboBoxYear.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxYear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.ComboBoxYear.BorderRadius = 5;
            this.ComboBoxYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxYear.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ComboBoxYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ComboBoxYear.FocusedState.Parent = this.ComboBoxYear;
            this.ComboBoxYear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxYear.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxYear.FormattingEnabled = true;
            this.ComboBoxYear.HoverState.Parent = this.ComboBoxYear;
            this.ComboBoxYear.ItemHeight = 30;
            this.ComboBoxYear.ItemsAppearance.Parent = this.ComboBoxYear;
            this.ComboBoxYear.Location = new System.Drawing.Point(283, 20);
            this.ComboBoxYear.Name = "ComboBoxYear";
            this.ComboBoxYear.ShadowDecoration.Parent = this.ComboBoxYear;
            this.ComboBoxYear.Size = new System.Drawing.Size(108, 36);
            this.ComboBoxYear.TabIndex = 40;
            this.ComboBoxYear.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // ComboBoxMonth
            // 
            this.ComboBoxMonth.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxMonth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.ComboBoxMonth.BorderRadius = 5;
            this.ComboBoxMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMonth.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ComboBoxMonth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ComboBoxMonth.FocusedState.Parent = this.ComboBoxMonth;
            this.ComboBoxMonth.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMonth.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxMonth.FormattingEnabled = true;
            this.ComboBoxMonth.HoverState.Parent = this.ComboBoxMonth;
            this.ComboBoxMonth.ItemHeight = 30;
            this.ComboBoxMonth.ItemsAppearance.Parent = this.ComboBoxMonth;
            this.ComboBoxMonth.Location = new System.Drawing.Point(127, 20);
            this.ComboBoxMonth.Name = "ComboBoxMonth";
            this.ComboBoxMonth.ShadowDecoration.Parent = this.ComboBoxMonth;
            this.ComboBoxMonth.Size = new System.Drawing.Size(150, 36);
            this.ComboBoxMonth.TabIndex = 39;
            this.ComboBoxMonth.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // ButtonDim
            // 
            this.ButtonDim.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDim.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonDim.BorderRadius = 5;
            this.ButtonDim.BorderThickness = 1;
            this.ButtonDim.CheckedState.Parent = this.ButtonDim;
            this.ButtonDim.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonDim.CustomImages.Parent = this.ButtonDim;
            this.ButtonDim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ButtonDim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDim.ForeColor = System.Drawing.Color.Black;
            this.ButtonDim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonDim.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonDim.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ButtonDim.HoverState.Parent = this.ButtonDim;
            this.ButtonDim.Location = new System.Drawing.Point(5, 84);
            this.ButtonDim.Name = "ButtonDim";
            this.ButtonDim.ShadowDecoration.Parent = this.ButtonDim;
            this.ButtonDim.Size = new System.Drawing.Size(136, 30);
            this.ButtonDim.TabIndex = 33;
            this.ButtonDim.Text = "Dimanche ";
            // 
            // ButtonLan
            // 
            this.ButtonLan.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonLan.BorderRadius = 5;
            this.ButtonLan.BorderThickness = 1;
            this.ButtonLan.CheckedState.Parent = this.ButtonLan;
            this.ButtonLan.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonLan.CustomImages.Parent = this.ButtonLan;
            this.ButtonLan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonLan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLan.ForeColor = System.Drawing.Color.Black;
            this.ButtonLan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonLan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonLan.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ButtonLan.HoverState.Parent = this.ButtonLan;
            this.ButtonLan.Location = new System.Drawing.Point(153, 84);
            this.ButtonLan.Name = "ButtonLan";
            this.ButtonLan.ShadowDecoration.Parent = this.ButtonLan;
            this.ButtonLan.Size = new System.Drawing.Size(136, 30);
            this.ButtonLan.TabIndex = 32;
            this.ButtonLan.Text = "Lundi";
            // 
            // ButtonSam
            // 
            this.ButtonSam.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonSam.BorderRadius = 5;
            this.ButtonSam.BorderThickness = 1;
            this.ButtonSam.CheckedState.Parent = this.ButtonSam;
            this.ButtonSam.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonSam.CustomImages.Parent = this.ButtonSam;
            this.ButtonSam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonSam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSam.ForeColor = System.Drawing.Color.Black;
            this.ButtonSam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonSam.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonSam.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ButtonSam.HoverState.Parent = this.ButtonSam;
            this.ButtonSam.Location = new System.Drawing.Point(893, 84);
            this.ButtonSam.Name = "ButtonSam";
            this.ButtonSam.ShadowDecoration.Parent = this.ButtonSam;
            this.ButtonSam.Size = new System.Drawing.Size(136, 30);
            this.ButtonSam.TabIndex = 38;
            this.ButtonSam.Text = "Samedi";
            // 
            // ButtonMardi
            // 
            this.ButtonMardi.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMardi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonMardi.BorderRadius = 5;
            this.ButtonMardi.BorderThickness = 1;
            this.ButtonMardi.CheckedState.Parent = this.ButtonMardi;
            this.ButtonMardi.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonMardi.CustomImages.Parent = this.ButtonMardi;
            this.ButtonMardi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonMardi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMardi.ForeColor = System.Drawing.Color.Black;
            this.ButtonMardi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonMardi.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonMardi.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ButtonMardi.HoverState.Parent = this.ButtonMardi;
            this.ButtonMardi.Location = new System.Drawing.Point(301, 84);
            this.ButtonMardi.Name = "ButtonMardi";
            this.ButtonMardi.ShadowDecoration.Parent = this.ButtonMardi;
            this.ButtonMardi.Size = new System.Drawing.Size(136, 30);
            this.ButtonMardi.TabIndex = 34;
            this.ButtonMardi.Text = "Mardi";
            // 
            // ButtonVend
            // 
            this.ButtonVend.BackColor = System.Drawing.Color.Transparent;
            this.ButtonVend.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonVend.BorderRadius = 5;
            this.ButtonVend.BorderThickness = 1;
            this.ButtonVend.CheckedState.Parent = this.ButtonVend;
            this.ButtonVend.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonVend.CustomImages.Parent = this.ButtonVend;
            this.ButtonVend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonVend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonVend.ForeColor = System.Drawing.Color.Black;
            this.ButtonVend.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonVend.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonVend.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ButtonVend.HoverState.Parent = this.ButtonVend;
            this.ButtonVend.Location = new System.Drawing.Point(745, 84);
            this.ButtonVend.Name = "ButtonVend";
            this.ButtonVend.ShadowDecoration.Parent = this.ButtonVend;
            this.ButtonVend.Size = new System.Drawing.Size(136, 30);
            this.ButtonVend.TabIndex = 37;
            this.ButtonVend.Text = "Vendredi";
            // 
            // ButtonJeudi
            // 
            this.ButtonJeudi.BackColor = System.Drawing.Color.Transparent;
            this.ButtonJeudi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonJeudi.BorderRadius = 5;
            this.ButtonJeudi.BorderThickness = 1;
            this.ButtonJeudi.CheckedState.Parent = this.ButtonJeudi;
            this.ButtonJeudi.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonJeudi.CustomImages.Parent = this.ButtonJeudi;
            this.ButtonJeudi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonJeudi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonJeudi.ForeColor = System.Drawing.Color.Black;
            this.ButtonJeudi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonJeudi.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonJeudi.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ButtonJeudi.HoverState.Parent = this.ButtonJeudi;
            this.ButtonJeudi.Location = new System.Drawing.Point(449, 84);
            this.ButtonJeudi.Name = "ButtonJeudi";
            this.ButtonJeudi.ShadowDecoration.Parent = this.ButtonJeudi;
            this.ButtonJeudi.Size = new System.Drawing.Size(136, 30);
            this.ButtonJeudi.TabIndex = 35;
            this.ButtonJeudi.Text = "Jeudi";
            // 
            // ButtonMerc
            // 
            this.ButtonMerc.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMerc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonMerc.BorderRadius = 5;
            this.ButtonMerc.BorderThickness = 1;
            this.ButtonMerc.CheckedState.Parent = this.ButtonMerc;
            this.ButtonMerc.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonMerc.CustomImages.Parent = this.ButtonMerc;
            this.ButtonMerc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonMerc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMerc.ForeColor = System.Drawing.Color.Black;
            this.ButtonMerc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonMerc.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.ButtonMerc.HoverState.ForeColor = System.Drawing.Color.Black;
            this.ButtonMerc.HoverState.Parent = this.ButtonMerc;
            this.ButtonMerc.Location = new System.Drawing.Point(597, 84);
            this.ButtonMerc.Name = "ButtonMerc";
            this.ButtonMerc.ShadowDecoration.Parent = this.ButtonMerc;
            this.ButtonMerc.Size = new System.Drawing.Size(136, 30);
            this.ButtonMerc.TabIndex = 36;
            this.ButtonMerc.Text = "Mercredi";
            // 
            // ButtonCalandrer
            // 
            this.ButtonCalandrer.CheckedState.Parent = this.ButtonCalandrer;
            this.ButtonCalandrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCalandrer.HoverState.ImageSize = new System.Drawing.Size(65, 65);
            this.ButtonCalandrer.HoverState.Parent = this.ButtonCalandrer;
            this.ButtonCalandrer.Image = global::ProjetCabinetDentaire.Properties.Resources.CalendarIcon;
            this.ButtonCalandrer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonCalandrer.ImageSize = new System.Drawing.Size(60, 60);
            this.ButtonCalandrer.Location = new System.Drawing.Point(69, 16);
            this.ButtonCalandrer.Name = "ButtonCalandrer";
            this.ButtonCalandrer.PressedState.Parent = this.ButtonCalandrer;
            this.ButtonCalandrer.Size = new System.Drawing.Size(52, 45);
            this.ButtonCalandrer.TabIndex = 31;
            // 
            // flDays
            // 
            this.flDays.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flDays.AutoScroll = true;
            this.flDays.BackColor = System.Drawing.Color.White;
            this.flDays.Location = new System.Drawing.Point(4, 174);
            this.flDays.Name = "flDays";
            this.flDays.Size = new System.Drawing.Size(1071, 406);
            this.flDays.TabIndex = 22;
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
            this.ButtonClose.Location = new System.Drawing.Point(1022, 3);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.PressedState.Parent = this.ButtonClose;
            this.ButtonClose.Size = new System.Drawing.Size(50, 42);
            this.ButtonClose.TabIndex = 32;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1076, 611);
            this.panelPrincipal.TabIndex = 23;
            // 
            // RDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1076, 611);
            this.Controls.Add(this.PanelDate);
            this.Controls.Add(this.panelCopyright);
            this.Controls.Add(this.PanelHeaderRDV);
            this.Controls.Add(this.flDays);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "RDV";
            this.Text = "RDV";
            this.Load += new System.EventHandler(this.RDV_Load);
            this.PanelHeaderRDV.ResumeLayout(false);
            this.PanelPagination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BoxReturn)).EndInit();
            this.panelCopyright.ResumeLayout(false);
            this.panelCopyright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxDroitsLogo)).EndInit();
            this.PanelDate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox BoxDroitsLogo;
        private System.Windows.Forms.Label labelVersoin;
        private System.Windows.Forms.Label labelDroitsReserves;
        private System.Windows.Forms.Label labelCopyright;
        internal System.Windows.Forms.Panel PanelDate;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonCalandrer;
        internal System.Windows.Forms.FlowLayoutPanel flDays;
        internal System.Windows.Forms.Panel PanelPagination;
        private Guna.UI2.WinForms.Guna2Button ButtonToday;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonPreveuis;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonNext;
        internal System.Windows.Forms.PictureBox BoxReturn;
        internal System.Windows.Forms.Panel panelCopyright;
        internal Guna.UI2.WinForms.Guna2Panel PanelHeaderRDV;
        private Guna.UI2.WinForms.Guna2Button ButtonDim;
        private Guna.UI2.WinForms.Guna2Button ButtonLan;
        private Guna.UI2.WinForms.Guna2Button ButtonSam;
        private Guna.UI2.WinForms.Guna2Button ButtonMardi;
        private Guna.UI2.WinForms.Guna2Button ButtonVend;
        private Guna.UI2.WinForms.Guna2Button ButtonJeudi;
        private Guna.UI2.WinForms.Guna2Button ButtonMerc;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxYear;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxMonth;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonSearchDate;
        internal Guna.UI2.WinForms.Guna2ImageButton ButtonClose;
        private System.Windows.Forms.Panel panelPrincipal;
    }
}