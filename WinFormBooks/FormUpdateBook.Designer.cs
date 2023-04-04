namespace WinFormBooks
{
    partial class FormUpdateBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateBook));
            this.panelUpdateBook = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbTypeUp = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbFinishedUp = new System.Windows.Forms.ComboBox();
            this.lblFinished = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.tbAuthorUp = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.tbTitleUp = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelUpdateBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUpdateBook
            // 
            this.panelUpdateBook.Controls.Add(this.btnCancel);
            this.panelUpdateBook.Controls.Add(this.cmbTypeUp);
            this.panelUpdateBook.Controls.Add(this.btnUpdate);
            this.panelUpdateBook.Controls.Add(this.cmbFinishedUp);
            this.panelUpdateBook.Controls.Add(this.lblFinished);
            this.panelUpdateBook.Controls.Add(this.lblType);
            this.panelUpdateBook.Controls.Add(this.tbAuthorUp);
            this.panelUpdateBook.Controls.Add(this.lblAuthor);
            this.panelUpdateBook.Controls.Add(this.tbTitleUp);
            this.panelUpdateBook.Controls.Add(this.lblTitle);
            this.panelUpdateBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUpdateBook.Location = new System.Drawing.Point(0, 0);
            this.panelUpdateBook.Name = "panelUpdateBook";
            this.panelUpdateBook.Padding = new System.Windows.Forms.Padding(30);
            this.panelUpdateBook.Size = new System.Drawing.Size(444, 541);
            this.panelUpdateBook.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(316, 448);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 60);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Mégse";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbTypeUp
            // 
            this.cmbTypeUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTypeUp.BackColor = System.Drawing.Color.White;
            this.cmbTypeUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTypeUp.FormattingEnabled = true;
            this.cmbTypeUp.Location = new System.Drawing.Point(33, 238);
            this.cmbTypeUp.Name = "cmbTypeUp";
            this.cmbTypeUp.Size = new System.Drawing.Size(378, 28);
            this.cmbTypeUp.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(33, 448);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(277, 60);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Módosítás";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbFinishedUp
            // 
            this.cmbFinishedUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFinishedUp.BackColor = System.Drawing.Color.White;
            this.cmbFinishedUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinishedUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFinishedUp.FormattingEnabled = true;
            this.cmbFinishedUp.Location = new System.Drawing.Point(33, 326);
            this.cmbFinishedUp.Name = "cmbFinishedUp";
            this.cmbFinishedUp.Size = new System.Drawing.Size(378, 28);
            this.cmbFinishedUp.TabIndex = 7;
            // 
            // lblFinished
            // 
            this.lblFinished.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinished.AutoSize = true;
            this.lblFinished.Location = new System.Drawing.Point(33, 297);
            this.lblFinished.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblFinished.Name = "lblFinished";
            this.lblFinished.Size = new System.Drawing.Size(82, 20);
            this.lblFinished.TabIndex = 6;
            this.lblFinished.Text = "Befejezett";
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(33, 209);
            this.lblType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(47, 20);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Típus";
            // 
            // tbAuthorUp
            // 
            this.tbAuthorUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAuthorUp.BackColor = System.Drawing.Color.White;
            this.tbAuthorUp.Location = new System.Drawing.Point(33, 150);
            this.tbAuthorUp.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.tbAuthorUp.Name = "tbAuthorUp";
            this.tbAuthorUp.Size = new System.Drawing.Size(378, 26);
            this.tbAuthorUp.TabIndex = 3;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(33, 121);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(59, 20);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Szerző";
            // 
            // tbTitleUp
            // 
            this.tbTitleUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitleUp.BackColor = System.Drawing.Color.White;
            this.tbTitleUp.Location = new System.Drawing.Point(33, 62);
            this.tbTitleUp.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.tbTitleUp.Name = "tbTitleUp";
            this.tbTitleUp.Size = new System.Drawing.Size(378, 26);
            this.tbTitleUp.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(33, 33);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cím";
            // 
            // FormUpdateBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(444, 541);
            this.Controls.Add(this.panelUpdateBook);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(330, 580);
            this.Name = "FormUpdateBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Könyv adatainak módosítása";
            this.Load += new System.EventHandler(this.FormUpdateBook_Load);
            this.panelUpdateBook.ResumeLayout(false);
            this.panelUpdateBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUpdateBook;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbFinishedUp;
        private System.Windows.Forms.Label lblFinished;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox tbAuthorUp;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox tbTitleUp;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbTypeUp;
        private System.Windows.Forms.Button btnCancel;
    }
}