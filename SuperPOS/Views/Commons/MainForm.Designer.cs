namespace SuperPOS.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.iconButtonSettings = new FontAwesome.Sharp.IconButton();
            this.panelMasterData = new System.Windows.Forms.Panel();
            this.iconButtonUsers = new FontAwesome.Sharp.IconButton();
            this.iconButtonMembers = new FontAwesome.Sharp.IconButton();
            this.iconButtonProductCategories = new FontAwesome.Sharp.IconButton();
            this.iconButtonProducts = new FontAwesome.Sharp.IconButton();
            this.iconButtonMasterData = new FontAwesome.Sharp.IconButton();
            this.panelTransaction = new System.Windows.Forms.Panel();
            this.iconButtonReceivings = new FontAwesome.Sharp.IconButton();
            this.iconButtonSales = new FontAwesome.Sharp.IconButton();
            this.iconButtonTransaction = new FontAwesome.Sharp.IconButton();
            this.iconButtonHome = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.iconButtonLogout = new FontAwesome.Sharp.IconButton();
            this.iconButtonTitle = new FontAwesome.Sharp.IconButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelMasterData.SuspendLayout();
            this.panelTransaction.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Indigo;
            this.panelLeft.Controls.Add(this.iconButtonSettings);
            this.panelLeft.Controls.Add(this.panelMasterData);
            this.panelLeft.Controls.Add(this.iconButtonMasterData);
            this.panelLeft.Controls.Add(this.panelTransaction);
            this.panelLeft.Controls.Add(this.iconButtonTransaction);
            this.panelLeft.Controls.Add(this.iconButtonHome);
            this.panelLeft.Controls.Add(this.panelLogo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.ForeColor = System.Drawing.SystemColors.Control;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(267, 690);
            this.panelLeft.TabIndex = 0;
            // 
            // iconButtonSettings
            // 
            this.iconButtonSettings.BackColor = System.Drawing.Color.Indigo;
            this.iconButtonSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonSettings.FlatAppearance.BorderSize = 0;
            this.iconButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSettings.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            this.iconButtonSettings.IconColor = System.Drawing.SystemColors.Control;
            this.iconButtonSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSettings.IconSize = 40;
            this.iconButtonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSettings.Location = new System.Drawing.Point(0, 636);
            this.iconButtonSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonSettings.Name = "iconButtonSettings";
            this.iconButtonSettings.Size = new System.Drawing.Size(267, 54);
            this.iconButtonSettings.TabIndex = 6;
            this.iconButtonSettings.Text = "Settings";
            this.iconButtonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSettings.UseVisualStyleBackColor = false;
            this.iconButtonSettings.Click += new System.EventHandler(this.iconButtonSettings_Click);
            // 
            // panelMasterData
            // 
            this.panelMasterData.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelMasterData.Controls.Add(this.iconButtonUsers);
            this.panelMasterData.Controls.Add(this.iconButtonMembers);
            this.panelMasterData.Controls.Add(this.iconButtonProductCategories);
            this.panelMasterData.Controls.Add(this.iconButtonProducts);
            this.panelMasterData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMasterData.Location = new System.Drawing.Point(0, 351);
            this.panelMasterData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMasterData.Name = "panelMasterData";
            this.panelMasterData.Size = new System.Drawing.Size(267, 210);
            this.panelMasterData.TabIndex = 5;
            this.panelMasterData.Visible = false;
            // 
            // iconButtonUsers
            // 
            this.iconButtonUsers.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonUsers.FlatAppearance.BorderSize = 0;
            this.iconButtonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonUsers.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.iconButtonUsers.IconColor = System.Drawing.SystemColors.Control;
            this.iconButtonUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUsers.IconSize = 36;
            this.iconButtonUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonUsers.Location = new System.Drawing.Point(0, 150);
            this.iconButtonUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonUsers.Name = "iconButtonUsers";
            this.iconButtonUsers.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.iconButtonUsers.Size = new System.Drawing.Size(267, 50);
            this.iconButtonUsers.TabIndex = 6;
            this.iconButtonUsers.Text = "Users";
            this.iconButtonUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUsers.UseVisualStyleBackColor = false;
            this.iconButtonUsers.Click += new System.EventHandler(this.iconButtonUsers_Click);
            // 
            // iconButtonMembers
            // 
            this.iconButtonMembers.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMembers.FlatAppearance.BorderSize = 0;
            this.iconButtonMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonMembers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButtonMembers.IconColor = System.Drawing.SystemColors.Control;
            this.iconButtonMembers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMembers.IconSize = 36;
            this.iconButtonMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMembers.Location = new System.Drawing.Point(0, 100);
            this.iconButtonMembers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonMembers.Name = "iconButtonMembers";
            this.iconButtonMembers.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.iconButtonMembers.Size = new System.Drawing.Size(267, 50);
            this.iconButtonMembers.TabIndex = 5;
            this.iconButtonMembers.Text = "Members";
            this.iconButtonMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMembers.UseVisualStyleBackColor = false;
            // 
            // iconButtonProductCategories
            // 
            this.iconButtonProductCategories.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonProductCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonProductCategories.FlatAppearance.BorderSize = 0;
            this.iconButtonProductCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonProductCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonProductCategories.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            this.iconButtonProductCategories.IconColor = System.Drawing.SystemColors.Control;
            this.iconButtonProductCategories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonProductCategories.IconSize = 36;
            this.iconButtonProductCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonProductCategories.Location = new System.Drawing.Point(0, 50);
            this.iconButtonProductCategories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonProductCategories.Name = "iconButtonProductCategories";
            this.iconButtonProductCategories.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.iconButtonProductCategories.Size = new System.Drawing.Size(267, 50);
            this.iconButtonProductCategories.TabIndex = 4;
            this.iconButtonProductCategories.Text = "Product Categories";
            this.iconButtonProductCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonProductCategories.UseVisualStyleBackColor = false;
            // 
            // iconButtonProducts
            // 
            this.iconButtonProducts.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonProducts.FlatAppearance.BorderSize = 0;
            this.iconButtonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonProducts.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.iconButtonProducts.IconColor = System.Drawing.SystemColors.Control;
            this.iconButtonProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonProducts.IconSize = 36;
            this.iconButtonProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonProducts.Location = new System.Drawing.Point(0, 0);
            this.iconButtonProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonProducts.Name = "iconButtonProducts";
            this.iconButtonProducts.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.iconButtonProducts.Size = new System.Drawing.Size(267, 50);
            this.iconButtonProducts.TabIndex = 3;
            this.iconButtonProducts.Text = "Products";
            this.iconButtonProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonProducts.UseVisualStyleBackColor = false;
            // 
            // iconButtonMasterData
            // 
            this.iconButtonMasterData.BackColor = System.Drawing.Color.Indigo;
            this.iconButtonMasterData.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMasterData.FlatAppearance.BorderSize = 0;
            this.iconButtonMasterData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMasterData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonMasterData.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.iconButtonMasterData.IconColor = System.Drawing.SystemColors.Control;
            this.iconButtonMasterData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMasterData.IconSize = 40;
            this.iconButtonMasterData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMasterData.Location = new System.Drawing.Point(0, 297);
            this.iconButtonMasterData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonMasterData.Name = "iconButtonMasterData";
            this.iconButtonMasterData.Size = new System.Drawing.Size(267, 54);
            this.iconButtonMasterData.TabIndex = 4;
            this.iconButtonMasterData.Text = "Master Data";
            this.iconButtonMasterData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMasterData.UseVisualStyleBackColor = false;
            this.iconButtonMasterData.Click += new System.EventHandler(this.iconButtonMasterData_Click);
            // 
            // panelTransaction
            // 
            this.panelTransaction.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelTransaction.Controls.Add(this.iconButtonReceivings);
            this.panelTransaction.Controls.Add(this.iconButtonSales);
            this.panelTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTransaction.Location = new System.Drawing.Point(0, 194);
            this.panelTransaction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTransaction.Name = "panelTransaction";
            this.panelTransaction.Size = new System.Drawing.Size(267, 103);
            this.panelTransaction.TabIndex = 3;
            this.panelTransaction.Visible = false;
            // 
            // iconButtonReceivings
            // 
            this.iconButtonReceivings.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonReceivings.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonReceivings.FlatAppearance.BorderSize = 0;
            this.iconButtonReceivings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonReceivings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonReceivings.IconChar = FontAwesome.Sharp.IconChar.TruckRampBox;
            this.iconButtonReceivings.IconColor = System.Drawing.SystemColors.Control;
            this.iconButtonReceivings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonReceivings.IconSize = 36;
            this.iconButtonReceivings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonReceivings.Location = new System.Drawing.Point(0, 50);
            this.iconButtonReceivings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonReceivings.Name = "iconButtonReceivings";
            this.iconButtonReceivings.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.iconButtonReceivings.Size = new System.Drawing.Size(267, 50);
            this.iconButtonReceivings.TabIndex = 4;
            this.iconButtonReceivings.Text = "Reveivings";
            this.iconButtonReceivings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonReceivings.UseVisualStyleBackColor = false;
            // 
            // iconButtonSales
            // 
            this.iconButtonSales.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSales.FlatAppearance.BorderSize = 0;
            this.iconButtonSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSales.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.iconButtonSales.IconColor = System.Drawing.SystemColors.Control;
            this.iconButtonSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSales.IconSize = 36;
            this.iconButtonSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSales.Location = new System.Drawing.Point(0, 0);
            this.iconButtonSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonSales.Name = "iconButtonSales";
            this.iconButtonSales.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.iconButtonSales.Size = new System.Drawing.Size(267, 50);
            this.iconButtonSales.TabIndex = 3;
            this.iconButtonSales.Text = "Sales";
            this.iconButtonSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSales.UseVisualStyleBackColor = false;
            // 
            // iconButtonTransaction
            // 
            this.iconButtonTransaction.BackColor = System.Drawing.Color.Indigo;
            this.iconButtonTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonTransaction.FlatAppearance.BorderSize = 0;
            this.iconButtonTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonTransaction.IconChar = FontAwesome.Sharp.IconChar.ScaleBalanced;
            this.iconButtonTransaction.IconColor = System.Drawing.SystemColors.Control;
            this.iconButtonTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTransaction.IconSize = 40;
            this.iconButtonTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTransaction.Location = new System.Drawing.Point(0, 140);
            this.iconButtonTransaction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonTransaction.Name = "iconButtonTransaction";
            this.iconButtonTransaction.Size = new System.Drawing.Size(267, 54);
            this.iconButtonTransaction.TabIndex = 2;
            this.iconButtonTransaction.Text = "Transaction";
            this.iconButtonTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonTransaction.UseVisualStyleBackColor = false;
            this.iconButtonTransaction.Click += new System.EventHandler(this.iconButtonTransaction_Click);
            // 
            // iconButtonHome
            // 
            this.iconButtonHome.BackColor = System.Drawing.Color.Indigo;
            this.iconButtonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonHome.FlatAppearance.BorderSize = 0;
            this.iconButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconButtonHome.IconColor = System.Drawing.SystemColors.Control;
            this.iconButtonHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHome.IconSize = 40;
            this.iconButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHome.Location = new System.Drawing.Point(0, 86);
            this.iconButtonHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonHome.Name = "iconButtonHome";
            this.iconButtonHome.Size = new System.Drawing.Size(267, 54);
            this.iconButtonHome.TabIndex = 1;
            this.iconButtonHome.Text = "Home";
            this.iconButtonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonHome.UseVisualStyleBackColor = false;
            this.iconButtonHome.Click += new System.EventHandler(this.iconButtonHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.labelTitle);
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(267, 86);
            this.panelLogo.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(84, 23);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(165, 36);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "SuperPOS";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::SuperPOS.Properties.Resources.shopping_bag;
            this.pictureBoxLogo.Location = new System.Drawing.Point(16, 12);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(67, 62);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Indigo;
            this.panelTop.Controls.Add(this.iconButtonLogout);
            this.panelTop.Controls.Add(this.iconButtonTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.SystemColors.Control;
            this.panelTop.Location = new System.Drawing.Point(267, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(912, 74);
            this.panelTop.TabIndex = 1;
            // 
            // iconButtonLogout
            // 
            this.iconButtonLogout.BackColor = System.Drawing.Color.Indigo;
            this.iconButtonLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButtonLogout.FlatAppearance.BorderSize = 0;
            this.iconButtonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonLogout.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.iconButtonLogout.IconColor = System.Drawing.SystemColors.Control;
            this.iconButtonLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLogout.IconSize = 40;
            this.iconButtonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLogout.Location = new System.Drawing.Point(845, 0);
            this.iconButtonLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonLogout.Name = "iconButtonLogout";
            this.iconButtonLogout.Size = new System.Drawing.Size(67, 74);
            this.iconButtonLogout.TabIndex = 3;
            this.iconButtonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonLogout.UseVisualStyleBackColor = false;
            this.iconButtonLogout.Click += new System.EventHandler(this.iconButtonLogout_Click);
            // 
            // iconButtonTitle
            // 
            this.iconButtonTitle.BackColor = System.Drawing.Color.Indigo;
            this.iconButtonTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonTitle.FlatAppearance.BorderSize = 0;
            this.iconButtonTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonTitle.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconButtonTitle.IconColor = System.Drawing.SystemColors.Control;
            this.iconButtonTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTitle.IconSize = 40;
            this.iconButtonTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTitle.Location = new System.Drawing.Point(0, 0);
            this.iconButtonTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonTitle.Name = "iconButtonTitle";
            this.iconButtonTitle.Size = new System.Drawing.Size(267, 74);
            this.iconButtonTitle.TabIndex = 2;
            this.iconButtonTitle.Text = "Home";
            this.iconButtonTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonTitle.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.MediumPurple;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(267, 74);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(912, 616);
            this.panelMain.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "SuperPOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelMasterData.ResumeLayout(false);
            this.panelTransaction.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconButton iconButtonTransaction;
        private FontAwesome.Sharp.IconButton iconButtonHome;
        private System.Windows.Forms.Panel panelTransaction;
        private FontAwesome.Sharp.IconButton iconButtonReceivings;
        private FontAwesome.Sharp.IconButton iconButtonSales;
        private System.Windows.Forms.Panel panelMasterData;
        private FontAwesome.Sharp.IconButton iconButtonProductCategories;
        private FontAwesome.Sharp.IconButton iconButtonProducts;
        private FontAwesome.Sharp.IconButton iconButtonMasterData;
        private FontAwesome.Sharp.IconButton iconButtonUsers;
        private FontAwesome.Sharp.IconButton iconButtonMembers;
        private FontAwesome.Sharp.IconButton iconButtonSettings;
        private FontAwesome.Sharp.IconButton iconButtonTitle;
        private FontAwesome.Sharp.IconButton iconButtonLogout;
    }
}