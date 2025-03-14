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
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.projectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectAssignees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProjects
            // 
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
            this.dgvProjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjects_CellContentClick);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectAssignees;
    }
}