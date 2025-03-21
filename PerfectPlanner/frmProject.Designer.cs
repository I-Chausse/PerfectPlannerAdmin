namespace PerfectPlanner
{
    partial class frmProject
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
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.projectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectAssignees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsAddProject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddUserAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditProject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditProjectEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditProjectDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnUpdateProject = new System.Windows.Forms.Button();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.cmsAddProject.SuspendLayout();
            this.cmsEditProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            this.dgvProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectId,
            this.projectName,
            this.projectAdmin,
            this.projectAssignees});
            this.dgvProjects.Location = new System.Drawing.Point(12, 25);
            this.dgvProjects.MultiSelect = false;
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.Size = new System.Drawing.Size(760, 670);
            this.dgvProjects.TabIndex = 0;
            this.dgvProjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectionCompleteRowOnCellClick);
            this.dgvProjects.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.HandleEditAndDeleteBtnState);
            this.dgvProjects.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvProject_MouseDown);
            // 
            // projectId
            // 
            this.projectId.HeaderText = "Id";
            this.projectId.Name = "projectId";
            this.projectId.ReadOnly = true;
            this.projectId.Visible = false;
            // 
            // projectName
            // 
            this.projectName.HeaderText = "Nom du projet";
            this.projectName.Name = "projectName";
            this.projectName.ReadOnly = true;
            this.projectName.Width = 265;
            // 
            // projectAdmin
            // 
            this.projectAdmin.HeaderText = "Gestionnaire(s)";
            this.projectAdmin.Name = "projectAdmin";
            this.projectAdmin.ReadOnly = true;
            this.projectAdmin.Width = 200;
            // 
            // projectAssignees
            // 
            this.projectAssignees.HeaderText = "Utilisateurs assignés";
            this.projectAssignees.Name = "projectAssignees";
            this.projectAssignees.Width = 250;
            // 
            // cmsAddProject
            // 
            this.cmsAddProject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddUserAdd});
            this.cmsAddProject.Name = "cmsAddUser";
            this.cmsAddProject.Size = new System.Drawing.Size(114, 26);
            // 
            // tsmiAddUserAdd
            // 
            this.tsmiAddUserAdd.Name = "tsmiAddUserAdd";
            this.tsmiAddUserAdd.Size = new System.Drawing.Size(113, 22);
            this.tsmiAddUserAdd.Text = "Ajouter";
            this.tsmiAddUserAdd.Click += new System.EventHandler(this.tsmiAddProjectAdd_Click);
            // 
            // cmsEditProject
            // 
            this.cmsEditProject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditProjectEdit,
            this.tsmiEditProjectDelete});
            this.cmsEditProject.Name = "cmsEditUser";
            this.cmsEditProject.Size = new System.Drawing.Size(130, 48);
            // 
            // tsmiEditProjectEdit
            // 
            this.tsmiEditProjectEdit.Name = "tsmiEditProjectEdit";
            this.tsmiEditProjectEdit.Size = new System.Drawing.Size(129, 22);
            this.tsmiEditProjectEdit.Text = "Modifier";
            this.tsmiEditProjectEdit.Click += new System.EventHandler(this.tsmiEditProjectEdit_Click);
            // 
            // tsmiEditProjectDelete
            // 
            this.tsmiEditProjectDelete.Name = "tsmiEditProjectDelete";
            this.tsmiEditProjectDelete.Size = new System.Drawing.Size(129, 22);
            this.tsmiEditProjectDelete.Text = "Supprimer";
            this.tsmiEditProjectDelete.Click += new System.EventHandler(this.tsmiEditProjectDelete_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddProject.Location = new System.Drawing.Point(250, 720);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(80, 23);
            this.btnAddProject.TabIndex = 1;
            this.btnAddProject.Text = "&Ajouter";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.tsmiAddProjectAdd_Click);
            // 
            // btnUpdateProject
            // 
            this.btnUpdateProject.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdateProject.Enabled = false;
            this.btnUpdateProject.Location = new System.Drawing.Point(350, 720);
            this.btnUpdateProject.Name = "btnUpdateProject";
            this.btnUpdateProject.Size = new System.Drawing.Size(80, 23);
            this.btnUpdateProject.TabIndex = 2;
            this.btnUpdateProject.Text = "&Modifier";
            this.btnUpdateProject.UseVisualStyleBackColor = true;
            this.btnUpdateProject.Click += new System.EventHandler(this.tsmiEditProjectEdit_Click);
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteProject.Enabled = false;
            this.btnDeleteProject.Location = new System.Drawing.Point(450, 720);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(80, 23);
            this.btnDeleteProject.TabIndex = 3;
            this.btnDeleteProject.Text = "&Supprimer";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.tsmiEditProjectDelete_Click);
            // 
            // frmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.btnDeleteProject);
            this.Controls.Add(this.btnUpdateProject);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.dgvProjects);
            this.Location = new System.Drawing.Point(960, 0);
            this.MinimumSize = new System.Drawing.Size(800, 200);
            this.Name = "frmProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Projets";
            this.Load += new System.EventHandler(this.frmProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.cmsAddProject.ResumeLayout(false);
            this.cmsEditProject.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.ContextMenuStrip cmsAddProject;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddUserAdd;
        private System.Windows.Forms.ContextMenuStrip cmsEditProject;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditProjectEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditProjectDelete;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnUpdateProject;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectAssignees;
    }
}