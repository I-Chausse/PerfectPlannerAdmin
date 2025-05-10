using Newtonsoft.Json;
using PerfectPlanner.Models;
using PerfectPlanner.Models.Login;
using System;
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
    public partial class frmLogin: Form
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public frmLogin(IHttpClientFactory httpClientFactory)
        {
            InitializeComponent();
            _httpClientFactory = httpClientFactory;
        }

        private async void OnClickOnBtnLogin(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            var client = _httpClientFactory.CreateClient("MyApiClient");
            var loginRequest = new LoginRequest
            {
                email = txtUserName.Text,
                password = mtxUserPass.Text
            };
            try
            {
                var jsonContent = new StringContent(JsonConvert.SerializeObject(loginRequest), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("login", jsonContent);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(content);
                if (loginResponse.role == "admin")
                {
                    Program.AppContext.SetToken(loginResponse.token);
                    var frmApp = new frmApp(_httpClientFactory);
                    Program.AppContext.SwitchToForm(frmApp);
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas le droit d'accéder à cette application", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Erreur de requête : {ex.Message}", "Erreur lors du login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur lors du login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnLogin.Enabled = true;
        }
    }
}
