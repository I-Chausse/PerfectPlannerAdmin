﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectPlanner
{
    public partial class frmProject: Form
    {
        private List<Project> projects = new List<Project>();
        public frmProject()
        {
            InitializeComponent();
        }

        private void OnLoadOfFrmProjects(object sender, EventArgs e)
        {

            projects = DataProvider.GetProjects();
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
                dgvProjects.Rows.Add(project.Id, project.Name, admins, assignees);
            });
            if (Program.AppContext.IsAdvancedMode())
            {
                btnAddProject.Visible = false;
                btnUpdateProject.Visible = false;
                btnDeleteProject.Visible = false;
                dgvProjects.Height = 720;
            }
        }

        private void OnMouseDownOnDgvProject(object sender, MouseEventArgs e)
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

        private void OnClickOnTsmiEditProjectEdit(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvProjects.SelectedRows[0].Index;
            int selectedProjetId = (int)dgvProjects.Rows[selectedRowIndex].Cells["projectid"].Value;
            frmDetailProjet frmDetailProject = new frmDetailProjet(this, projects.Find((projet) => projet.Id == selectedProjetId));
            frmDetailProject.ShowDialog();
        }

        private void OnClickOnTsmiAddProjectAdd(object sender, EventArgs e)
        {
            frmDetailProjet frmDetailProject = new frmDetailProjet(this);
            frmDetailProject.ShowDialog();
        }

        public void AddProject(Project project)
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
            dgvProjects.Rows.Add(project.Id, project.Name, admins, assignees);
        }

        public void UpdateProject(Project project)
        {
            int selectedRowIndex = dgvProjects.SelectedRows[0].Index;
            dgvProjects.Rows[selectedRowIndex].Cells["projectName"].Value = project.Name;
            dgvProjects.Rows[selectedRowIndex].Cells["projectAdmin"].Value = "";
            dgvProjects.Rows[selectedRowIndex].Cells["projectAssignees"].Value = "";
            foreach (var admin in project.Admins)
            {
                dgvProjects.Rows[selectedRowIndex].Cells["projectAdmin"].Value += admin.UserName + ", ";
            }
            foreach (var assignee in project.Assignees)
            {
                dgvProjects.Rows[selectedRowIndex].Cells["projectAssignees"].Value += assignee.UserName + ", ";
            }
        }

        public void SupprimerProject()
        {
            int selectedRowIndex = dgvProjects.SelectedRows[0].Index;
            dgvProjects.Rows.RemoveAt(selectedRowIndex);
        }

        private void OnClickOnTsmiEditProjectDelete(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer ce projet ?", "Supprimer un projet", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.SupprimerProject();
            }
        }

        private void HandleEditAndDeleteBtnState(Object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                btnUpdateProject.Enabled = true;
                btnDeleteProject.Enabled = true;
            }
            else
            {
                btnUpdateProject.Enabled = false;
                btnDeleteProject.Enabled = false;
            }
        }

        private void SelectionCompleteRowOnCellClick(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvProjects.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
