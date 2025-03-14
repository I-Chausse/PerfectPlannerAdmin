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
            this.grpAdminsAssigned = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpProjectDetail = new System.Windows.Forms.GroupBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpAdminsAssigned.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpProjectDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAdminsAssigned
            // 
            this.grpAdminsAssigned.Controls.Add(this.dataGridView1);
            this.grpAdminsAssigned.Location = new System.Drawing.Point(287, 12);
            this.grpAdminsAssigned.Name = "grpAdminsAssigned";
            this.grpAdminsAssigned.Size = new System.Drawing.Size(365, 303);
            this.grpAdminsAssigned.TabIndex = 3;
            this.grpAdminsAssigned.TabStop = false;
            this.grpAdminsAssigned.Text = "Gestionnaires assignés";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.userFirstName});
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(352, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // userName
            // 
            this.userName.HeaderText = "Nom";
            this.userName.Name = "userName";
            // 
            // userFirstName
            // 
            this.userFirstName.HeaderText = "Prénom";
            this.userFirstName.Name = "userFirstName";
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
            // frmDetailProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpAdminsAssigned);
            this.Controls.Add(this.grpProjectDetail);
            this.Name = "frmDetailProjet";
            this.Text = "frmDetailProjet";
            this.grpAdminsAssigned.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpProjectDetail.ResumeLayout(false);
            this.grpProjectDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdminsAssigned;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFirstName;
        private System.Windows.Forms.GroupBox grpProjectDetail;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}