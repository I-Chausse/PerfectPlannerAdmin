﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectPlanner
{
    public partial class frmProjects: Form
    {
        private List<Project> projects = new List<Project>();
        public frmProjects()
        {
            InitializeComponent();
        }

        private void frmProjects_Load(object sender, EventArgs e)
        {
            projects.Add(new Project(1, "Projet 1"));
            projects.Add(new Project(2, "Projet 2"));
            projects[0].AddAdmin(new User(1, "JDupond", "admin", "j-dupond@perfect-planner.com", "Jean", "Dupond", "avatar", "Gestionnaire"));
            projects[0].AddAssignee(new User(2, "JMartin", "admin", "j-martin@matrin.ch", "Jean", "Martin", "avatar", "Utilisateur"));
            projects[0].AddAdmin(new User(3, "JLeclerc", "admin", "j-leclerc@moulin.ch", "Jean", "Leclerc", "avatar", "Utilisateur"));

            projects.ForEach(project =>
            {
                String admins = "";
                String assignees = "";
                foreach (var admin in project.Admins)
                {
                    admins += admin.UserName + ", ";
                }
                foreach (var assignee in project.Assignees)
                {
                    assignees += assignee.UserName + ", ";
                }
                dgvProjects.Rows.Add(project.Name, admins, assignees);
            });
        }

        private void dgvProject_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var row = dgvProjects.HitTest(e.X, e.Y);
                if (row.RowIndex >= 0)
                {
                    dgvProjects.ClearSelection();
                    dgvProjects.Rows[row.RowIndex].Selected = true;
                    cmsEditProject.Show(dgvProjects, dgvProjects.PointToClient(Cursor.Position));
                }
                else
                {
                    cmsAddProject.Show(dgvProjects, dgvProjects.PointToClient(Cursor.Position));
                }
            }
        }

        private void tsmiEditProjectEdit_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvProjects.SelectedRows[0].Index;
            string selectedProjetName = (string)dgvProjects.Rows[selectedRowIndex].Cells["projectName"].Value;
            frmDetailProjet frmDetailProject = new frmDetailProjet(projects.Find((projet) => projet.Name == selectedProjetName));
            frmDetailProject.ShowDialog();
        }

        private void tsmiAddProjectAdd_Click(object sender, EventArgs e)
        {
            frmDetailProjet frmDetailProject = new frmDetailProjet();
            frmDetailProject.ShowDialog();
        }
    }
}
