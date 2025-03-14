namespace PerfectPlanner
{
    partial class frmProjects
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
            this.projectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectAssignees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsAddProject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddUserAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditProject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditUserEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditUSerDelete = new System.Windows.Forms.ToolStripMenuItem();
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
            this.projectName,
            this.projectAdmin,
            this.projectAssignees});
            this.dgvProjects.Location = new System.Drawing.Point(12, 18);
            this.dgvProjects.MultiSelect = false;
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.Size = new System.Drawing.Size(760, 724);
            this.dgvProjects.TabIndex = 1;
            this.dgvProjects.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvProject_MouseDown);
            // 
            // projectName
            // 
            this.projectName.HeaderText = "Nom du projet";
            this.projectName.Name = "projectName";
            this.projectName.ReadOnly = true;
            this.projectName.Width = 200;
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
            this.projectAssignees.Width = 200;
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
            this.tsmiEditUserEdit,
            this.tsmiEditUSerDelete});
            this.cmsEditProject.Name = "cmsEditUser";
            this.cmsEditProject.Size = new System.Drawing.Size(181, 70);
            // 
            // tsmiEditUserEdit
            // 
            this.tsmiEditUserEdit.Name = "tsmiEditUserEdit";
            this.tsmiEditUserEdit.Size = new System.Drawing.Size(180, 22);
            this.tsmiEditUserEdit.Text = "Modifier";
            this.tsmiEditUserEdit.Click += new System.EventHandler(this.tsmiEditProjectEdit_Click);
            // 
            // tsmiEditUSerDelete
            // 
            this.tsmiEditUSerDelete.Name = "tsmiEditUSerDelete";
            this.tsmiEditUSerDelete.Size = new System.Drawing.Size(129, 22);
            this.tsmiEditUSerDelete.Text = "Supprimer";
            // 
            // frmProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.dgvProjects);
            this.Location = new System.Drawing.Point(960, 0);
            this.MinimumSize = new System.Drawing.Size(800, 200);
            this.Name = "frmProjects";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn projectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectAssignees;
        private System.Windows.Forms.ContextMenuStrip cmsAddProject;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddUserAdd;
        private System.Windows.Forms.ContextMenuStrip cmsEditProject;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditUserEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditUSerDelete;
    }
}