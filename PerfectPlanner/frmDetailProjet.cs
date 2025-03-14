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
    public partial class frmDetailProjet: Form
    {
        public frmDetailProjet()
        {
            InitializeComponent();
        }

        public frmDetailProjet(Project project)
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
            
        }

        private void tsmiRemoveAdminRemove_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvAdminsAssigned.SelectedRows[0].Index;
            int selectedUserId = (int)dgvAdminsAssigned.Rows[selectedRowIndex].Cells["adminUserId"].Value;
            frmDetailProjet frmDetailProject = new frmDetailProjet();
            frmDetailProject.ShowDialog();
        }

        private void tsmiAddAdminAdd_Click(object sender, EventArgs e)
        {
            frmDetailProjet frmDetailProject = new frmDetailProjet();
            frmDetailProject.ShowDialog();
        }

        private void tsmiRemoveAssigneeRemove_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvUsersAssigned.SelectedRows[0].Index;
            int selectedUserId = (int)dgvUsersAssigned.Rows[selectedRowIndex].Cells["assigneeUserId"].Value;
            frmDetailProjet frmDetailProject = new frmDetailProjet();
            frmDetailProject.ShowDialog();
        }

        private void tsmiAddAssigneeAdd_Click(object sender, EventArgs e)
        {
            frmDetailProjet frmDetailProject = new frmDetailProjet();
            frmDetailProject.ShowDialog();
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
                    cmsRemoveAssignee.Show(dgvUsersAssigned, dgvUsersAssigned.PointToClient(Cursor.Position));
                }
                else
                {
                    cmsAddAssignee.Show(dgvUsersAssigned, dgvUsersAssigned.PointToClient(Cursor.Position));
                }
            }
        }
    }
}
