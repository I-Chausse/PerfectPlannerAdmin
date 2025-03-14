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
    public partial class frmDetailUser: Form
    {
        User currentUser;
        public frmDetailUser()
        {
            InitializeComponent();
            btnSave.Text = "Ajouter";
            grpUsersAssigned.Visible = false;

        }

        public frmDetailUser(User user)
        {
            InitializeComponent();
            txtUserName.Text = user.UserName;
            txtPersonName.Text = user.LastName;
            txtPersonFirstName.Text = user.FirstName;
            txtPersonMail.Text = user.Email;
            cmbUserRole.Text = user.Role;
            if (cmbUserRole.SelectedIndex == 0)
            {
                grpUsersAssigned.Visible = false;
            }
            foreach (var item in user.UsersAssigned)
            {
                dgvUsersAssigned.Rows.Add(item.Id, item.LastName, item.FirstName);
            }
            currentUser = user;
        }

        private void cmbUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUserRole.SelectedIndex == 0)
            {
                grpUsersAssigned.Visible = false;
            }
            else
            {
                grpUsersAssigned.Visible = true;
            }
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
    }
}
