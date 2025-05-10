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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectPlanner
{
    public partial class frmCreateToken : Form
    {
        private IHttpClientFactory _httpClientFactory;
        private List<Role> roles = new List<Role>();
        public frmCreateToken(IHttpClientFactory httpClientFactory)
        {
            this._httpClientFactory = httpClientFactory;
            InitializeComponent();
        }

        private void frmCreateToken_Load(object sender, EventArgs e)
        {
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
            cmbSelectRole.DataSource = roles;
        }

        private async void btnCreateToken_Click(object sender, EventArgs e)
        {
            try
            {
                var client = _httpClientFactory.CreateClient("MyApiClient");
                UserTokenCreation userTokenCreation = new UserTokenCreation
                {
                    role_id = (int)cmbSelectRole.SelectedValue,
                };
                var jsonContent = new StringContent(JsonConvert.SerializeObject(userTokenCreation), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("generate-invitation-token", jsonContent);
                if (!response.IsSuccessStatusCode)
                {
                    await ParseResponse(response);
                }
                var content = await response.Content.ReadAsStringAsync();
                Token createdToken = JsonConvert.DeserializeObject<TokenResponse>(content).Data;
                txtGeneratedCode.Text = createdToken.token.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ParseResponse(HttpResponseMessage response)
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
