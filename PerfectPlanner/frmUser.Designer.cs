namespace PerfectPlanner
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersAssigned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsEditUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditUserEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditUSerDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAddUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddUserAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblSearchUserName = new System.Windows.Forms.Label();
            this.txtSearchUserName = new System.Windows.Forms.TextBox();
            this.btnSearchUserName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmsEditUser.SuspendLayout();
            this.cmsAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.userName,
            this.name,
            this.firstName,
            this.email,
            this.role,
            this.usersAssigned});
            this.dgvUsers.Location = new System.Drawing.Point(12, 65);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(910, 630);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectionCompleteRowOnCellClick);
            this.dgvUsers.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.HandleEditAndDeleteBtnState);
            this.dgvUsers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDownOnDgvUser);
            // 
            // userId
            // 
            this.userId.DataPropertyName = "id";
            this.userId.HeaderText = "Id";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            this.userId.Visible = false;
            // 
            // userName
            // 
            this.userName.DataPropertyName = "user_name";
            this.userName.HeaderText = "Nom d\'utilisateur";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.Width = 150;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Nom";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.DataPropertyName = "first_name";
            this.firstName.HeaderText = "Prénom";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "E-Mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 200;
            // 
            // role
            // 
            this.role.DataPropertyName = "role_name";
            this.role.HeaderText = "Rôle";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            // 
            // usersAssigned
            // 
            this.usersAssigned.DataPropertyName = "display_assignees";
            this.usersAssigned.HeaderText = "Utilisateurs assignés";
            this.usersAssigned.Name = "usersAssigned";
            this.usersAssigned.Width = 200;
            // 
            // cmsEditUser
            // 
            this.cmsEditUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditUserEdit,
            this.tsmiEditUSerDelete});
            this.cmsEditUser.Name = "cmsEditUser";
            this.cmsEditUser.Size = new System.Drawing.Size(130, 48);
            // 
            // tsmiEditUserEdit
            // 
            this.tsmiEditUserEdit.Name = "tsmiEditUserEdit";
            this.tsmiEditUserEdit.Size = new System.Drawing.Size(129, 22);
            this.tsmiEditUserEdit.Text = "Modifier";
            this.tsmiEditUserEdit.Click += new System.EventHandler(this.OnClickOnTsmiEditUserEdit);
            // 
            // tsmiEditUSerDelete
            // 
            this.tsmiEditUSerDelete.Name = "tsmiEditUSerDelete";
            this.tsmiEditUSerDelete.Size = new System.Drawing.Size(129, 22);
            this.tsmiEditUSerDelete.Text = "Supprimer";
            this.tsmiEditUSerDelete.Click += new System.EventHandler(this.OnClickOnTsmiEditUserDelete);
            // 
            // cmsAddUser
            // 
            this.cmsAddUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddUserAdd});
            this.cmsAddUser.Name = "cmsAddUser";
            this.cmsAddUser.Size = new System.Drawing.Size(114, 26);
            // 
            // tsmiAddUserAdd
            // 
            this.tsmiAddUserAdd.Name = "tsmiAddUserAdd";
            this.tsmiAddUserAdd.Size = new System.Drawing.Size(113, 22);
            this.tsmiAddUserAdd.Text = "Ajouter";
            this.tsmiAddUserAdd.Click += new System.EventHandler(this.OnClickOnTsmiAddUserAdd);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteUser.Location = new System.Drawing.Point(525, 720);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(80, 23);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "&Supprimer";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.OnClickOnTsmiEditUserDelete);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdateUser.Location = new System.Drawing.Point(425, 720);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(80, 23);
            this.btnUpdateUser.TabIndex = 2;
            this.btnUpdateUser.Text = "&Modifier";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.OnClickOnTsmiEditUserEdit);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddUser.Location = new System.Drawing.Point(325, 720);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(80, 23);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "&Ajouter";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.OnClickOnTsmiAddUserAdd);
            // 
            // lblSearchUserName
            // 
            this.lblSearchUserName.AutoSize = true;
            this.lblSearchUserName.Location = new System.Drawing.Point(13, 24);
            this.lblSearchUserName.Name = "lblSearchUserName";
            this.lblSearchUserName.Size = new System.Drawing.Size(84, 13);
            this.lblSearchUserName.TabIndex = 4;
            this.lblSearchUserName.Text = "Nom d\'utilisateur";
            // 
            // txtSearchUserName
            // 
            this.txtSearchUserName.Location = new System.Drawing.Point(103, 21);
            this.txtSearchUserName.Name = "txtSearchUserName";
            this.txtSearchUserName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchUserName.TabIndex = 5;
            // 
            // btnSearchUserName
            // 
            this.btnSearchUserName.Location = new System.Drawing.Point(221, 19);
            this.btnSearchUserName.Name = "btnSearchUserName";
            this.btnSearchUserName.Size = new System.Drawing.Size(75, 23);
            this.btnSearchUserName.TabIndex = 6;
            this.btnSearchUserName.Text = "&Rechercher";
            this.btnSearchUserName.UseVisualStyleBackColor = true;
            this.btnSearchUserName.Click += new System.EventHandler(this.btnSearchUserName_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 761);
            this.Controls.Add(this.btnSearchUserName);
            this.Controls.Add(this.txtSearchUserName);
            this.Controls.Add(this.lblSearchUserName);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.dgvUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 200);
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Utilisateurs";
            this.Load += new System.EventHandler(this.OnLoadOfFrmUser);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.cmsEditUser.ResumeLayout(false);
            this.cmsAddUser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ContextMenuStrip cmsEditUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditUserEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditUSerDelete;
        private System.Windows.Forms.ContextMenuStrip cmsAddUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddUserAdd;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersAssigned;
        private System.Windows.Forms.Label lblSearchUserName;
        private System.Windows.Forms.TextBox txtSearchUserName;
        private System.Windows.Forms.Button btnSearchUserName;
    }
}