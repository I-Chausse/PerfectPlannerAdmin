using Newtonsoft.Json;
using PerfectPlanner.Models.Projects;
using PerfectPlanner.Models.Users;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
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
        private readonly IHttpClientFactory _httpClientFactory;
        private Project project = null;
        private BindingSource usersBindingSource;
        private BindingSource adminsBindingSource;
        public frmDetailProjet(frmProject frmProjects, IHttpClientFactory httpClientFactory)
        {
            this.project = new Project(0, "");
            _httpClientFactory = httpClientFactory;
            InitializeComponent();
            this.usersBindingSource = new BindingSource { DataSource = this.project.users };
            this.adminsBindingSource = new BindingSource { DataSource = this.project.admins };
            dgvAdminsAssigned.DataSource = this.adminsBindingSource;
            dgvUsersAssigned.DataSource = this.usersBindingSource;
            this.frmProjects = frmProjects;
            btnSave.Text = "Ajouter";
        }

        public frmDetailProjet(frmProject frmProjects, Project project, IHttpClientFactory httpClientFactory)
        {
            this.project = project;
            _httpClientFactory = httpClientFactory;
            InitializeComponent();
            txtProjectName.Text = project.project_name;
            this.usersBindingSource = new BindingSource { DataSource = this.project.users };
            this.adminsBindingSource = new BindingSource { DataSource = this.project.admins };
            dgvAdminsAssigned.DataSource = this.adminsBindingSource;
            dgvUsersAssigned.DataSource = this.usersBindingSource;
            this.frmProjects = frmProjects;
            isEditMode = true;
            projectId = project.id;
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
            List<User> usersAssignables = fetchUsers(true);
            currentDGV = dgvAdminsAssigned;
            frmUserSelection frmUserSelection = new frmUserSelection(this, usersAssignables);
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
            var usersAssignables = fetchUsers(false);
            currentDGV = dgvUsersAssigned;
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
            if (currentDGV == dgvAdminsAssigned)
            {
                var adminsList = (List<User>)this.adminsBindingSource.DataSource;
                adminsList.Add(user);
                this.adminsBindingSource.ResetBindings(false);
            }
            else
            {
                var usersList = (List<User>)this.usersBindingSource.DataSource;
                usersList.Add(user);
                this.usersBindingSource.ResetBindings(false);
            }

        }
        public void RemoveUser()
        {
            
            if (currentDGV == dgvAdminsAssigned)
            {
                int userId = (int)currentDGV.SelectedRows[0].Cells["adminUserId"].Value;
                var adminsList = (List<User>)this.adminsBindingSource.DataSource;
                var userToRemove = adminsList.FirstOrDefault(u => u.id == userId);
                if (userToRemove != null)
                {
                    adminsList.Remove(userToRemove);
                    this.adminsBindingSource.ResetBindings(false);
                }
            }
            else
            {
                int userId = (int)currentDGV.SelectedRows[0].Cells["assigneeUserId"].Value;
                var usersList = (List<User>)this.usersBindingSource.DataSource;
                var userToRemove = usersList.FirstOrDefault(u => u.id == userId);
                if (userToRemove != null)
                {
                    usersList.Remove(userToRemove);
                    this.usersBindingSource.ResetBindings(false);
                }
            }
        }

        private void OnClickOnBtnCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void OnClickOnBtnSave(object sender, EventArgs e)
        {
            if (this.isEditMode)
            {
                try
                {
                    this.project.project_name = txtProjectName.Text;
                    await this.frmProjects.UpdateProject(this.project);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    this.project.project_name = txtProjectName.Text;
                    await this.frmProjects.AddProject(this.project);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
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

        private List<User> fetchUsers(bool admin)
        {
            HttpClient client = _httpClientFactory.CreateClient("MyApiClient");
            string param = admin ? "?role=admin,project_admin" : "?role=user";
            HttpResponseMessage response = client.GetAsync("users" + param).Result;
            List<User> usersAssignables = new List<User>();
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                usersAssignables = JsonConvert.DeserializeObject<UserResponse>(content).Data;
                if (admin)
                {
                    usersAssignables = usersAssignables.Where(u => !project.admins.Any(a => a.id == u.id)).ToList();
                }
                else
                {
                    usersAssignables = usersAssignables.Where(u => !project.users.Any(a => a.id == u.id)).ToList();
                }
            }
            else
            {
                MessageBox.Show("Erreur lors de la récupération des projets pour l'id : " + projectId, "Erreur: " + response.StatusCode, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return usersAssignables;
        }
    }
}
