using System;
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

        private void frmProjects_Load(object sender, EventArgs e)
        {

            projects = DataProvider.getProjects();
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
            int selectedProjetId = (int)dgvProjects.Rows[selectedRowIndex].Cells["projectid"].Value;
            frmDetailProjet frmDetailProject = new frmDetailProjet(this, projects.Find((projet) => projet.Id == selectedProjetId));
            frmDetailProject.ShowDialog();
        }

        private void tsmiAddProjectAdd_Click(object sender, EventArgs e)
        {
            frmDetailProjet frmDetailProject = new frmDetailProjet(this);
            frmDetailProject.ShowDialog();
        }

        public void addProject(Project project)
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

        public void updateProject(Project project)
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

        public void supprimerProject()
        {
            int selectedRowIndex = dgvProjects.SelectedRows[0].Index;
            int selectedProjectId = (int)dgvProjects.Rows[selectedRowIndex].Cells["projectid"].Value;
            dgvProjects.Rows.RemoveAt(selectedRowIndex);
        }

        private void tsmiEditProjectDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer ce projet ?", "Supprimer un projet", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.supprimerProject();
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
