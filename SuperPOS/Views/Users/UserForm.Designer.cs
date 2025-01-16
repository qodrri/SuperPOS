namespace SuperPOS.Views.Users
{
    partial class UserForm
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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iconButtonPrint = new FontAwesome.Sharp.IconButton();
            this.iconButtonDownload = new FontAwesome.Sharp.IconButton();
            this.iconButtonSearch = new FontAwesome.Sharp.IconButton();
            this.iconButtonNew = new FontAwesome.Sharp.IconButton();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Controls.Add(this.iconButtonSearch);
            this.panelSearch.Location = new System.Drawing.Point(717, 14);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(333, 48);
            this.panelSearch.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(14, 10);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(258, 27);
            this.textBoxSearch.TabIndex = 3;
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Username,
            this.FirstName,
            this.LastName,
            this.Email,
            this.Phone,
            this.IsAdmin});
            this.dataGridViewMain.Location = new System.Drawing.Point(16, 82);
            this.dataGridViewMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersWidth = 62;
            this.dataGridViewMain.Size = new System.Drawing.Size(1035, 458);
            this.dataGridViewMain.TabIndex = 6;
            this.dataGridViewMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellClick);
            this.dataGridViewMain.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewMain_CellPainting);
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 8;
            this.No.Name = "No";
            this.No.Width = 50;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 8;
            this.Username.Name = "Username";
            this.Username.Width = 150;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 8;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 8;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 8;
            this.Phone.Name = "Phone";
            this.Phone.Width = 150;
            // 
            // IsAdmin
            // 
            this.IsAdmin.HeaderText = "Is Admin?";
            this.IsAdmin.MinimumWidth = 8;
            this.IsAdmin.Name = "IsAdmin";
            this.IsAdmin.Width = 75;
            // 
            // iconButtonPrint
            // 
            this.iconButtonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonPrint.BackColor = System.Drawing.SystemColors.Control;
            this.iconButtonPrint.FlatAppearance.BorderSize = 0;
            this.iconButtonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPrint.ForeColor = System.Drawing.Color.DarkViolet;
            this.iconButtonPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButtonPrint.IconColor = System.Drawing.Color.DarkViolet;
            this.iconButtonPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPrint.IconSize = 32;
            this.iconButtonPrint.Location = new System.Drawing.Point(595, 14);
            this.iconButtonPrint.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonPrint.Name = "iconButtonPrint";
            this.iconButtonPrint.Size = new System.Drawing.Size(53, 50);
            this.iconButtonPrint.TabIndex = 5;
            this.iconButtonPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonPrint.UseVisualStyleBackColor = false;
            this.iconButtonPrint.Click += new System.EventHandler(this.iconButtonPrint_Click);
            // 
            // iconButtonDownload
            // 
            this.iconButtonDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonDownload.BackColor = System.Drawing.SystemColors.Control;
            this.iconButtonDownload.FlatAppearance.BorderSize = 0;
            this.iconButtonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDownload.ForeColor = System.Drawing.Color.DarkViolet;
            this.iconButtonDownload.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.iconButtonDownload.IconColor = System.Drawing.Color.DarkViolet;
            this.iconButtonDownload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDownload.IconSize = 32;
            this.iconButtonDownload.Location = new System.Drawing.Point(656, 14);
            this.iconButtonDownload.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonDownload.Name = "iconButtonDownload";
            this.iconButtonDownload.Size = new System.Drawing.Size(53, 50);
            this.iconButtonDownload.TabIndex = 4;
            this.iconButtonDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDownload.UseVisualStyleBackColor = false;
            this.iconButtonDownload.Click += new System.EventHandler(this.iconButtonDownload_Click);
            // 
            // iconButtonSearch
            // 
            this.iconButtonSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButtonSearch.FlatAppearance.BorderSize = 0;
            this.iconButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSearch.ForeColor = System.Drawing.Color.DarkViolet;
            this.iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButtonSearch.IconColor = System.Drawing.Color.DarkViolet;
            this.iconButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearch.IconSize = 32;
            this.iconButtonSearch.Location = new System.Drawing.Point(280, -2);
            this.iconButtonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Size = new System.Drawing.Size(53, 50);
            this.iconButtonSearch.TabIndex = 2;
            this.iconButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSearch.UseVisualStyleBackColor = false;
            this.iconButtonSearch.Click += new System.EventHandler(this.iconButtonSearch_Click);
            // 
            // iconButtonNew
            // 
            this.iconButtonNew.BackColor = System.Drawing.Color.DarkViolet;
            this.iconButtonNew.FlatAppearance.BorderSize = 0;
            this.iconButtonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonNew.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonNew.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonNew.IconColor = System.Drawing.SystemColors.Control;
            this.iconButtonNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonNew.IconSize = 32;
            this.iconButtonNew.Location = new System.Drawing.Point(16, 14);
            this.iconButtonNew.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonNew.Name = "iconButtonNew";
            this.iconButtonNew.Size = new System.Drawing.Size(133, 50);
            this.iconButtonNew.TabIndex = 0;
            this.iconButtonNew.Text = "NEW";
            this.iconButtonNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonNew.UseVisualStyleBackColor = false;
            this.iconButtonNew.Click += new System.EventHandler(this.iconButtonNew_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.iconButtonPrint);
            this.Controls.Add(this.iconButtonDownload);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.iconButtonNew);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonNew;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private FontAwesome.Sharp.IconButton iconButtonSearch;
        private FontAwesome.Sharp.IconButton iconButtonDownload;
        private FontAwesome.Sharp.IconButton iconButtonPrint;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAdmin;
    }
}