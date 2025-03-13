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
            this.grpUserDetail = new System.Windows.Forms.GroupBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.grpUsersAssigned = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.txtPersonFirstName = new System.Windows.Forms.TextBox();
            this.txtPersonMail = new System.Windows.Forms.TextBox();
            this.lblPersonMail = new System.Windows.Forms.Label();
            this.picPersonAvatar = new System.Windows.Forms.PictureBox();
            this.lblPersonAvatar = new System.Windows.Forms.Label();
            this.btnDeletePersonAvatar = new System.Windows.Forms.Button();
            this.lblPersonFirstName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpUserDetail.SuspendLayout();
            this.grpUsersAssigned.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpUserDetail
            // 
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
            this.grpUserDetail.Size = new System.Drawing.Size(235, 303);
            this.grpUserDetail.TabIndex = 0;
            this.grpUserDetail.TabStop = false;
            this.grpUserDetail.Text = "Détail de l\'utilisateur";
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
            this.grpUsersAssigned.Controls.Add(this.dataGridView1);
            this.grpUsersAssigned.Location = new System.Drawing.Point(287, 12);
            this.grpUsersAssigned.Name = "grpUsersAssigned";
            this.grpUsersAssigned.Size = new System.Drawing.Size(365, 303);
            this.grpUsersAssigned.TabIndex = 1;
            this.grpUsersAssigned.TabStop = false;
            this.grpUsersAssigned.Text = "Utilisateurs assignés";
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
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(96, 54);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(133, 20);
            this.txtPersonName.TabIndex = 2;
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
            // txtPersonFirstName
            // 
            this.txtPersonFirstName.Location = new System.Drawing.Point(96, 80);
            this.txtPersonFirstName.Name = "txtPersonFirstName";
            this.txtPersonFirstName.Size = new System.Drawing.Size(133, 20);
            this.txtPersonFirstName.TabIndex = 4;
            // 
            // txtPersonMail
            // 
            this.txtPersonMail.Location = new System.Drawing.Point(96, 106);
            this.txtPersonMail.Name = "txtPersonMail";
            this.txtPersonMail.Size = new System.Drawing.Size(133, 20);
            this.txtPersonMail.TabIndex = 6;
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
            // picPersonAvatar
            // 
            this.picPersonAvatar.Location = new System.Drawing.Point(96, 133);
            this.picPersonAvatar.Name = "picPersonAvatar";
            this.picPersonAvatar.Size = new System.Drawing.Size(133, 130);
            this.picPersonAvatar.TabIndex = 8;
            this.picPersonAvatar.TabStop = false;
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
            // btnDeletePersonAvatar
            // 
            this.btnDeletePersonAvatar.Location = new System.Drawing.Point(123, 269);
            this.btnDeletePersonAvatar.Name = "btnDeletePersonAvatar";
            this.btnDeletePersonAvatar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePersonAvatar.TabIndex = 10;
            this.btnDeletePersonAvatar.Text = "Supprimer";
            this.btnDeletePersonAvatar.UseVisualStyleBackColor = true;
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
            this.grpUsersAssigned.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUserDetail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox grpUsersAssigned;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}