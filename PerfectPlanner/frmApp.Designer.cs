namespace PerfectPlanner
{
    partial class frmApp
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnsMainStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMainStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMainStrip
            // 
            this.mnsMainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUser,
            this.tsmiProjects});
            this.mnsMainStrip.Location = new System.Drawing.Point(0, 0);
            this.mnsMainStrip.Name = "mnsMainStrip";
            this.mnsMainStrip.Size = new System.Drawing.Size(800, 24);
            this.mnsMainStrip.TabIndex = 1;
            this.mnsMainStrip.Text = "mns";
            // 
            // tsmiUser
            // 
            this.tsmiUser.Name = "tsmiUser";
            this.tsmiUser.Size = new System.Drawing.Size(140, 20);
            this.tsmiUser.Text = "Gestion des utilisateurs";
            this.tsmiUser.Click += new System.EventHandler(this.tsmiUser_Click);
            // 
            // tsmiProjects
            // 
            this.tsmiProjects.Name = "tsmiProjects";
            this.tsmiProjects.Size = new System.Drawing.Size(119, 20);
            this.tsmiProjects.Text = "Gestion des projets";
            // 
            // frmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnsMainStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMainStrip;
            this.Name = "frmApp";
            this.Text = "Perfect Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnsMainStrip.ResumeLayout(false);
            this.mnsMainStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMainStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiProjects;
    }
}

