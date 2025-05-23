﻿namespace PerfectPlanner
{
    partial class frmDetailProjet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailProjet));
            this.grpAdminsAssigned = new System.Windows.Forms.GroupBox();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            this.dgvAdminsAssigned = new System.Windows.Forms.DataGridView();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.grpProjectDetail = new System.Windows.Forms.GroupBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpUsersAssigned = new System.Windows.Forms.GroupBox();
            this.btnRemoveAssignee = new System.Windows.Forms.Button();
            this.btnAddAssignee = new System.Windows.Forms.Button();
            this.dgvUsersAssigned = new System.Windows.Forms.DataGridView();
            this.cmsAddAdmin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddAdminAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRemoveAdmin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRemoveAdminRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAddAssignee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddAssigneeAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRemoveAssignee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRemoveAssigneeRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.adminUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assigneeUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assigneeUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assigneeFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAdminsAssigned.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminsAssigned)).BeginInit();
            this.grpProjectDetail.SuspendLayout();
            this.grpUsersAssigned.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersAssigned)).BeginInit();
            this.cmsAddAdmin.SuspendLayout();
            this.cmsRemoveAdmin.SuspendLayout();
            this.cmsAddAssignee.SuspendLayout();
            this.cmsRemoveAssignee.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAdminsAssigned
            // 
            this.grpAdminsAssigned.Controls.Add(this.btnDeleteAdmin);
            this.grpAdminsAssigned.Controls.Add(this.dgvAdminsAssigned);
            this.grpAdminsAssigned.Controls.Add(this.btnAddAdmin);
            this.grpAdminsAssigned.Location = new System.Drawing.Point(300, 20);
            this.grpAdminsAssigned.Name = "grpAdminsAssigned";
            this.grpAdminsAssigned.Size = new System.Drawing.Size(260, 300);
            this.grpAdminsAssigned.TabIndex = 1;
            this.grpAdminsAssigned.TabStop = false;
            this.grpAdminsAssigned.Text = "G&estionnaires assignés";
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteAdmin.Enabled = false;
            this.btnDeleteAdmin.Location = new System.Drawing.Point(140, 260);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAdmin.TabIndex = 6;
            this.btnDeleteAdmin.Text = "&Supprimer";
            this.btnDeleteAdmin.UseVisualStyleBackColor = true;
            this.btnDeleteAdmin.Click += new System.EventHandler(this.OnClickOnTsmiRemoveAdminRemove);
            // 
            // dgvAdminsAssigned
            // 
            this.dgvAdminsAssigned.AllowUserToAddRows = false;
            this.dgvAdminsAssigned.AllowUserToDeleteRows = false;
            this.dgvAdminsAssigned.AutoGenerateColumns = false;
            this.dgvAdminsAssigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminsAssigned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminUserId,
            this.userName,
            this.userFirstName});
            this.dgvAdminsAssigned.Location = new System.Drawing.Point(7, 26);
            this.dgvAdminsAssigned.Name = "dgvAdminsAssigned";
            this.dgvAdminsAssigned.ReadOnly = true;
            this.dgvAdminsAssigned.RowTemplate.ReadOnly = true;
            this.dgvAdminsAssigned.Size = new System.Drawing.Size(248, 220);
            this.dgvAdminsAssigned.TabIndex = 0;
            this.dgvAdminsAssigned.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectionCompleteRowOnCellClick);
            this.dgvAdminsAssigned.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.HandleDeleteBtnState);
            this.dgvAdminsAssigned.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseDownOnDgvAdminsAssigned);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddAdmin.Location = new System.Drawing.Point(45, 260);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAddAdmin.TabIndex = 4;
            this.btnAddAdmin.Text = "&Ajouter";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.OnClickOnTsmiAddAdminAdd);
            // 
            // grpProjectDetail
            // 
            this.grpProjectDetail.Controls.Add(this.lblProjectName);
            this.grpProjectDetail.Controls.Add(this.txtProjectName);
            this.grpProjectDetail.Location = new System.Drawing.Point(20, 20);
            this.grpProjectDetail.Name = "grpProjectDetail";
            this.grpProjectDetail.Size = new System.Drawing.Size(260, 64);
            this.grpProjectDetail.TabIndex = 0;
            this.grpProjectDetail.TabStop = false;
            this.grpProjectDetail.Text = "Détail du projet";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(6, 31);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(73, 13);
            this.lblProjectName.TabIndex = 1;
            this.lblProjectName.Text = "&Nom du projet";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(96, 27);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(158, 20);
            this.txtProjectName.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(345, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.OnClickOnBtnCancel);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(440, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnClickOnBtnSave);
            // 
            // grpUsersAssigned
            // 
            this.grpUsersAssigned.Controls.Add(this.btnRemoveAssignee);
            this.grpUsersAssigned.Controls.Add(this.btnAddAssignee);
            this.grpUsersAssigned.Controls.Add(this.dgvUsersAssigned);
            this.grpUsersAssigned.Location = new System.Drawing.Point(580, 20);
            this.grpUsersAssigned.Name = "grpUsersAssigned";
            this.grpUsersAssigned.Size = new System.Drawing.Size(260, 300);
            this.grpUsersAssigned.TabIndex = 2;
            this.grpUsersAssigned.TabStop = false;
            this.grpUsersAssigned.Text = "U&tilisateurs assignés";
            // 
            // btnRemoveAssignee
            // 
            this.btnRemoveAssignee.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemoveAssignee.Enabled = false;
            this.btnRemoveAssignee.Location = new System.Drawing.Point(140, 260);
            this.btnRemoveAssignee.Name = "btnRemoveAssignee";
            this.btnRemoveAssignee.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAssignee.TabIndex = 8;
            this.btnRemoveAssignee.Text = "&Supprimer";
            this.btnRemoveAssignee.UseVisualStyleBackColor = true;
            this.btnRemoveAssignee.Click += new System.EventHandler(this.OnClickOnTsmiRemoveAssigneeRemove);
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
            this.btnAddAssignee.Click += new System.EventHandler(this.OnCLickOnTsmiAddAssigneeAdd);
            // 
            // dgvUsersAssigned
            // 
            this.dgvUsersAssigned.AllowUserToAddRows = false;
            this.dgvUsersAssigned.AllowUserToDeleteRows = false;
            this.dgvUsersAssigned.AutoGenerateColumns = false;
            this.dgvUsersAssigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersAssigned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assigneeUserId,
            this.assigneeUserName,
            this.assigneeFirstName});
            this.dgvUsersAssigned.Location = new System.Drawing.Point(7, 26);
            this.dgvUsersAssigned.Name = "dgvUsersAssigned";
            this.dgvUsersAssigned.ReadOnly = true;
            this.dgvUsersAssigned.RowTemplate.ReadOnly = true;
            this.dgvUsersAssigned.Size = new System.Drawing.Size(248, 220);
            this.dgvUsersAssigned.TabIndex = 0;
            this.dgvUsersAssigned.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectionCompleteRowOnCellClick);
            this.dgvUsersAssigned.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.HandleDeleteBtnState);
            this.dgvUsersAssigned.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseDownOnDgvUsersAssigned);
            // 
            // cmsAddAdmin
            // 
            this.cmsAddAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddAdminAdd});
            this.cmsAddAdmin.Name = "cmsRemoveAdmin";
            this.cmsAddAdmin.Size = new System.Drawing.Size(114, 26);
            // 
            // tsmiAddAdminAdd
            // 
            this.tsmiAddAdminAdd.Name = "tsmiAddAdminAdd";
            this.tsmiAddAdminAdd.Size = new System.Drawing.Size(113, 22);
            this.tsmiAddAdminAdd.Text = "Ajouter";
            this.tsmiAddAdminAdd.Click += new System.EventHandler(this.OnClickOnTsmiAddAdminAdd);
            // 
            // cmsRemoveAdmin
            // 
            this.cmsRemoveAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRemoveAdminRemove});
            this.cmsRemoveAdmin.Name = "cmsRemoveAdmin";
            this.cmsRemoveAdmin.Size = new System.Drawing.Size(130, 26);
            this.cmsRemoveAdmin.Click += new System.EventHandler(this.OnClickOnTsmiRemoveAdminRemove);
            // 
            // tsmiRemoveAdminRemove
            // 
            this.tsmiRemoveAdminRemove.Name = "tsmiRemoveAdminRemove";
            this.tsmiRemoveAdminRemove.Size = new System.Drawing.Size(129, 22);
            this.tsmiRemoveAdminRemove.Text = "Supprimer";
            // 
            // cmsAddAssignee
            // 
            this.cmsAddAssignee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddAssigneeAdd});
            this.cmsAddAssignee.Name = "cmsRemoveAdmin";
            this.cmsAddAssignee.Size = new System.Drawing.Size(114, 26);
            this.cmsAddAssignee.Click += new System.EventHandler(this.OnCLickOnTsmiAddAssigneeAdd);
            // 
            // tsmiAddAssigneeAdd
            // 
            this.tsmiAddAssigneeAdd.Name = "tsmiAddAssigneeAdd";
            this.tsmiAddAssigneeAdd.Size = new System.Drawing.Size(113, 22);
            this.tsmiAddAssigneeAdd.Text = "Ajouter";
            // 
            // cmsRemoveAssignee
            // 
            this.cmsRemoveAssignee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRemoveAssigneeRemove});
            this.cmsRemoveAssignee.Name = "cmsRemoveAdmin";
            this.cmsRemoveAssignee.Size = new System.Drawing.Size(130, 26);
            // 
            // tsmiRemoveAssigneeRemove
            // 
            this.tsmiRemoveAssigneeRemove.Name = "tsmiRemoveAssigneeRemove";
            this.tsmiRemoveAssigneeRemove.Size = new System.Drawing.Size(129, 22);
            this.tsmiRemoveAssigneeRemove.Text = "Supprimer";
            this.tsmiRemoveAssigneeRemove.Click += new System.EventHandler(this.OnClickOnTsmiRemoveAssigneeRemove);
            // 
            // adminUserId
            // 
            this.adminUserId.DataPropertyName = "id";
            this.adminUserId.HeaderText = "Id";
            this.adminUserId.Name = "adminUserId";
            this.adminUserId.ReadOnly = true;
            this.adminUserId.Visible = false;
            // 
            // userName
            // 
            this.userName.DataPropertyName = "name";
            this.userName.HeaderText = "Nom";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // userFirstName
            // 
            this.userFirstName.DataPropertyName = "first_name";
            this.userFirstName.HeaderText = "Prénom";
            this.userFirstName.Name = "userFirstName";
            this.userFirstName.ReadOnly = true;
            // 
            // assigneeUserId
            // 
            this.assigneeUserId.DataPropertyName = "id";
            this.assigneeUserId.HeaderText = "Id";
            this.assigneeUserId.Name = "assigneeUserId";
            this.assigneeUserId.ReadOnly = true;
            this.assigneeUserId.Visible = false;
            // 
            // assigneeUserName
            // 
            this.assigneeUserName.DataPropertyName = "name";
            this.assigneeUserName.HeaderText = "Nom";
            this.assigneeUserName.Name = "assigneeUserName";
            this.assigneeUserName.ReadOnly = true;
            // 
            // assigneeFirstName
            // 
            this.assigneeFirstName.DataPropertyName = "first_name";
            this.assigneeFirstName.HeaderText = "Prénom";
            this.assigneeFirstName.Name = "assigneeFirstName";
            this.assigneeFirstName.ReadOnly = true;
            // 
            // frmDetailProjet
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(864, 441);
            this.Controls.Add(this.grpUsersAssigned);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpAdminsAssigned);
            this.Controls.Add(this.grpProjectDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDetailProjet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Détail du projet";
            this.Load += new System.EventHandler(this.OnLoadOfFrmDetailProjet);
            this.grpAdminsAssigned.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminsAssigned)).EndInit();
            this.grpProjectDetail.ResumeLayout(false);
            this.grpProjectDetail.PerformLayout();
            this.grpUsersAssigned.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersAssigned)).EndInit();
            this.cmsAddAdmin.ResumeLayout(false);
            this.cmsRemoveAdmin.ResumeLayout(false);
            this.cmsAddAssignee.ResumeLayout(false);
            this.cmsRemoveAssignee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdminsAssigned;
        private System.Windows.Forms.DataGridView dgvAdminsAssigned;
        private System.Windows.Forms.GroupBox grpProjectDetail;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpUsersAssigned;
        private System.Windows.Forms.DataGridView dgvUsersAssigned;
        private System.Windows.Forms.ContextMenuStrip cmsAddAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddAdminAdd;
        private System.Windows.Forms.ContextMenuStrip cmsRemoveAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveAdminRemove;
        private System.Windows.Forms.ContextMenuStrip cmsAddAssignee;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddAssigneeAdd;
        private System.Windows.Forms.ContextMenuStrip cmsRemoveAssignee;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveAssigneeRemove;
        private System.Windows.Forms.Button btnDeleteAdmin;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Button btnRemoveAssignee;
        private System.Windows.Forms.Button btnAddAssignee;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn assigneeUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn assigneeUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn assigneeFirstName;
    }
}