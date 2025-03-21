namespace PerfectPlanner
{
    partial class frmDetailUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailUser));
            this.grpUserDetail = new System.Windows.Forms.GroupBox();
            this.mtxUserPassword = new System.Windows.Forms.MaskedTextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.btnDeletePersonAvatar = new System.Windows.Forms.Button();
            this.lblPersonAvatar = new System.Windows.Forms.Label();
            this.picPersonAvatar = new System.Windows.Forms.PictureBox();
            this.lblPersonMail = new System.Windows.Forms.Label();
            this.txtPersonMail = new System.Windows.Forms.TextBox();
            this.lblPersonFirstName = new System.Windows.Forms.Label();
            this.txtPersonFirstName = new System.Windows.Forms.TextBox();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.grpUsersAssigned = new System.Windows.Forms.GroupBox();
            this.btnDeleteAssignee = new System.Windows.Forms.Button();
            this.btnAddAssignee = new System.Windows.Forms.Button();
            this.dgvUsersAssigned = new System.Windows.Forms.DataGridView();
            this.assigneeUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmsRemoveAssignee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRemoveAdminRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAddAssignee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddAdminAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.grpUserDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonAvatar)).BeginInit();
            this.grpUsersAssigned.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersAssigned)).BeginInit();
            this.cmsRemoveAssignee.SuspendLayout();
            this.cmsAddAssignee.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUserDetail
            // 
            this.grpUserDetail.Controls.Add(this.mtxUserPassword);
            this.grpUserDetail.Controls.Add(this.lblUserPassword);
            this.grpUserDetail.Controls.Add(this.lblUserRole);
            this.grpUserDetail.Controls.Add(this.cmbUserRole);
            this.grpUserDetail.Controls.Add(this.btnDeletePersonAvatar);
            this.grpUserDetail.Controls.Add(this.lblPersonAvatar);
            this.grpUserDetail.Controls.Add(this.picPersonAvatar);
            this.grpUserDetail.Controls.Add(this.lblPersonMail);
            this.grpUserDetail.Controls.Add(this.txtPersonMail);
            this.grpUserDetail.Controls.Add(this.lblPersonFirstName);
            this.grpUserDetail.Controls.Add(this.txtPersonFirstName);
            this.grpUserDetail.Controls.Add(this.lblPersonName);
            this.grpUserDetail.Controls.Add(this.txtPersonName);
            this.grpUserDetail.Controls.Add(this.lblUserName);
            this.grpUserDetail.Controls.Add(this.txtUserName);
            this.grpUserDetail.Location = new System.Drawing.Point(20, 20);
            this.grpUserDetail.Name = "grpUserDetail";
            this.grpUserDetail.Size = new System.Drawing.Size(260, 400);
            this.grpUserDetail.TabIndex = 0;
            this.grpUserDetail.TabStop = false;
            this.grpUserDetail.Text = "&Détail de l\'utilisateur";
            // 
            // mtxUserPassword
            // 
            this.mtxUserPassword.Location = new System.Drawing.Point(110, 148);
            this.mtxUserPassword.Name = "mtxUserPassword";
            this.mtxUserPassword.PasswordChar = '*';
            this.mtxUserPassword.Size = new System.Drawing.Size(140, 20);
            this.mtxUserPassword.TabIndex = 9;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Location = new System.Drawing.Point(6, 152);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(71, 13);
            this.lblUserPassword.TabIndex = 8;
            this.lblUserPassword.Text = "&Mot de passe";
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Location = new System.Drawing.Point(6, 371);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(29, 13);
            this.lblUserRole.TabIndex = 12;
            this.lblUserRole.Text = "&Role";
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Items.AddRange(new object[] {
            "Utilisateur",
            "Gestionnaire",
            "Administrateur"});
            this.cmbUserRole.Location = new System.Drawing.Point(110, 367);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(140, 21);
            this.cmbUserRole.TabIndex = 13;
            this.cmbUserRole.SelectedIndexChanged += new System.EventHandler(this.OnSlectedIndexChangeOfCmbUserRole);
            // 
            // btnDeletePersonAvatar
            // 
            this.btnDeletePersonAvatar.Location = new System.Drawing.Point(140, 332);
            this.btnDeletePersonAvatar.Name = "btnDeletePersonAvatar";
            this.btnDeletePersonAvatar.Size = new System.Drawing.Size(80, 23);
            this.btnDeletePersonAvatar.TabIndex = 11;
            this.btnDeletePersonAvatar.Text = "&Supprimer";
            this.btnDeletePersonAvatar.UseVisualStyleBackColor = true;
            this.btnDeletePersonAvatar.Click += new System.EventHandler(this.OnClickOnBtnDeletePersonAvatar);
            // 
            // lblPersonAvatar
            // 
            this.lblPersonAvatar.AutoSize = true;
            this.lblPersonAvatar.Location = new System.Drawing.Point(6, 244);
            this.lblPersonAvatar.Name = "lblPersonAvatar";
            this.lblPersonAvatar.Size = new System.Drawing.Size(38, 13);
            this.lblPersonAvatar.TabIndex = 10;
            this.lblPersonAvatar.Text = "A&vatar";
            // 
            // picPersonAvatar
            // 
            this.picPersonAvatar.Location = new System.Drawing.Point(110, 180);
            this.picPersonAvatar.Name = "picPersonAvatar";
            this.picPersonAvatar.Size = new System.Drawing.Size(140, 140);
            this.picPersonAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPersonAvatar.TabIndex = 8;
            this.picPersonAvatar.TabStop = false;
            // 
            // lblPersonMail
            // 
            this.lblPersonMail.AutoSize = true;
            this.lblPersonMail.Location = new System.Drawing.Point(6, 120);
            this.lblPersonMail.Name = "lblPersonMail";
            this.lblPersonMail.Size = new System.Drawing.Size(36, 13);
            this.lblPersonMail.TabIndex = 6;
            this.lblPersonMail.Text = "E-&Mail";
            // 
            // txtPersonMail
            // 
            this.txtPersonMail.Location = new System.Drawing.Point(110, 116);
            this.txtPersonMail.Name = "txtPersonMail";
            this.txtPersonMail.Size = new System.Drawing.Size(140, 20);
            this.txtPersonMail.TabIndex = 7;
            // 
            // lblPersonFirstName
            // 
            this.lblPersonFirstName.AutoSize = true;
            this.lblPersonFirstName.Location = new System.Drawing.Point(6, 88);
            this.lblPersonFirstName.Name = "lblPersonFirstName";
            this.lblPersonFirstName.Size = new System.Drawing.Size(43, 13);
            this.lblPersonFirstName.TabIndex = 4;
            this.lblPersonFirstName.Text = "&Prénom";
            // 
            // txtPersonFirstName
            // 
            this.txtPersonFirstName.Location = new System.Drawing.Point(110, 84);
            this.txtPersonFirstName.Name = "txtPersonFirstName";
            this.txtPersonFirstName.Size = new System.Drawing.Size(140, 20);
            this.txtPersonFirstName.TabIndex = 5;
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Location = new System.Drawing.Point(6, 56);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(29, 13);
            this.lblPersonName.TabIndex = 2;
            this.lblPersonName.Text = "&Nom";
            // 
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(110, 52);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(140, 20);
            this.txtPersonName.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(6, 24);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(84, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Nom d\'&utilisateur";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(110, 20);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(140, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // grpUsersAssigned
            // 
            this.grpUsersAssigned.Controls.Add(this.btnDeleteAssignee);
            this.grpUsersAssigned.Controls.Add(this.btnAddAssignee);
            this.grpUsersAssigned.Controls.Add(this.dgvUsersAssigned);
            this.grpUsersAssigned.Location = new System.Drawing.Point(300, 20);
            this.grpUsersAssigned.Name = "grpUsersAssigned";
            this.grpUsersAssigned.Size = new System.Drawing.Size(260, 300);
            this.grpUsersAssigned.TabIndex = 1;
            this.grpUsersAssigned.TabStop = false;
            this.grpUsersAssigned.Text = "U&tilisateurs assignés";
            // 
            // btnDeleteAssignee
            // 
            this.btnDeleteAssignee.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteAssignee.Enabled = false;
            this.btnDeleteAssignee.Location = new System.Drawing.Point(140, 260);
            this.btnDeleteAssignee.Name = "btnDeleteAssignee";
            this.btnDeleteAssignee.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAssignee.TabIndex = 8;
            this.btnDeleteAssignee.Text = "&Supprimer";
            this.btnDeleteAssignee.UseVisualStyleBackColor = true;
            this.btnDeleteAssignee.Click += new System.EventHandler(this.OnClickOnTsmiRemoveAssigneeRemove);
            // 
            // btnAddAssignee
            // 
            this.btnAddAssignee.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddAssignee.Location = new System.Drawing.Point(45, 260);
            this.btnAddAssignee.Name = "btnAddAssignee";
            this.btnAddAssignee.Size = new System.Drawing.Size(75, 23);
            this.btnAddAssignee.TabIndex = 7;
            this.btnAddAssignee.Text = "&Ajouter";
            this.btnAddAssignee.UseVisualStyleBackColor = true;
            this.btnAddAssignee.Click += new System.EventHandler(this.OnClickOnTsmiAddAssigneeAdd);
            // 
            // dgvUsersAssigned
            // 
            this.dgvUsersAssigned.AllowUserToAddRows = false;
            this.dgvUsersAssigned.AllowUserToDeleteRows = false;
            this.dgvUsersAssigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersAssigned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assigneeUserId,
            this.userName,
            this.userFirstName});
            this.dgvUsersAssigned.Location = new System.Drawing.Point(7, 26);
            this.dgvUsersAssigned.Name = "dgvUsersAssigned";
            this.dgvUsersAssigned.ReadOnly = true;
            this.dgvUsersAssigned.Size = new System.Drawing.Size(248, 220);
            this.dgvUsersAssigned.TabIndex = 0;
            this.dgvUsersAssigned.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectionCompleteRowOnCellClick);
            this.dgvUsersAssigned.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.HandleDeleteBtnState);
            this.dgvUsersAssigned.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseDownOnDgvUsersAssigned);
            // 
            // assigneeUserId
            // 
            this.assigneeUserId.HeaderText = "Id";
            this.assigneeUserId.Name = "assigneeUserId";
            this.assigneeUserId.ReadOnly = true;
            this.assigneeUserId.Visible = false;
            // 
            // userName
            // 
            this.userName.HeaderText = "Nom";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // userFirstName
            // 
            this.userFirstName.HeaderText = "Prénom";
            this.userFirstName.Name = "userFirstName";
            this.userFirstName.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSave.Location = new System.Drawing.Point(285, 430);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnClickOnBtnSave);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(190, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.OnClickOnBtnCancel);
            // 
            // cmsRemoveAssignee
            // 
            this.cmsRemoveAssignee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRemoveAdminRemove});
            this.cmsRemoveAssignee.Name = "cmsRemoveAssignee";
            this.cmsRemoveAssignee.Size = new System.Drawing.Size(130, 26);
            // 
            // tsmiRemoveAdminRemove
            // 
            this.tsmiRemoveAdminRemove.Name = "tsmiRemoveAdminRemove";
            this.tsmiRemoveAdminRemove.Size = new System.Drawing.Size(129, 22);
            this.tsmiRemoveAdminRemove.Text = "Supprimer";
            this.tsmiRemoveAdminRemove.Click += new System.EventHandler(this.OnClickOnTsmiRemoveAssigneeRemove);
            // 
            // cmsAddAssignee
            // 
            this.cmsAddAssignee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddAdminAdd});
            this.cmsAddAssignee.Name = "cmsRemoveAdmin";
            this.cmsAddAssignee.Size = new System.Drawing.Size(114, 26);
            // 
            // tsmiAddAdminAdd
            // 
            this.tsmiAddAdminAdd.Name = "tsmiAddAdminAdd";
            this.tsmiAddAdminAdd.Size = new System.Drawing.Size(113, 22);
            this.tsmiAddAdminAdd.Text = "Ajouter";
            this.tsmiAddAdminAdd.Click += new System.EventHandler(this.OnClickOnTsmiAddAssigneeAdd);
            // 
            // frmDetailUser
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpUsersAssigned);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpUserDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetailUser";
            this.Text = "Détail de l\'utilisateur";
            this.Load += new System.EventHandler(this.OnLoadOfFrmDetailUser);
            this.grpUserDetail.ResumeLayout(false);
            this.grpUserDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonAvatar)).EndInit();
            this.grpUsersAssigned.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersAssigned)).EndInit();
            this.cmsRemoveAssignee.ResumeLayout(false);
            this.cmsAddAssignee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUserDetail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox grpUsersAssigned;
        private System.Windows.Forms.DataGridView dgvUsersAssigned;
        private System.Windows.Forms.Button btnDeletePersonAvatar;
        private System.Windows.Forms.Label lblPersonAvatar;
        private System.Windows.Forms.PictureBox picPersonAvatar;
        private System.Windows.Forms.Label lblPersonMail;
        private System.Windows.Forms.TextBox txtPersonMail;
        private System.Windows.Forms.Label lblPersonFirstName;
        private System.Windows.Forms.TextBox txtPersonFirstName;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.ContextMenuStrip cmsRemoveAssignee;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveAdminRemove;
        private System.Windows.Forms.ContextMenuStrip cmsAddAssignee;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddAdminAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn assigneeUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFirstName;
        private System.Windows.Forms.MaskedTextBox mtxUserPassword;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Button btnDeleteAssignee;
        private System.Windows.Forms.Button btnAddAssignee;
    }
}