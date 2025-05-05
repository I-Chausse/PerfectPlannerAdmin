using PerfectPlanner.Models.Users;
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
        private readonly frmUser frmUser;
        private readonly bool isEditMode = false;
        private readonly int userId = 0;
        public frmDetailUser(frmUser frmParent)
        {
            InitializeComponent();
            btnSave.Text = "Ajouter";
            grpUsersAssigned.Visible = false;
            this.Width = 310;
            this.frmUser = frmParent;
            cmbUserRole.SelectedIndex = 0;
            btnSave.Text = "Ajouter";
        }

        public frmDetailUser(frmUser frmParent, User user)
        {
            InitializeComponent();
            txtUserName.Text = user.user_name;
            txtPersonName.Text = user.name;
            txtPersonFirstName.Text = user.first_name;
            txtPersonMail.Text = user.email;
            cmbUserRole.Text = user.role.label;
            picPersonAvatar.ImageLocation = user.avatar.link;
            if (cmbUserRole.SelectedIndex == 0)
            {
                grpUsersAssigned.Visible = false;
                this.Width = 310;
            }
            foreach (var item in user.assignees)
            {
                dgvUsersAssigned.Rows.Add(item.id, item.name, item.first_name);
            }
            this.frmUser = frmParent;
            this.userId = user.id;
            this.isEditMode = true;

        }

        private void OnSlectedIndexChangeOfCmbUserRole(object sender, EventArgs e)
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

        private void OnClickOnTsmiRemoveAssigneeRemove(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Supprimer un utilisateur", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.RemoveUser();
            }
        }

        private void OnClickOnTsmiAddAssigneeAdd(object sender, EventArgs e)
        {
            List<User> usersAssignables = new List<User>();
            frmUserSelection frmUserSelection = new frmUserSelection(this, usersAssignables);
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

        public void AddUser(User user)
        {
            //dgvUsersAssigned.Rows.Add(user.Id, user.LastName, user.FirstName);
        }

        public void RemoveUser()
        {
            dgvUsersAssigned.Rows.Remove(dgvUsersAssigned.SelectedRows[0]);
        }

        private void OnClickOnBtnCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnClickOnBtnSave(object sender, EventArgs e)
        {
            User user = new User();
            //User user = new User(userId, txtUserName.Text, mtxUserPassword.Text, txtPersonMail.Text, txtPersonFirstName.Text, txtPersonName.Text, picPersonAvatar.ImageLocation, cmbUserRole.Text);
            List<User> usersAssigned = new List<User>();
            foreach (DataGridViewRow row in dgvUsersAssigned.Rows)
            {
                //usersAssigned.Add(DataProvider.GetUsers().Find((assignee) => assignee.id ==(int) row.Cells["assigneeUserId"].Value));
            }
            //user.UsersAssigned = usersAssigned;
            if (this.isEditMode)
            {
                this.frmUser.UpdateUser(user);
            }
            else
            {
                this.frmUser.AddUser(user);
            }
            this.Close();
        }

        private void OnClickOnBtnDeletePersonAvatar(object sender, EventArgs e)
        {
            this.picPersonAvatar.Image = null;
        }

        private void HandleDeleteBtnState(Object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                btnDeleteAssignee.Enabled = true;
            }
            else
            {
                btnDeleteAssignee.Enabled = false;
            }
        }

        private void SelectionCompleteRowOnCellClick(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvUsersAssigned.Rows[e.RowIndex].Selected = true;
            }
        }

        private void OnLoadOfFrmDetailUser(object sender, EventArgs e)
        {
            if (Program.AppContext.IsAdvancedMode())
            {
                btnAddAssignee.Visible = false;
                btnDeleteAssignee.Visible = false;
                grpUsersAssigned.Height = 260;
            }
        }
    }
}
