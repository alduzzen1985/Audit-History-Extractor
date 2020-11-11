namespace AuditHistoryExtractor.Controls
{
    partial class FormSelectUsers
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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblNameUsername = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lstViewUsers = new System.Windows.Forms.ListView();
            this.clmFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnSelectUnSelectAll = new System.Windows.Forms.Button();
            this.pnlSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.lblNameUsername);
            this.pnlSearch.Controls.Add(this.txtUser);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnlSearch.Size = new System.Drawing.Size(561, 38);
            this.pnlSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(331, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 24);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblNameUsername
            // 
            this.lblNameUsername.AutoSize = true;
            this.lblNameUsername.Location = new System.Drawing.Point(5, 12);
            this.lblNameUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameUsername.Name = "lblNameUsername";
            this.lblNameUsername.Size = new System.Drawing.Size(94, 13);
            this.lblNameUsername.TabIndex = 1;
            this.lblNameUsername.Text = "Name / Username";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(103, 8);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(218, 20);
            this.txtUser.TabIndex = 0;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // lstViewUsers
            // 
            this.lstViewUsers.CheckBoxes = true;
            this.lstViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmFullName,
            this.clmUserName});
            this.lstViewUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstViewUsers.HideSelection = false;
            this.lstViewUsers.Location = new System.Drawing.Point(0, 38);
            this.lstViewUsers.Margin = new System.Windows.Forms.Padding(2);
            this.lstViewUsers.Name = "lstViewUsers";
            this.lstViewUsers.Size = new System.Drawing.Size(561, 258);
            this.lstViewUsers.TabIndex = 1;
            this.lstViewUsers.UseCompatibleStateImageBehavior = false;
            this.lstViewUsers.View = System.Windows.Forms.View.Details;
            this.lstViewUsers.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstViewUsers_ItemChecked);
            // 
            // clmFullName
            // 
            this.clmFullName.Text = "Full Name";
            this.clmFullName.Width = 235;
            // 
            // clmUserName
            // 
            this.clmUserName.Text = "User Name";
            this.clmUserName.Width = 288;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.btnSelectUnSelectAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 296);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 44);
            this.panel1.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(409, 11);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(119, 26);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnSelectUnSelectAll
            // 
            this.btnSelectUnSelectAll.Location = new System.Drawing.Point(8, 11);
            this.btnSelectUnSelectAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectUnSelectAll.Name = "btnSelectUnSelectAll";
            this.btnSelectUnSelectAll.Size = new System.Drawing.Size(127, 26);
            this.btnSelectUnSelectAll.TabIndex = 3;
            this.btnSelectUnSelectAll.Text = "Select / Unselect all";
            this.btnSelectUnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectUnSelectAll.Click += new System.EventHandler(this.btnSelectUnSelectAll_Click);
            // 
            // FormSelectUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstViewUsers);
            this.Controls.Add(this.pnlSearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSelectUsers";
            this.Text = "FormSelectUsers";
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblNameUsername;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ListView lstViewUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelectUnSelectAll;
        private System.Windows.Forms.ColumnHeader clmFullName;
        private System.Windows.Forms.ColumnHeader clmUserName;
        private System.Windows.Forms.Button btnConfirm;
    }
}