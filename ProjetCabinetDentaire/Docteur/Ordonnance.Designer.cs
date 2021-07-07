
namespace ProjetCabinetDentaire.Docteur
{
    partial class Ordonnance
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ButtonMod = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSupp = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.panelOrd = new System.Windows.Forms.Panel();
            this.dataGridViewListeOrd = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID_Med = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ButtonTitle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBoxAcc = new System.Windows.Forms.PictureBox();
            this.ButtonRech = new Guna.UI2.WinForms.Guna2Button();
            this.TextBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelMenu.SuspendLayout();
            this.panelOrd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeOrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.ButtonRech);
            this.panelMenu.Controls.Add(this.TextBoxSearch);
            this.panelMenu.Controls.Add(this.ButtonClose);
            this.panelMenu.Controls.Add(this.ButtonTitle);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(888, 50);
            this.panelMenu.TabIndex = 19;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
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
            this.ButtonMod.Location = new System.Drawing.Point(656, 477);
            this.ButtonMod.Name = "ButtonMod";
            this.ButtonMod.ShadowDecoration.Parent = this.ButtonMod;
            this.ButtonMod.Size = new System.Drawing.Size(107, 35);
            this.ButtonMod.TabIndex = 24;
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
            this.ButtonSupp.Location = new System.Drawing.Point(769, 477);
            this.ButtonSupp.Name = "ButtonSupp";
            this.ButtonSupp.ShadowDecoration.Parent = this.ButtonSupp;
            this.ButtonSupp.Size = new System.Drawing.Size(107, 35);
            this.ButtonSupp.TabIndex = 21;
            this.ButtonSupp.Text = "Supprimer";
            this.ButtonSupp.Click += new System.EventHandler(this.ButtonSupp_Click);
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
            this.ButtonAjouter.Location = new System.Drawing.Point(543, 477);
            this.ButtonAjouter.Name = "ButtonAjouter";
            this.ButtonAjouter.ShadowDecoration.Parent = this.ButtonAjouter;
            this.ButtonAjouter.Size = new System.Drawing.Size(107, 35);
            this.ButtonAjouter.TabIndex = 20;
            this.ButtonAjouter.Text = "Ajouter";
            this.ButtonAjouter.Click += new System.EventHandler(this.ButtonAjouter_Click);
            // 
            // panelOrd
            // 
            this.panelOrd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelOrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrd.Controls.Add(this.dataGridViewListeOrd);
            this.panelOrd.Controls.Add(this.ButtonSupp);
            this.panelOrd.Controls.Add(this.ButtonMod);
            this.panelOrd.Controls.Add(this.ButtonAjouter);
            this.panelOrd.Controls.Add(this.pictureBoxAcc);
            this.panelOrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrd.Location = new System.Drawing.Point(0, 0);
            this.panelOrd.Name = "panelOrd";
            this.panelOrd.Size = new System.Drawing.Size(888, 527);
            this.panelOrd.TabIndex = 25;
            // 
            // dataGridViewListeOrd
            // 
            this.dataGridViewListeOrd.AllowUserToAddRows = false;
            this.dataGridViewListeOrd.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dataGridViewListeOrd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewListeOrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListeOrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListeOrd.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListeOrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListeOrd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewListeOrd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListeOrd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewListeOrd.ColumnHeadersHeight = 40;
            this.dataGridViewListeOrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Med,
            this.Nom,
            this.Quantite});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListeOrd.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewListeOrd.EnableHeadersVisualStyles = false;
            this.dataGridViewListeOrd.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListeOrd.Location = new System.Drawing.Point(11, 55);
            this.dataGridViewListeOrd.Name = "dataGridViewListeOrd";
            this.dataGridViewListeOrd.ReadOnly = true;
            this.dataGridViewListeOrd.RowHeadersVisible = false;
            this.dataGridViewListeOrd.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10);
            this.dataGridViewListeOrd.RowTemplate.Height = 55;
            this.dataGridViewListeOrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListeOrd.Size = new System.Drawing.Size(864, 415);
            this.dataGridViewListeOrd.TabIndex = 25;
            this.dataGridViewListeOrd.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridViewListeOrd.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewListeOrd.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewListeOrd.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewListeOrd.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewListeOrd.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewListeOrd.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListeOrd.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListeOrd.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListeOrd.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewListeOrd.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewListeOrd.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewListeOrd.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewListeOrd.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridViewListeOrd.ThemeStyle.ReadOnly = true;
            this.dataGridViewListeOrd.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewListeOrd.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewListeOrd.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewListeOrd.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewListeOrd.ThemeStyle.RowsStyle.Height = 55;
            this.dataGridViewListeOrd.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.dataGridViewListeOrd.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewListeOrd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListeOrd_CellDoubleClick);
            // 
            // ID_Med
            // 
            this.ID_Med.HeaderText = "Numéro Médicament";
            this.ID_Med.Name = "ID_Med";
            this.ID_Med.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Quantite
            // 
            this.Quantite.HeaderText = "Quantité";
            this.Quantite.Name = "Quantite";
            this.Quantite.ReadOnly = true;
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
            this.ButtonClose.Location = new System.Drawing.Point(833, 3);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.PressedState.Parent = this.ButtonClose;
            this.ButtonClose.Size = new System.Drawing.Size(50, 42);
            this.ButtonClose.TabIndex = 34;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonTitle
            // 
            this.ButtonTitle.Active = false;
            this.ButtonTitle.Activecolor = System.Drawing.Color.Transparent;
            this.ButtonTitle.BackColor = System.Drawing.Color.Transparent;
            this.ButtonTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonTitle.BorderRadius = 0;
            this.ButtonTitle.ButtonText = "Médicament";
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
            this.ButtonTitle.TabIndex = 33;
            this.ButtonTitle.Text = "Médicament";
            this.ButtonTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonTitle.Textcolor = System.Drawing.Color.Black;
            this.ButtonTitle.TextFont = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            // 
            // pictureBoxAcc
            // 
            this.pictureBoxAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxAcc.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAcc.Image = global::ProjetCabinetDentaire.Properties.Resources.sync;
            this.pictureBoxAcc.Location = new System.Drawing.Point(10, 476);
            this.pictureBoxAcc.Name = "pictureBoxAcc";
            this.pictureBoxAcc.Size = new System.Drawing.Size(45, 36);
            this.pictureBoxAcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAcc.TabIndex = 22;
            this.pictureBoxAcc.TabStop = false;
            this.pictureBoxAcc.Click += new System.EventHandler(this.pictureBoxAcc_Click);
            // 
            // ButtonRech
            // 
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
            this.ButtonRech.Location = new System.Drawing.Point(599, 6);
            this.ButtonRech.Name = "ButtonRech";
            this.ButtonRech.ShadowDecoration.Parent = this.ButtonRech;
            this.ButtonRech.Size = new System.Drawing.Size(107, 35);
            this.ButtonRech.TabIndex = 36;
            this.ButtonRech.Text = "Rechercher";
            this.ButtonRech.Click += new System.EventHandler(this.ButtonRech_Click);
            // 
            // TextBoxSearch
            // 
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
            this.TextBoxSearch.Location = new System.Drawing.Point(350, 5);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.PasswordChar = '\0';
            this.TextBoxSearch.PlaceholderText = "Rechercher";
            this.TextBoxSearch.SelectedText = "";
            this.TextBoxSearch.ShadowDecoration.Parent = this.TextBoxSearch;
            this.TextBoxSearch.Size = new System.Drawing.Size(243, 36);
            this.TextBoxSearch.TabIndex = 35;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // Ordonnance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 527);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelOrd);
            this.Name = "Ordonnance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordonnance";
            this.Load += new System.EventHandler(this.Ordonnance_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelOrd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeOrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private Guna.UI2.WinForms.Guna2Button ButtonMod;
        private System.Windows.Forms.PictureBox pictureBoxAcc;
        private Guna.UI2.WinForms.Guna2Button ButtonSupp;
        private Guna.UI2.WinForms.Guna2Button ButtonAjouter;
        private System.Windows.Forms.Panel panelOrd;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewListeOrd;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonTitle;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Med;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private Guna.UI2.WinForms.Guna2Button ButtonRech;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxSearch;
    }
}