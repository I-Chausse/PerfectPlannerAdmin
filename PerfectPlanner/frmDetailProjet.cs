using System;
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
    public partial class frmDetailProjet: Form, IUserAssignable
    {
        DataGridView currentDGV = null;
        frmProjects frmProjects = null;
        bool isEditMode = false;
        int projectId = 0;
        public frmDetailProjet(frmProjects frmProjects)
        {
            InitializeComponent();
            this.frmProjects = frmProjects;
            btnSave.Text = "Ajouter";
        }

        public frmDetailProjet(frmProjects frmProjects, Project project)
        {
            InitializeComponent();
            txtProjectName.Text = project.Name;
            project.Admins.ForEach(admin =>
            {
                dgvAdminsAssigned.Rows.Add(admin.Id, admin.LastName, admin.FirstName);
            });
            project.Assignees.ForEach(assignee =>
            {
                dgvUsersAssigned.Rows.Add(assignee.Id, assignee.LastName, assignee.FirstName);
            });
            this.frmProjects = frmProjects;
            isEditMode = true;
            projectId = project.Id;
        }

        private void tsmiRemoveAdminRemove_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvAdminsAssigned.SelectedRows[0].Index;
            int selectedUserId = (int)dgvAdminsAssigned.Rows[selectedRowIndex].Cells["adminUserId"].Value;
            currentDGV = dgvAdminsAssigned;
            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Supprimer un utilisateur", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.RemoveUser();
            }
        }

        private void tsmiAddAdminAdd_Click(object sender, EventArgs e)
        {
            currentDGV = dgvAdminsAssigned;
            frmUserSelection frmUserSelection = new frmUserSelection(this);
            frmUserSelection.ShowDialog();
        }

        private void tsmiRemoveAssigneeRemove_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvUsersAssigned.SelectedRows[0].Index;
            int selectedUserId = (int)dgvUsersAssigned.Rows[selectedRowIndex].Cells["assigneeUserId"].Value;
            currentDGV = dgvUsersAssigned;
            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Supprimer un utilisateur", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.RemoveUser();
            }
        }

        private void tsmiAddAssigneeAdd_Click(object sender, EventArgs e)
        {
            currentDGV = dgvUsersAssigned;
            frmUserSelection frmUserSelection = new frmUserSelection(this);
            frmUserSelection.ShowDialog();
        }

        private void dgvUsersAssigned_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var row = dgvUsersAssigned.HitTest(e.X, e.Y);
                if (row.RowIndex >= 0)
                {
                    dgvUsersAssigned.ClearSelection();
                    dgvUsersAssigned.Rows[row.RowIndex].Selected = true;
                    cmsRemoveAssignee.Show(dgvUsersAssigned, dgvUsersAssigned.PointToClient(Cursor.Position));
                }
                else
                {
                    cmsAddAssignee.Show(dgvUsersAssigned, dgvUsersAssigned.PointToClient(Cursor.Position));
                }
            }
        }

        private void dgvAdminsAssigned_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var row = dgvAdminsAssigned.HitTest(e.X, e.Y);
                if (row.RowIndex >= 0)
                {
                    dgvAdminsAssigned.ClearSelection();
                    dgvAdminsAssigned.Rows[row.RowIndex].Selected = true;
                    cmsRemoveAdmin.Show(dgvUsersAssigned, dgvUsersAssigned.PointToClient(Cursor.Position));
                }
                else
                {
                    cmsAddAdmin.Show(dgvUsersAssigned, dgvUsersAssigned.PointToClient(Cursor.Position));
                }
            }
        }

        public void AddUser(User user)
        {
            currentDGV.Rows.Add(user.Id, user.LastName, user.FirstName);
        }
        public void RemoveUser()
        {
            currentDGV.Rows.Remove(currentDGV.SelectedRows[0]);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Project project = new Project(projectId, txtProjectName.Text);
            List<User> admins = new List<User>();
            List<User> assignees = new List<User>();
            foreach (DataGridViewRow row in dgvAdminsAssigned.Rows)
            {
                foreach (User user in DataProvider.getUsers())
                {
                    if (user.Id == (int)row.Cells["adminUserId"].Value)
                    {
                        admins.Add(user);
                    }
                }
            }
            foreach (DataGridViewRow row in dgvUsersAssigned.Rows)
            {
                foreach (User user in DataProvider.getUsers())
                {
                    if (user.Id == (int)row.Cells["assigneeUserId"].Value)
                    {
                        assignees.Add(user);
                    }
                }
            }
            project.Admins = admins;
            project.Assignees = assignees;
            if (this.isEditMode)
            {
                this.frmProjects.updateProject(project);
                this.Close();
            }
            else
            {
                this.frmProjects.addProject(project);
                this.Close();
            }
        }
    }
}
