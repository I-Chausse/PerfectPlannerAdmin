using System;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace PerfectPlanner
{
    public partial class frmApp: Form
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public frmApp(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            InitializeComponent();
        }
        private void OnClickOnTsmiUser(object sender, EventArgs e)
        {
            frmUser existingForm = Application.OpenForms.OfType<frmUser>().FirstOrDefault();

            if (existingForm != null)
            {
                existingForm.BringToFront();
                existingForm.Activate();
            }
            else
            {
                frmUser frmUser = new frmUser(_httpClientFactory)
                {
                    MdiParent = this
                };
                frmUser.Show();
            }
        }


        private void OnClickOnTsmiProject(object sender, EventArgs e)
        {
            frmProject existingForm = Application.OpenForms.OfType<frmProject>().FirstOrDefault();
            if (existingForm != null)
            {
                existingForm.BringToFront();
                existingForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frmProject frmProjects = new frmProject(_httpClientFactory)
                {
                    MdiParent = this
                };
                frmProjects.Show();
            }
        }

        private void OnClickOnTsmiAdvanced(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            String advanced = "Mode &avancé";
            String basic = "Mode b&asique";
            item.Text = item.Text == advanced ? basic : advanced;
            Program.AppContext.SwitchAdvancedMode();
        }
    }
}
