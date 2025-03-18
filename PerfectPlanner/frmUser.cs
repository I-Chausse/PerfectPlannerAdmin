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

        private void frmUser_Load(object sender, EventArgs e)
        {
            users = DataProvider.getUsers();
            foreach (var item in users)
            {
                String usersAssigned = "";
                foreach (var user in item.UsersAssigned)
                {
                    usersAssigned += user.UserName + ", ";
                }
                dgvUser.Rows.Add(item.Id, item.UserName, item.LastName, item.FirstName, item.Email, item.Role, usersAssigned);

            }

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dgvUser_MouseDown(object sender, MouseEventArgs e)
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

        private void tsmiEditUserEdit_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvUser.SelectedRows[0].Index;
            int selectedUserId = (int) dgvUser.Rows[selectedRowIndex].Cells["userId"].Value;
            frmDetailUser frmDetailUser = new frmDetailUser(this, users.Find((user) => user.Id == selectedUserId));
            frmDetailUser.ShowDialog();
        }

        private void tsmiAddUserAdd_Click(object sender, EventArgs e)
        {
            frmDetailUser frmDetailUser = new frmDetailUser(this);
            frmDetailUser.ShowDialog();
        }

        public void AddUser(User user)
        {
            dgvUser.Rows.Add(user.Id, user.UserName, user.LastName, user.FirstName, user.Email, user.Role);
        }

        public void updateUser(User user)
        {
            int selectedRowIndex = dgvUser.SelectedRows[0].Index;
            dgvUser.Rows[selectedRowIndex].Cells["userName"].Value = user.UserName;
            dgvUser.Rows[selectedRowIndex].Cells["lastName"].Value = user.LastName;
            dgvUser.Rows[selectedRowIndex].Cells["firstName"].Value = user.FirstName;
            dgvUser.Rows[selectedRowIndex].Cells["email"].Value = user.Email;
            dgvUser.Rows[selectedRowIndex].Cells["role"].Value = user.Role;
        }

        public void removeUser()
        {
            int selectedRowIndex = dgvUser.SelectedRows[0].Index;
            int selectedUserId = (int)dgvUser.Rows[selectedRowIndex].Cells["userId"].Value;
            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Supprimer un utilisateur", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dgvUser.Rows.RemoveAt(selectedRowIndex);
            }
        }
    }
}
