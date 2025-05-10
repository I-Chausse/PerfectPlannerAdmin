namespace PerfectPlanner
{
    partial class frmCreateToken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateToken));
            this.cmbSelectRole = new System.Windows.Forms.ComboBox();
            this.btnCreateToken = new System.Windows.Forms.Button();
            this.grpGenerateCode = new System.Windows.Forms.GroupBox();
            this.txtGeneratedCode = new System.Windows.Forms.TextBox();
            this.lblGeneratedCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbSelectRole
            // 
            this.cmbSelectRole.DisplayMember = "label";
            this.cmbSelectRole.FormattingEnabled = true;
            this.cmbSelectRole.Location = new System.Drawing.Point(114, 53);
            this.cmbSelectRole.Name = "cmbSelectRole";
            this.cmbSelectRole.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectRole.TabIndex = 0;
            this.cmbSelectRole.ValueMember = "id";
            // 
            // btnCreateToken
            // 
            this.btnCreateToken.Location = new System.Drawing.Point(137, 102);
            this.btnCreateToken.Name = "btnCreateToken";
            this.btnCreateToken.Size = new System.Drawing.Size(75, 23);
            this.btnCreateToken.TabIndex = 1;
            this.btnCreateToken.Text = "Générer";
            this.btnCreateToken.UseVisualStyleBackColor = true;
            this.btnCreateToken.Click += new System.EventHandler(this.btnCreateToken_Click);
            // 
            // grpGenerateCode
            // 
            this.grpGenerateCode.Location = new System.Drawing.Point(75, 23);
            this.grpGenerateCode.Name = "grpGenerateCode";
            this.grpGenerateCode.Size = new System.Drawing.Size(200, 120);
            this.grpGenerateCode.TabIndex = 2;
            this.grpGenerateCode.TabStop = false;
            this.grpGenerateCode.Text = "Générer un code";
            // 
            // txtGeneratedCode
            // 
            this.txtGeneratedCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtGeneratedCode.Enabled = false;
            this.txtGeneratedCode.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtGeneratedCode.Location = new System.Drawing.Point(124, 181);
            this.txtGeneratedCode.Name = "txtGeneratedCode";
            this.txtGeneratedCode.Size = new System.Drawing.Size(100, 20);
            this.txtGeneratedCode.TabIndex = 3;
            this.txtGeneratedCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGeneratedCode
            // 
            this.lblGeneratedCode.AutoSize = true;
            this.lblGeneratedCode.Location = new System.Drawing.Point(140, 165);
            this.lblGeneratedCode.Name = "lblGeneratedCode";
            this.lblGeneratedCode.Size = new System.Drawing.Size(68, 13);
            this.lblGeneratedCode.TabIndex = 4;
            this.lblGeneratedCode.Text = "Code généré";
            // 
            // frmCreateToken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.lblGeneratedCode);
            this.Controls.Add(this.txtGeneratedCode);
            this.Controls.Add(this.btnCreateToken);
            this.Controls.Add(this.cmbSelectRole);
            this.Controls.Add(this.grpGenerateCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreateToken";
            this.Text = "Créer un code utilisateur";
            this.Load += new System.EventHandler(this.frmCreateToken_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelectRole;
        private System.Windows.Forms.Button btnCreateToken;
        private System.Windows.Forms.GroupBox grpGenerateCode;
        private System.Windows.Forms.TextBox txtGeneratedCode;
        private System.Windows.Forms.Label lblGeneratedCode;
    }
}