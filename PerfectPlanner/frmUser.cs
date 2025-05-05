using PerfectPlanner.Models.Users;
using System;
using System.Collections;
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
    
    public partial class frmUser: Form
    {

        List<User> users;
        public frmUser()
        {
            InitializeComponent();
        }

        private void OnLoadOfFrmUser(object sender, EventArgs e)
        {
            //users = DataProvider.GetUsers();
            
            if (Program.AppContext.IsAdvancedMode())
            {
                btnAddUser.Visible = false;
                btnUpdateUser.Visible = false;
                btnDeleteUser.Visible = false;
                dgvUser.Height = 720;
            }

        }

        private void OnMouseDownOnDgvUser(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var row = dgvUser.HitTest(e.X, e.Y);
                if (row.RowIndex >= 0)
                {
                    dgvUser.ClearSelection();
                    dgvUser.Rows[row.RowIndex].Selected = true;
                    cmsEditUser.Show(dgvUser, dgvUser.PointToClient(Cursor.Position));
                }
                else 
                {
                    cmsAddUser.Show(dgvUser, dgvUser.PointToClient(Cursor.Position));
                }
            }
        }

        private void OnClickOnTsmiEditUserEdit(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvUser.SelectedRows[0].Index;
            int selectedUserId = (int) dgvUser.Rows[selectedRowIndex].Cells["userId"].Value;
            frmDetailUser frmDetailUser = new frmDetailUser(this, users.Find((user) => user.id == selectedUserId));
            frmDetailUser.ShowDialog();
        }

        private void OnClickOnTsmiAddUserAdd(object sender, EventArgs e)
        {
            frmDetailUser frmDetailUser = new frmDetailUser(this);
            frmDetailUser.ShowDialog();
        }

        public void AddUser(User user)
        {
            //dgvUser.Rows.Add(user.Id, user.UserName, user.LastName, user.FirstName, user.Email, user.Role);
        }

        public void UpdateUser(User user)
        {
            int selectedRowIndex = dgvUser.SelectedRows[0].Index;
            
        }

        public void RemoveUser()
        {
            int selectedRowIndex = dgvUser.SelectedRows[0].Index;
            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Supprimer un utilisateur", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dgvUser.Rows.RemoveAt(selectedRowIndex);
            }
        }

        private void HandleEditAndDeleteBtnState(Object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                btnUpdateUser.Enabled = true;
                btnDeleteUser.Enabled = true;
            }
            else
            {
                btnUpdateUser.Enabled = false;
                btnDeleteUser.Enabled = false;
            }
        }

        private void SelectionCompleteRowOnCellClick(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvUser.Rows[e.RowIndex].Selected = true;
            }
        }

        private void OnClickOnTsmiEditUserDelete(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                RemoveUser();
            }
        }
    }
}
