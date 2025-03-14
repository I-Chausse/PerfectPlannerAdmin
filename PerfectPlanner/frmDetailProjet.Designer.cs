namespace PerfectPlanner
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
            this.grpAdminsAssigned = new System.Windows.Forms.GroupBox();
            this.dgvAdminsAssigned = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpProjectDetail = new System.Windows.Forms.GroupBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpUsersAssigned = new System.Windows.Forms.GroupBox();
            this.dgvUsersAssigned = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsAddAdmin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddAdminAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRemoveAdmin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRemoveAdminRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAddAssignee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddAssigneeAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRemoveAssignee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRemoveAssigneeRemove = new System.Windows.Forms.ToolStripMenuItem();
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
            this.grpAdminsAssigned.Controls.Add(this.dgvAdminsAssigned);
            this.grpAdminsAssigned.Location = new System.Drawing.Point(287, 12);
            this.grpAdminsAssigned.Name = "grpAdminsAssigned";
            this.grpAdminsAssigned.Size = new System.Drawing.Size(261, 303);
            this.grpAdminsAssigned.TabIndex = 3;
            this.grpAdminsAssigned.TabStop = false;
            this.grpAdminsAssigned.Text = "Gestionnaires assignés";
            // 
            // dgvAdminsAssigned
            // 
            this.dgvAdminsAssigned.AllowUserToAddRows = false;
            this.dgvAdminsAssigned.AllowUserToDeleteRows = false;
            this.dgvAdminsAssigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminsAssigned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.userFirstName});
            this.dgvAdminsAssigned.Location = new System.Drawing.Point(7, 20);
            this.dgvAdminsAssigned.Name = "dgvAdminsAssigned";
            this.dgvAdminsAssigned.ReadOnly = true;
            this.dgvAdminsAssigned.Size = new System.Drawing.Size(248, 232);
            this.dgvAdminsAssigned.TabIndex = 0;
            this.dgvAdminsAssigned.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvAdminsAssigned_MouseDown);
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
            // grpProjectDetail
            // 
            this.grpProjectDetail.Controls.Add(this.lblProjectName);
            this.grpProjectDetail.Controls.Add(this.txtProjectName);
            this.grpProjectDetail.Location = new System.Drawing.Point(12, 12);
            this.grpProjectDetail.Name = "grpProjectDetail";
            this.grpProjectDetail.Size = new System.Drawing.Size(235, 64);
            this.grpProjectDetail.TabIndex = 2;
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
            this.lblProjectName.Text = "Nom du projet";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(96, 28);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(133, 20);
            this.txtProjectName.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(295, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(425, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // grpUsersAssigned
            // 
            this.grpUsersAssigned.Controls.Add(this.dgvUsersAssigned);
            this.grpUsersAssigned.Location = new System.Drawing.Point(569, 12);
            this.grpUsersAssigned.Name = "grpUsersAssigned";
            this.grpUsersAssigned.Size = new System.Drawing.Size(261, 303);
            this.grpUsersAssigned.TabIndex = 4;
            this.grpUsersAssigned.TabStop = false;
            this.grpUsersAssigned.Text = "Utilisateurs assignés";
            // 
            // dgvUsersAssigned
            // 
            this.dgvUsersAssigned.AllowUserToAddRows = false;
            this.dgvUsersAssigned.AllowUserToDeleteRows = false;
            this.dgvUsersAssigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersAssigned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvUsersAssigned.Location = new System.Drawing.Point(7, 20);
            this.dgvUsersAssigned.Name = "dgvUsersAssigned";
            this.dgvUsersAssigned.ReadOnly = true;
            this.dgvUsersAssigned.Size = new System.Drawing.Size(248, 232);
            this.dgvUsersAssigned.TabIndex = 0;
            this.dgvUsersAssigned.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvUsersAssigned_MouseDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Prénom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // cmsAddAdmin
            // 
            this.cmsAddAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddAdminAdd});
            this.cmsAddAdmin.Name = "cmsRemoveAdmin";
            this.cmsAddAdmin.Size = new System.Drawing.Size(114, 26);
            this.cmsAddAdmin.Click += new System.EventHandler(this.tsmiAddAdminAdd_Click);
            // 
            // tsmiAddAdminAdd
            // 
            this.tsmiAddAdminAdd.Name = "tsmiAddAdminAdd";
            this.tsmiAddAdminAdd.Size = new System.Drawing.Size(113, 22);
            this.tsmiAddAdminAdd.Text = "Ajouter";
            // 
            // cmsRemoveAdmin
            // 
            this.cmsRemoveAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRemoveAdminRemove});
            this.cmsRemoveAdmin.Name = "cmsRemoveAdmin";
            this.cmsRemoveAdmin.Size = new System.Drawing.Size(130, 26);
            this.cmsRemoveAdmin.Click += new System.EventHandler(this.tsmiRemoveAdminRemove_Click);
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
            this.cmsAddAssignee.Click += new System.EventHandler(this.tsmiAddAssigneeAdd_Click);
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
            this.tsmiRemoveAssigneeRemove.Click += new System.EventHandler(this.tsmiRemoveAssigneeRemove_Click);
            // 
            // frmDetailProjet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(864, 461);
            this.Controls.Add(this.grpUsersAssigned);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpAdminsAssigned);
            this.Controls.Add(this.grpProjectDetail);
            this.Name = "frmDetailProjet";
            this.Text = "frmDetailProjet";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFirstName;
        private System.Windows.Forms.GroupBox grpProjectDetail;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpUsersAssigned;
        private System.Windows.Forms.DataGridView dgvUsersAssigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ContextMenuStrip cmsAddAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddAdminAdd;
        private System.Windows.Forms.ContextMenuStrip cmsRemoveAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveAdminRemove;
        private System.Windows.Forms.ContextMenuStrip cmsAddAssignee;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddAssigneeAdd;
        private System.Windows.Forms.ContextMenuStrip cmsRemoveAssignee;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveAssigneeRemove;
    }
}