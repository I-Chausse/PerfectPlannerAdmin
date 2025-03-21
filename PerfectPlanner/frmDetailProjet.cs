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
        private DataGridView currentDGV = null;
        private readonly frmProject frmProjects = null;
        private readonly bool isEditMode = false;
        private readonly int projectId;
        public frmDetailProjet(frmProject frmProjects)
        {
            InitializeComponent();
            this.frmProjects = frmProjects;
            btnSave.Text = "Ajouter";
        }

        public frmDetailProjet(frmProject frmProjects, Project project)
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

        private void OnClickOnTsmiRemoveAdminRemove(object sender, EventArgs e)
        {
            currentDGV = dgvAdminsAssigned;
            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Supprimer un utilisateur", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.RemoveUser();
            }
        }

        private void OnClickOnTsmiAddAdminAdd(object sender, EventArgs e)
        {
            currentDGV = dgvAdminsAssigned;
            frmUserSelection frmUserSelection = new frmUserSelection(this);
            frmUserSelection.ShowDialog();
        }

        private void OnClickOnTsmiRemoveAssigneeRemove(object sender, EventArgs e)
        {
            currentDGV = dgvUsersAssigned;
            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Supprimer un utilisateur", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.RemoveUser();
            }
        }

        private void OnCLickOnTsmiAddAssigneeAdd(object sender, EventArgs e)
        {
            currentDGV = dgvUsersAssigned;
            frmUserSelection frmUserSelection = new frmUserSelection(this);
            frmUserSelection.ShowDialog();
        }

        private void OnMouseDownOnDgvUsersAssigned(object sender, MouseEventArgs e)
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

        private void OnMouseDownOnDgvAdminsAssigned(object sender, MouseEventArgs e)
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

        private void OnClickOnBtnCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnClickOnBtnSave(object sender, EventArgs e)
        {
            Project project = new Project(projectId, txtProjectName.Text);
            List<User> admins = new List<User>();
            List<User> assignees = new List<User>();
            if (dgvAdminsAssigned.Rows.Count > 0) {
                foreach (DataGridViewRow row in dgvAdminsAssigned.Rows)
                {
                    foreach (User user in DataProvider.GetUsers())
                    {
                        if (user.Id == (int)row.Cells["adminUserId"].Value)
                        {
                            admins.Add(user);
                        }
                    }
                }
            }
            if (dgvUsersAssigned.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvUsersAssigned.Rows)
                {
                    foreach (User user in DataProvider.GetUsers())
                    {
                        if (user.Id == (int)row.Cells["assigneeUserId"].Value)
                        {
                            assignees.Add(user);
                        }
                    }
                }
            }
            project.Admins = admins;
            project.Assignees = assignees;
            if (this.isEditMode)
            {
                this.frmProjects.UpdateProject(project); 
            }
            else
            {
                this.frmProjects.AddProject(project);
            }
            this.Close();
        }

        private void HandleDeleteBtnState(Object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                if (sender == dgvAdminsAssigned)
                {
                    btnDeleteAdmin.Enabled = true;
                }
                else if (sender == dgvUsersAssigned)
                {
                    btnRemoveAssignee.Enabled = true;
                }
            }
            else
            {
                if (sender == dgvAdminsAssigned)
                {
                    btnDeleteAdmin.Enabled = false;
                }
                else if (sender == dgvUsersAssigned)
                {
                    btnRemoveAssignee.Enabled = false;
                }
            }
        }

        private void SelectionCompleteRowOnCellClick(Object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (e.RowIndex >= 0)
            {
                dgv.Rows[e.RowIndex].Selected = true;
            }
        }

        private void OnLoadOfFrmDetailProjet(object sender, EventArgs e)
        {
            if (Program.AppContext.IsAdvancedMode())
            {
                btnAddAdmin.Visible = false;
                btnAddAssignee.Visible = false;
                btnDeleteAdmin.Visible = false;
                btnRemoveAssignee.Visible = false;
                grpAdminsAssigned.Height = 260;
                grpUsersAssigned.Height = 260;
            }
        }
    }
}
