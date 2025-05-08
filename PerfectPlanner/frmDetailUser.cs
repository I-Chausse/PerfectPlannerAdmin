using Newtonsoft.Json;
using PerfectPlanner.Models.Projects;
using PerfectPlanner.Models.Roles;
using PerfectPlanner.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
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
        private IHttpClientFactory _httpClientFactory;
        private List<Role> roles;
        private User user;
        private BindingSource usersBindingSource;

        public frmDetailUser(frmUser frmParent, IHttpClientFactory httpClientFactory)
        {
            this._httpClientFactory = httpClientFactory;
            InitializeComponent();
            this.user = new User();
            this.user.assignees = new List<User>();
            this.usersBindingSource = new BindingSource { DataSource = this.user.assignees };
            dgvUsersAssigned.DataSource = this.usersBindingSource;
            btnSave.Text = "Ajouter";
            grpUsersAssigned.Visible = false;
            this.Width = 310;
            this.frmUser = frmParent;
            btnSave.Text = "Ajouter";
        }

        public frmDetailUser(frmUser frmParent, User user, IHttpClientFactory httpClientFactory)
        {
            this._httpClientFactory = httpClientFactory;
            this.user = user;
            InitializeComponent();
            this.usersBindingSource = new BindingSource { DataSource = this.user.assignees };
            dgvUsersAssigned.DataSource = this.usersBindingSource;
            txtUserName.Text = user.user_name;
            txtPersonName.Text = user.name;
            txtPersonFirstName.Text = user.first_name;
            txtPersonMail.Text = user.email;
            cmbUserRole.Text = user.role.label;
            if (user != null && user.avatar != null && user.avatar.link != null)
            {
                picPersonAvatar.ImageLocation = user.avatar.link;
            }
            if (cmbUserRole.SelectedIndex == 0)
            {
                grpUsersAssigned.Visible = false;
                this.Width = 310;
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
            List<User> usersAssignables = fetchUsers();
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
            this.user.assignees.Add(user);
            this.usersBindingSource.ResetBindings(false);
        }

        public void RemoveUser()
        {
            int userId = (int)dgvUsersAssigned.SelectedRows[0].Cells["userId"].Value;
            var usersList = (List<User>)this.usersBindingSource.DataSource;
            var userToRemove = usersList.FirstOrDefault(u => u.id == userId);
            if (userToRemove != null)
            {
                usersList.Remove(userToRemove);
                this.usersBindingSource.ResetBindings(false);
            }
        }

        private void OnClickOnBtnCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void OnClickOnBtnSave(object sender, EventArgs e)
        {
            this.user.id = userId;
            this.user.user_name = txtUserName.Text;
            this.user.password = mtxUserPassword.Text;
            this.user.email = txtPersonMail.Text;
            this.user.first_name = txtPersonFirstName.Text;
            this.user.name = txtPersonName.Text;
            this.user.role = roles.Find(selected => selected.id == (int)cmbUserRole.SelectedValue);
            List<User> usersAssigned = new List<User>();
            try
            {
                if (this.isEditMode)
                {
                    await this.frmUser.UpdateUser(user);
                }
                else
                {
                    await this.frmUser.AddUser(user);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnClickOnBtnDeletePersonAvatar(object sender, EventArgs e)
        {
            this.picPersonAvatar.Image = null;
            this.user.avatar = null;
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
            fillDomainItems();
        }

        private void fillDomainItems()
        {
            HttpClient client = _httpClientFactory.CreateClient("MyApiClient");
            HttpResponseMessage response = client.GetAsync("get-roles").Result;
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                roles = JsonConvert.DeserializeObject<RoleResponse>(content).Data;
            }
            else
            {
                MessageBox.Show("Erreur lors de la récupération des projets", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cmbUserRole.DataSource = roles;
        }

        private List<User> fetchUsers()
        {
            HttpClient client = _httpClientFactory.CreateClient("MyApiClient");
            string param = "?role=user";
            HttpResponseMessage response = client.GetAsync("users" + param).Result;
            List<User> usersAssignables = new List<User>();
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                Debug.WriteLine(content);
                usersAssignables = JsonConvert.DeserializeObject<UsersResponse>(content).Data;
                usersAssignables = usersAssignables.Where(u => !user.assignees.Any(a => a.id == u.id)).ToList();  
            }
            else
            {
                MessageBox.Show("Erreur lors de la récupération des utilisateurs pour l'id : " + userId, "Erreur: " + response.StatusCode, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return usersAssignables;
        }
    }
}
