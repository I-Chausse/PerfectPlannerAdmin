using Newtonsoft.Json;
using PerfectPlanner.Models.Projects;
using PerfectPlanner.Models.Users;
using System;
using System.Collections;
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
    
    public partial class frmUser: Form
    {

        List<User> users;
        private readonly IHttpClientFactory _httpClientFactory;
        public frmUser(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            InitializeComponent();
            this.dgvUsers.AutoGenerateColumns = false;
        }

        private void OnLoadOfFrmUser(object sender, EventArgs e)
        {
            UpdateData();

            if (Program.AppContext.IsAdvancedMode())
            {
                btnAddUser.Visible = false;
                btnUpdateUser.Visible = false;
                btnDeleteUser.Visible = false;
                dgvUsers.Height = 720;
            }

        }

        private void OnMouseDownOnDgvUser(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var row = dgvUsers.HitTest(e.X, e.Y);
                if (row.RowIndex >= 0)
                {
                    dgvUsers.ClearSelection();
                    dgvUsers.Rows[row.RowIndex].Selected = true;
                    cmsEditUser.Show(dgvUsers, dgvUsers.PointToClient(Cursor.Position));
                }
                else 
                {
                    cmsAddUser.Show(dgvUsers, dgvUsers.PointToClient(Cursor.Position));
                }
            }
        }

        private void OnClickOnTsmiEditUserEdit(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvUsers.SelectedRows[0].Index;
            int selectedUserId = (int) dgvUsers.Rows[selectedRowIndex].Cells["userId"].Value;
            frmDetailUser frmDetailUser = new frmDetailUser(this, users.Find((user) => user.id == selectedUserId), _httpClientFactory);
            frmDetailUser.ShowDialog();
        }

        private void OnClickOnTsmiAddUserAdd(object sender, EventArgs e)
        {
            frmDetailUser frmDetailUser = new frmDetailUser(this, _httpClientFactory);
            frmDetailUser.ShowDialog();
        }

        public void AddUser(User user)
        {
            //dgvUser.Rows.Add(user.Id, user.UserName, user.LastName, user.FirstName, user.Email, user.Role);
        }

        public void UpdateUser(User user)
        {
            int selectedRowIndex = dgvUsers.SelectedRows[0].Index;
            
        }

        public void RemoveUser()
        {
            int selectedRowIndex = dgvUsers.SelectedRows[0].Index;
            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Supprimer un utilisateur", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dgvUsers.Rows.RemoveAt(selectedRowIndex);
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
                dgvUsers.Rows[e.RowIndex].Selected = true;
            }
        }

        private void OnClickOnTsmiEditUserDelete(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                RemoveUser();
            }
        }

        private void UpdateData()
        {
            HttpClient client = _httpClientFactory.CreateClient("MyApiClient");
            HttpResponseMessage response = client.GetAsync("users").Result;
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                users = JsonConvert.DeserializeObject<UsersResponse>(content).Data;
            }
            else
            {
                MessageBox.Show("Erreur lors de la récupération des projets", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvUsers.DataSource = users;
        }
    }
}
