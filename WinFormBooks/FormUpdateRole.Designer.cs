namespace WinFormBooks
{
    partial class FormUpdateRole
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
            this.panelUpdateRole = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbRoleUp = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.tbUsernameUp = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panelUpdateRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUpdateRole
            // 
            this.panelUpdateRole.Controls.Add(this.btnUpdate);
            this.panelUpdateRole.Controls.Add(this.cmbRoleUp);
            this.panelUpdateRole.Controls.Add(this.lblRole);
            this.panelUpdateRole.Controls.Add(this.tbUsernameUp);
            this.panelUpdateRole.Controls.Add(this.lblUsername);
            this.panelUpdateRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUpdateRole.Location = new System.Drawing.Point(0, 0);
            this.panelUpdateRole.Name = "panelUpdateRole";
            this.panelUpdateRole.Padding = new System.Windows.Forms.Padding(30);
            this.panelUpdateRole.Size = new System.Drawing.Size(314, 351);
            this.panelUpdateRole.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(33, 258);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(248, 60);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Módosítás";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbRoleUp
            // 
            this.cmbRoleUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRoleUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoleUp.FormattingEnabled = true;
            this.cmbRoleUp.Location = new System.Drawing.Point(33, 150);
            this.cmbRoleUp.Name = "cmbRoleUp";
            this.cmbRoleUp.Size = new System.Drawing.Size(248, 28);
            this.cmbRoleUp.TabIndex = 3;
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(33, 121);
            this.lblRole.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(95, 20);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Jogosultság";
            // 
            // tbUsernameUp
            // 
            this.tbUsernameUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsernameUp.Location = new System.Drawing.Point(33, 62);
            this.tbUsernameUp.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.tbUsernameUp.Name = "tbUsernameUp";
            this.tbUsernameUp.ReadOnly = true;
            this.tbUsernameUp.Size = new System.Drawing.Size(248, 26);
            this.tbUsernameUp.TabIndex = 1;
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
            // FormUpdateRole
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(314, 351);
            this.Controls.Add(this.panelUpdateRole);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormUpdateRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jogosultság módosítása";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUpdateRole_FormClosing);
            this.Load += new System.EventHandler(this.FormUpdateRole_Load);
            this.panelUpdateRole.ResumeLayout(false);
            this.panelUpdateRole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUpdateRole;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbRoleUp;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox tbUsernameUp;
        private System.Windows.Forms.Label lblUsername;
    }
}