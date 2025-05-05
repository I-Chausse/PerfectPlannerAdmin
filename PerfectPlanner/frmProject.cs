using Newtonsoft.Json;
using PerfectPlanner.Models.Login;
using PerfectPlanner.Models;
using PerfectPlanner.Models.Projects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectPlanner
{
    public partial class frmProject: Form
    {
        private List<Project> projects = new List<Project>();
        private readonly IHttpClientFactory _httpClientFactory;
        public frmProject(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            InitializeComponent();
        }

        private void OnLoadOfFrmProjects(object sender, EventArgs e)
        {
            UpdateData();
            if (Program.AppContext.IsAdvancedMode())
            {
                btnAddProject.Visible = false;
                btnUpdateProject.Visible = false;
                btnDeleteProject.Visible = false;
                dgvProjects.Height = 720;
            }
        }

        private void OnMouseDownOnDgvProject(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var row = dgvProjects.HitTest(e.X, e.Y);
                if (row.RowIndex >= 0)
                {
                    dgvProjects.ClearSelection();
                    dgvProjects.Rows[row.RowIndex].Selected = true;
                    cmsEditProject.Show(dgvProjects, dgvProjects.PointToClient(Cursor.Position));
                }
                else
                {
                    cmsAddProject.Show(dgvProjects, dgvProjects.PointToClient(Cursor.Position));
                }
            }
        }

        private void OnClickOnTsmiEditProjectEdit(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvProjects.SelectedRows[0].Index;
            int selectedProjetId = (int)dgvProjects.Rows[selectedRowIndex].Cells["projectid"].Value;
            frmDetailProjet frmDetailProject = new frmDetailProjet(this, projects.Find((projet) => projet.id == selectedProjetId), _httpClientFactory);
            frmDetailProject.ShowDialog();
        }

        private void OnClickOnTsmiAddProjectAdd(object sender, EventArgs e)
        {
            frmDetailProjet frmDetailProject = new frmDetailProjet(this, _httpClientFactory);
            frmDetailProject.ShowDialog();
        }

        public async Task AddProject(Project project)
        {
            var client = _httpClientFactory.CreateClient("MyApiClient");
            var jsonContent = new StringContent(JsonConvert.SerializeObject(project), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("projects", jsonContent);
            await ParseResponse(response);
            UpdateData();


        }

        public async Task UpdateProject(Project project)
        {
            var client = _httpClientFactory.CreateClient("MyApiClient");
            var jsonContent = new StringContent(JsonConvert.SerializeObject(project), Encoding.UTF8, "application/json");
            var response = await client.PutAsync("projects/" + project.id, jsonContent);
            await ParseResponse(response);
            UsersToAssign usersToAssign = new UsersToAssign
            {
                users_to_assign = project.UsersIds
            };
            jsonContent = new StringContent(JsonConvert.SerializeObject(usersToAssign), Encoding.UTF8, "application/json");
            response = await client.PutAsync("projects/" + project.id + "/update-assignees", jsonContent);
            await ParseResponse(response);
            UpdateData();
        }

        public void SupprimerProject()
        {
            int selectedRowIndex = dgvProjects.SelectedRows[0].Index;
            int selectedProjetId = (int)dgvProjects.Rows[selectedRowIndex].Cells["projectid"].Value;
        }

        private void OnClickOnTsmiEditProjectDelete(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer ce projet ?", "Supprimer un projet", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.SupprimerProject();
            }
        }

        private void HandleEditAndDeleteBtnState(Object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                btnUpdateProject.Enabled = true;
                btnDeleteProject.Enabled = true;
            }
            else
            {
                btnUpdateProject.Enabled = false;
                btnDeleteProject.Enabled = false;
            }
        }

        private void SelectionCompleteRowOnCellClick(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvProjects.Rows[e.RowIndex].Selected = true;
            }
        }

        private void UpdateData()
        {
            HttpClient client = _httpClientFactory.CreateClient("MyApiClient");
            HttpResponseMessage response = client.GetAsync("projects").Result;
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                projects = JsonConvert.DeserializeObject<ProjectResponse>(content).Data;
            }
            else
            {
                MessageBox.Show("Erreur lors de la récupération des projets", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvProjects.DataSource = projects;
        }

        private async Task ParseResponse(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                if ((int)response.StatusCode == 422)
                {
                    var errorResponse = JsonConvert.DeserializeObject<ProjectValidationError>(content);
                    throw new Exception($"Erreur de validation : {string.Join(", ", errorResponse.message)}");
                }
                else
                {
                    throw new Exception($"Erreur HTTP : {response.StatusCode} - {content}");
                }
            }
        }
    }
}
