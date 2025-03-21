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
    public partial class frmDetailUser : Form, IUserAssignable
    {
        frmUser frmUser;
        bool isEditMode = false;
        int userId = 0;
        public frmDetailUser(frmUser frmParent)
        {
            InitializeComponent();
            btnSave.Text = "Ajouter";
            grpUsersAssigned.Visible = false;
            this.Width = 310;
            this.frmUser = frmParent;
            btnSave.Text = "Ajouter";
        }

        public frmDetailUser(frmUser frmParent, User user)
        {
            InitializeComponent();
            txtUserName.Text = user.UserName;
            txtPersonName.Text = user.LastName;
            txtPersonFirstName.Text = user.FirstName;
            txtPersonMail.Text = user.Email;
            cmbUserRole.Text = user.Role;
            picPersonAvatar.ImageLocation = user.Avatar;
            if (cmbUserRole.SelectedIndex == 0)
            {
                grpUsersAssigned.Visible = false;
                this.Width = 310;
            }
            foreach (var item in user.UsersAssigned)
            {
                dgvUsersAssigned.Rows.Add(item.Id, item.LastName, item.FirstName);
            }
            this.frmUser = frmParent;
            this.userId = user.Id;
            this.isEditMode = true;

        }

        private void cmbUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUserRole.SelectedIndex == 0)
            {
                grpUsersAssigned.Visible = false;
                this.Width = 310;
            }
            else
            {
                grpUsersAssigned.Visible = true;
                this.Width = 600;
            }
        }

        private void tsmiRemoveAssigneeRemove_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvUsersAssigned.SelectedRows[0].Index;
            int selectedUserId = (int)dgvUsersAssigned.Rows[selectedRowIndex].Cells["assigneeUserId"].Value;
            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Supprimer un utilisateur", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.RemoveUser();
            }
        }

        private void tsmiAddAssigneeAdd_Click(object sender, EventArgs e)
        {
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

        public void AddUser(User user)
        {
            dgvUsersAssigned.Rows.Add(user.Id, user.LastName, user.FirstName);
        }

        public void RemoveUser()
        {
            dgvUsersAssigned.Rows.Remove(dgvUsersAssigned.SelectedRows[0]);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User(userId, txtUserName.Text, mtxUserPassword.Text, txtPersonMail.Text, txtPersonFirstName.Text, txtPersonName.Text, picPersonAvatar.ImageLocation, cmbUserRole.Text);
            List<User> usersAssigned = new List<User>();
            foreach (DataGridViewRow row in dgvUsersAssigned.Rows)
            {
                usersAssigned.Add(DataProvider.getUsers().Find((assignee) => assignee.Id ==(int) row.Cells["assigneeUserId"].Value));
            }
            user.UsersAssigned = usersAssigned;
            if (this.isEditMode)
            {
                this.frmUser.updateUser(user);
            }
            else
            {
                this.frmUser.AddUser(user);
            }
            this.Close();
        }

        private void btnDeletePersonAvatar_Click(object sender, EventArgs e)
        {
            this.picPersonAvatar.Image = null;
        }
    }
}
