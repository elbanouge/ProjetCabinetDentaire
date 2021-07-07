
namespace ProjetCabinetDentaire.Docteur
{
    partial class ServicesEmp
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
            this.panelServices = new System.Windows.Forms.Panel();
            this.ButtonSupp = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewListeServices = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID_Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonMod = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBoxAcc = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ButtonClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ButtonTitle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcc)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelServices
            // 
            this.panelServices.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelServices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelServices.Controls.Add(this.ButtonSupp);
            this.panelServices.Controls.Add(this.dataGridViewListeServices);
            this.panelServices.Controls.Add(this.ButtonMod);
            this.panelServices.Controls.Add(this.ButtonAjouter);
            this.panelServices.Controls.Add(this.pictureBoxAcc);
            this.panelServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelServices.Location = new System.Drawing.Point(0, 0);
            this.panelServices.Name = "panelServices";
            this.panelServices.Size = new System.Drawing.Size(888, 527);
            this.panelServices.TabIndex = 27;
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
            // dataGridViewListeServices
            // 
            this.dataGridViewListeServices.AllowUserToAddRows = false;
            this.dataGridViewListeServices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewListeServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewListeServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListeServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListeServices.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListeServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListeServices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewListeServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListeServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewListeServices.ColumnHeadersHeight = 40;
            this.dataGridViewListeServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Service,
            this.Nature,
            this.Prix});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListeServices.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewListeServices.EnableHeadersVisualStyles = false;
            this.dataGridViewListeServices.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListeServices.Location = new System.Drawing.Point(11, 55);
            this.dataGridViewListeServices.Name = "dataGridViewListeServices";
            this.dataGridViewListeServices.ReadOnly = true;
            this.dataGridViewListeServices.RowHeadersVisible = false;
            this.dataGridViewListeServices.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10);
            this.dataGridViewListeServices.RowTemplate.Height = 55;
            this.dataGridViewListeServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListeServices.Size = new System.Drawing.Size(864, 415);
            this.dataGridViewListeServices.TabIndex = 23;
            this.dataGridViewListeServices.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridViewListeServices.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewListeServices.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewListeServices.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewListeServices.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewListeServices.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewListeServices.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListeServices.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListeServices.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListeServices.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewListeServices.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewListeServices.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewListeServices.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewListeServices.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridViewListeServices.ThemeStyle.ReadOnly = true;
            this.dataGridViewListeServices.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewListeServices.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewListeServices.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewListeServices.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewListeServices.ThemeStyle.RowsStyle.Height = 55;
            this.dataGridViewListeServices.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.dataGridViewListeServices.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewListeServices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListeServices_CellDoubleClick);
            // 
            // ID_Service
            // 
            this.ID_Service.HeaderText = "Numéro Service";
            this.ID_Service.Name = "ID_Service";
            this.ID_Service.ReadOnly = true;
            // 
            // Nature
            // 
            this.Nature.HeaderText = "Nature";
            this.Nature.Name = "Nature";
            this.Nature.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
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
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.ButtonTitle);
            this.panelMenu.Controls.Add(this.ButtonClose);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(888, 50);
            this.panelMenu.TabIndex = 26;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
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
            this.ButtonTitle.ButtonText = "Listes Services";
            this.ButtonTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonTitle.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonTitle.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonTitle.Iconimage = global::ProjetCabinetDentaire.Properties.Resources.customer;
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
            this.ButtonTitle.Location = new System.Drawing.Point(3, 3);
            this.ButtonTitle.Name = "ButtonTitle";
            this.ButtonTitle.Normalcolor = System.Drawing.Color.Transparent;
            this.ButtonTitle.OnHovercolor = System.Drawing.Color.Transparent;
            this.ButtonTitle.OnHoverTextColor = System.Drawing.Color.Black;
            this.ButtonTitle.selected = false;
            this.ButtonTitle.Size = new System.Drawing.Size(256, 42);
            this.ButtonTitle.TabIndex = 32;
            this.ButtonTitle.Text = "Listes Services";
            this.ButtonTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonTitle.Textcolor = System.Drawing.Color.Black;
            this.ButtonTitle.TextFont = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            // 
            // ServicesEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 527);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelServices);
            this.Name = "ServicesEmp";
            this.Text = "ServicesEmp";
            this.Load += new System.EventHandler(this.ServicesEmp_Load);
            this.panelServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcc)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelServices;
        private Guna.UI2.WinForms.Guna2Button ButtonSupp;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewListeServices;
        private Guna.UI2.WinForms.Guna2Button ButtonMod;
        private Guna.UI2.WinForms.Guna2Button ButtonAjouter;
        private System.Windows.Forms.PictureBox pictureBoxAcc;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonClose;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonTitle;
    }
}