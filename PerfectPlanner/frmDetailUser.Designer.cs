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
            this.grpUserDetail = new System.Windows.Forms.GroupBox();
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
            this.dgvUsersAssigned = new System.Windows.Forms.DataGridView();
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
            this.grpUserDetail.Location = new System.Drawing.Point(12, 12);
            this.grpUserDetail.Name = "grpUserDetail";
            this.grpUserDetail.Size = new System.Drawing.Size(235, 345);
            this.grpUserDetail.TabIndex = 0;
            this.grpUserDetail.TabStop = false;
            this.grpUserDetail.Text = "Détail de l\'utilisateur";
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Location = new System.Drawing.Point(6, 312);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(29, 13);
            this.lblUserRole.TabIndex = 12;
            this.lblUserRole.Text = "Role";
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Items.AddRange(new object[] {
            "Utilisateur",
            "Gestionnaire",
            "Administrateur"});
            this.cmbUserRole.Location = new System.Drawing.Point(96, 309);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(121, 21);
            this.cmbUserRole.TabIndex = 11;
            this.cmbUserRole.SelectedIndexChanged += new System.EventHandler(this.cmbUserRole_SelectedIndexChanged);
            // 
            // btnDeletePersonAvatar
            // 
            this.btnDeletePersonAvatar.Location = new System.Drawing.Point(123, 269);
            this.btnDeletePersonAvatar.Name = "btnDeletePersonAvatar";
            this.btnDeletePersonAvatar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePersonAvatar.TabIndex = 10;
            this.btnDeletePersonAvatar.Text = "Supprimer";
            this.btnDeletePersonAvatar.UseVisualStyleBackColor = true;
            // 
            // lblPersonAvatar
            // 
            this.lblPersonAvatar.AutoSize = true;
            this.lblPersonAvatar.Location = new System.Drawing.Point(6, 133);
            this.lblPersonAvatar.Name = "lblPersonAvatar";
            this.lblPersonAvatar.Size = new System.Drawing.Size(38, 13);
            this.lblPersonAvatar.TabIndex = 9;
            this.lblPersonAvatar.Text = "Avatar";
            // 
            // picPersonAvatar
            // 
            this.picPersonAvatar.Location = new System.Drawing.Point(96, 133);
            this.picPersonAvatar.Name = "picPersonAvatar";
            this.picPersonAvatar.Size = new System.Drawing.Size(133, 130);
            this.picPersonAvatar.TabIndex = 8;
            this.picPersonAvatar.TabStop = false;
            // 
            // lblPersonMail
            // 
            this.lblPersonMail.AutoSize = true;
            this.lblPersonMail.Location = new System.Drawing.Point(6, 109);
            this.lblPersonMail.Name = "lblPersonMail";
            this.lblPersonMail.Size = new System.Drawing.Size(36, 13);
            this.lblPersonMail.TabIndex = 7;
            this.lblPersonMail.Text = "E-Mail";
            // 
            // txtPersonMail
            // 
            this.txtPersonMail.Location = new System.Drawing.Point(96, 106);
            this.txtPersonMail.Name = "txtPersonMail";
            this.txtPersonMail.Size = new System.Drawing.Size(133, 20);
            this.txtPersonMail.TabIndex = 6;
            // 
            // lblPersonFirstName
            // 
            this.lblPersonFirstName.AutoSize = true;
            this.lblPersonFirstName.Location = new System.Drawing.Point(6, 83);
            this.lblPersonFirstName.Name = "lblPersonFirstName";
            this.lblPersonFirstName.Size = new System.Drawing.Size(43, 13);
            this.lblPersonFirstName.TabIndex = 5;
            this.lblPersonFirstName.Text = "Prénom";
            // 
            // txtPersonFirstName
            // 
            this.txtPersonFirstName.Location = new System.Drawing.Point(96, 80);
            this.txtPersonFirstName.Name = "txtPersonFirstName";
            this.txtPersonFirstName.Size = new System.Drawing.Size(133, 20);
            this.txtPersonFirstName.TabIndex = 4;
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Location = new System.Drawing.Point(6, 57);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(29, 13);
            this.lblPersonName.TabIndex = 3;
            this.lblPersonName.Text = "Nom";
            // 
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(96, 54);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(133, 20);
            this.txtPersonName.TabIndex = 2;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(6, 31);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(84, 13);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Nom d\'utilisateur";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(96, 28);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(133, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // grpUsersAssigned
            // 
            this.grpUsersAssigned.Controls.Add(this.dgvUsersAssigned);
            this.grpUsersAssigned.Location = new System.Drawing.Point(287, 12);
            this.grpUsersAssigned.Name = "grpUsersAssigned";
            this.grpUsersAssigned.Size = new System.Drawing.Size(365, 303);
            this.grpUsersAssigned.TabIndex = 1;
            this.grpUsersAssigned.TabStop = false;
            this.grpUsersAssigned.Text = "Utilisateurs assignés";
            // 
            // dgvUsersAssigned
            // 
            this.dgvUsersAssigned.AllowUserToAddRows = false;
            this.dgvUsersAssigned.AllowUserToDeleteRows = false;
            this.dgvUsersAssigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersAssigned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.userFirstName});
            this.dgvUsersAssigned.Location = new System.Drawing.Point(7, 20);
            this.dgvUsersAssigned.Name = "dgvUsersAssigned";
            this.dgvUsersAssigned.ReadOnly = true;
            this.dgvUsersAssigned.Size = new System.Drawing.Size(352, 232);
            this.dgvUsersAssigned.TabIndex = 0;
            this.dgvUsersAssigned.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvUsersAssigned_MouseDown);
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
            this.btnSave.Location = new System.Drawing.Point(424, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(294, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            this.tsmiRemoveAdminRemove.Click += new System.EventHandler(this.tsmiRemoveAssigneeRemove_Click);
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
            this.tsmiAddAdminAdd.Size = new System.Drawing.Size(180, 22);
            this.tsmiAddAdminAdd.Text = "Ajouter";
            this.tsmiAddAdminAdd.Click += new System.EventHandler(this.tsmiAddAssigneeAdd_Click);
            // 
            // frmDetailUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpUsersAssigned);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpUserDetail);
            this.Name = "frmDetailUser";
            this.Text = "frmDetailUser";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFirstName;
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
    }
}