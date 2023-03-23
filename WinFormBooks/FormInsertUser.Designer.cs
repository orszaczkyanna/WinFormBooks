namespace WinFormBooks
{
    partial class FormInsertUser
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
            this.panelInsertUser = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cmbRoleIn = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.tbPasswordIn2 = new System.Windows.Forms.TextBox();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.tbPasswordIn1 = new System.Windows.Forms.TextBox();
            this.lblPassword1 = new System.Windows.Forms.Label();
            this.tbUsernameIn = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panelInsertUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInsertUser
            // 
            this.panelInsertUser.Controls.Add(this.btnInsert);
            this.panelInsertUser.Controls.Add(this.cmbRoleIn);
            this.panelInsertUser.Controls.Add(this.lblRole);
            this.panelInsertUser.Controls.Add(this.tbPasswordIn2);
            this.panelInsertUser.Controls.Add(this.lblPassword2);
            this.panelInsertUser.Controls.Add(this.tbPasswordIn1);
            this.panelInsertUser.Controls.Add(this.lblPassword1);
            this.panelInsertUser.Controls.Add(this.tbUsernameIn);
            this.panelInsertUser.Controls.Add(this.lblUsername);
            this.panelInsertUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInsertUser.Location = new System.Drawing.Point(0, 0);
            this.panelInsertUser.Name = "panelInsertUser";
            this.panelInsertUser.Padding = new System.Windows.Forms.Padding(30);
            this.panelInsertUser.Size = new System.Drawing.Size(314, 541);
            this.panelInsertUser.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.Location = new System.Drawing.Point(33, 448);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(248, 60);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Hozzáadás";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cmbRoleIn
            // 
            this.cmbRoleIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRoleIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoleIn.FormattingEnabled = true;
            this.cmbRoleIn.Location = new System.Drawing.Point(33, 326);
            this.cmbRoleIn.Name = "cmbRoleIn";
            this.cmbRoleIn.Size = new System.Drawing.Size(248, 28);
            this.cmbRoleIn.TabIndex = 7;
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(33, 297);
            this.lblRole.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(95, 20);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "Jogosultság";
            // 
            // tbPasswordIn2
            // 
            this.tbPasswordIn2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPasswordIn2.Location = new System.Drawing.Point(33, 238);
            this.tbPasswordIn2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.tbPasswordIn2.Name = "tbPasswordIn2";
            this.tbPasswordIn2.Size = new System.Drawing.Size(248, 26);
            this.tbPasswordIn2.TabIndex = 5;
            this.tbPasswordIn2.UseSystemPasswordChar = true;
            // 
            // lblPassword2
            // 
            this.lblPassword2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Location = new System.Drawing.Point(33, 209);
            this.lblPassword2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(96, 20);
            this.lblPassword2.TabIndex = 4;
            this.lblPassword2.Text = "Jelszó ismét";
            // 
            // tbPasswordIn1
            // 
            this.tbPasswordIn1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPasswordIn1.Location = new System.Drawing.Point(33, 150);
            this.tbPasswordIn1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.tbPasswordIn1.Name = "tbPasswordIn1";
            this.tbPasswordIn1.Size = new System.Drawing.Size(248, 26);
            this.tbPasswordIn1.TabIndex = 3;
            this.tbPasswordIn1.UseSystemPasswordChar = true;
            // 
            // lblPassword1
            // 
            this.lblPassword1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword1.AutoSize = true;
            this.lblPassword1.Location = new System.Drawing.Point(33, 121);
            this.lblPassword1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblPassword1.Name = "lblPassword1";
            this.lblPassword1.Size = new System.Drawing.Size(54, 20);
            this.lblPassword1.TabIndex = 2;
            this.lblPassword1.Text = "Jelszó";
            // 
            // tbUsernameIn
            // 
            this.tbUsernameIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsernameIn.Location = new System.Drawing.Point(33, 62);
            this.tbUsernameIn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.tbUsernameIn.Name = "tbUsernameIn";
            this.tbUsernameIn.Size = new System.Drawing.Size(248, 26);
            this.tbUsernameIn.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(33, 33);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(120, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Felhasználónév";
            // 
            // FormInsertUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(314, 541);
            this.Controls.Add(this.panelInsertUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormInsertUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Új felhasználó";
            this.Load += new System.EventHandler(this.FormInsertUser_Load);
            this.panelInsertUser.ResumeLayout(false);
            this.panelInsertUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInsertUser;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox cmbRoleIn;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox tbPasswordIn2;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.TextBox tbPasswordIn1;
        private System.Windows.Forms.Label lblPassword1;
        private System.Windows.Forms.TextBox tbUsernameIn;
        private System.Windows.Forms.Label lblUsername;
    }
}