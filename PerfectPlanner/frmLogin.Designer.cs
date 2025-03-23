namespace PerfectPlanner
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUserPass = new System.Windows.Forms.Label();
            this.lbluserName = new System.Windows.Forms.Label();
            this.mtxUserPass = new System.Windows.Forms.MaskedTextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.lblUserPass);
            this.grpLogin.Controls.Add(this.lbluserName);
            this.grpLogin.Controls.Add(this.mtxUserPass);
            this.grpLogin.Controls.Add(this.txtUserName);
            this.grpLogin.Location = new System.Drawing.Point(60, 30);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(360, 200);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(140, 140);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(80, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.OnClickOnBtnLogin);
            // 
            // lblUserPass
            // 
            this.lblUserPass.AutoSize = true;
            this.lblUserPass.Location = new System.Drawing.Point(7, 104);
            this.lblUserPass.Name = "lblUserPass";
            this.lblUserPass.Size = new System.Drawing.Size(71, 13);
            this.lblUserPass.TabIndex = 3;
            this.lblUserPass.Text = "&Mot de passe";
            // 
            // lbluserName
            // 
            this.lbluserName.AutoSize = true;
            this.lbluserName.Location = new System.Drawing.Point(7, 64);
            this.lbluserName.Name = "lbluserName";
            this.lbluserName.Size = new System.Drawing.Size(84, 13);
            this.lbluserName.TabIndex = 1;
            this.lbluserName.Text = "&Nom d\'utilisateur";
            // 
            // mtxUserPass
            // 
            this.mtxUserPass.HidePromptOnLeave = true;
            this.mtxUserPass.Location = new System.Drawing.Point(100, 100);
            this.mtxUserPass.Name = "mtxUserPass";
            this.mtxUserPass.PasswordChar = '*';
            this.mtxUserPass.Size = new System.Drawing.Size(234, 20);
            this.mtxUserPass.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(100, 60);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(234, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.grpLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUserPass;
        private System.Windows.Forms.Label lbluserName;
        private System.Windows.Forms.MaskedTextBox mtxUserPass;
        private System.Windows.Forms.TextBox txtUserName;
    }
}