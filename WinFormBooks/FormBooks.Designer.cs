namespace WinFormBooks
{
    partial class FormBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBooks));
            this.tableLayoutPanelBooks = new System.Windows.Forms.TableLayoutPanel();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.cmbFilterFinished = new System.Windows.Forms.ComboBox();
            this.lblFinished = new System.Windows.Forms.Label();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.tbSearchAuthor = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearchTitle = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBooks
            // 
            this.tableLayoutPanelBooks.ColumnCount = 2;
            this.tableLayoutPanelBooks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelBooks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelBooks.Controls.Add(this.dgvBooks, 0, 0);
            this.tableLayoutPanelBooks.Controls.Add(this.panelButtons, 1, 0);
            this.tableLayoutPanelBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBooks.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBooks.Name = "tableLayoutPanelBooks";
            this.tableLayoutPanelBooks.Padding = new System.Windows.Forms.Padding(30);
            this.tableLayoutPanelBooks.RowCount = 1;
            this.tableLayoutPanelBooks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBooks.Size = new System.Drawing.Size(944, 761);
            this.tableLayoutPanelBooks.TabIndex = 1;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(33, 33);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.Size = new System.Drawing.Size(568, 695);
            this.dgvBooks.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnUsers);
            this.panelButtons.Controls.Add(this.btnClose);
            this.panelButtons.Controls.Add(this.btnDeleteBook);
            this.panelButtons.Controls.Add(this.btnUpdateBook);
            this.panelButtons.Controls.Add(this.groupBoxSearch);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(607, 33);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panelButtons.Size = new System.Drawing.Size(304, 695);
            this.panelButtons.TabIndex = 1;
            // 
            // btnUsers
            // 
            this.btnUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsers.BackColor = System.Drawing.Color.White;
            this.btnUsers.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Location = new System.Drawing.Point(33, 632);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(152, 60);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "Felhasználók";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(191, 632);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 60);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Bezárás";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteBook.BackColor = System.Drawing.Color.White;
            this.btnDeleteBook.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBook.Image = global::WinFormBooks.Properties.Resources.icon_delete;
            this.btnDeleteBook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteBook.Location = new System.Drawing.Point(33, 511);
            this.btnDeleteBook.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnDeleteBook.Size = new System.Drawing.Size(268, 60);
            this.btnDeleteBook.TabIndex = 2;
            this.btnDeleteBook.Text = "Könyv törlése";
            this.btnDeleteBook.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateBook.BackColor = System.Drawing.Color.White;
            this.btnUpdateBook.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBook.Image = global::WinFormBooks.Properties.Resources.icon_update;
            this.btnUpdateBook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateBook.Location = new System.Drawing.Point(33, 438);
            this.btnUpdateBook.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnUpdateBook.Size = new System.Drawing.Size(268, 60);
            this.btnUpdateBook.TabIndex = 1;
            this.btnUpdateBook.Text = "Adatok módosítása";
            this.btnUpdateBook.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdateBook.UseVisualStyleBackColor = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.cmbFilterFinished);
            this.groupBoxSearch.Controls.Add(this.lblFinished);
            this.groupBoxSearch.Controls.Add(this.cmbFilterType);
            this.groupBoxSearch.Controls.Add(this.lblType);
            this.groupBoxSearch.Controls.Add(this.lblAuthor);
            this.groupBoxSearch.Controls.Add(this.tbSearchAuthor);
            this.groupBoxSearch.Controls.Add(this.lblTitle);
            this.groupBoxSearch.Controls.Add(this.btnRefresh);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Controls.Add(this.tbSearchTitle);
            this.groupBoxSearch.Location = new System.Drawing.Point(33, 3);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(268, 382);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Könyv keresése";
            // 
            // cmbFilterFinished
            // 
            this.cmbFilterFinished.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilterFinished.BackColor = System.Drawing.Color.White;
            this.cmbFilterFinished.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterFinished.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFilterFinished.FormattingEnabled = true;
            this.cmbFilterFinished.Location = new System.Drawing.Point(5, 270);
            this.cmbFilterFinished.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.cmbFilterFinished.Name = "cmbFilterFinished";
            this.cmbFilterFinished.Size = new System.Drawing.Size(256, 28);
            this.cmbFilterFinished.TabIndex = 3;
            this.cmbFilterFinished.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFilterFinished_KeyDown);
            // 
            // lblFinished
            // 
            this.lblFinished.AutoSize = true;
            this.lblFinished.Location = new System.Drawing.Point(6, 241);
            this.lblFinished.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblFinished.Name = "lblFinished";
            this.lblFinished.Size = new System.Drawing.Size(82, 20);
            this.lblFinished.TabIndex = 9;
            this.lblFinished.Text = "Befejezett";
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilterType.BackColor = System.Drawing.Color.White;
            this.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Location = new System.Drawing.Point(6, 200);
            this.cmbFilterType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(256, 28);
            this.cmbFilterType.TabIndex = 2;
            this.cmbFilterType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFilterType_KeyDown);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 171);
            this.lblType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(47, 20);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Típus";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(6, 103);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(59, 20);
            this.lblAuthor.TabIndex = 7;
            this.lblAuthor.Text = "Szerző";
            // 
            // tbSearchAuthor
            // 
            this.tbSearchAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchAuthor.BackColor = System.Drawing.Color.White;
            this.tbSearchAuthor.Location = new System.Drawing.Point(6, 132);
            this.tbSearchAuthor.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.tbSearchAuthor.Name = "tbSearchAuthor";
            this.tbSearchAuthor.Size = new System.Drawing.Size(256, 26);
            this.tbSearchAuthor.TabIndex = 1;
            this.tbSearchAuthor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchAuthor_KeyDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 35);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 20);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Cím";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::WinFormBooks.Properties.Resources.LucaBurgio_refresh_double14;
            this.btnRefresh.Location = new System.Drawing.Point(232, 338);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(28, 28);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(5, 338);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(221, 28);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Keresés";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearchTitle
            // 
            this.tbSearchTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchTitle.BackColor = System.Drawing.Color.White;
            this.tbSearchTitle.Location = new System.Drawing.Point(6, 64);
            this.tbSearchTitle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.tbSearchTitle.Name = "tbSearchTitle";
            this.tbSearchTitle.Size = new System.Drawing.Size(256, 26);
            this.tbSearchTitle.TabIndex = 0;
            this.tbSearchTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchTitle_KeyDown);
            // 
            // FormBooks
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(193)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(944, 761);
            this.Controls.Add(this.tableLayoutPanelBooks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(900, 800);
            this.Name = "FormBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Könyvek";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBooks_FormClosing);
            this.Load += new System.EventHandler(this.FormBooks_Load);
            this.tableLayoutPanelBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBooks;
        public System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearchTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox tbSearchAuthor;
        private System.Windows.Forms.ComboBox cmbFilterFinished;
        private System.Windows.Forms.Label lblFinished;
        private System.Windows.Forms.ComboBox cmbFilterType;
    }
}