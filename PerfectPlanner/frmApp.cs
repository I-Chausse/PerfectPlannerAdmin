using System;
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
    public partial class frmApp: Form
    {
        public frmApp()
        {
            InitializeComponent();
        }

        private void frmApp_Load(object sender, EventArgs e)
        {

        }
        private void tsmiUser_Click(object sender, EventArgs e)
        {
            frmUser existingForm = Application.OpenForms.OfType<frmUser>().FirstOrDefault();

            if (existingForm != null)
            {
                existingForm.BringToFront();
                existingForm.Activate();
            }
            else
            {
                frmUser frmUser = new frmUser();
                frmUser.MdiParent = this;
                frmUser.Show();
            }
        }


        private void tsmiProjects_Click(object sender, EventArgs e)
        {
            frmProject existingForm = Application.OpenForms.OfType<frmProject>().FirstOrDefault();
            if (existingForm != null)
            {
                existingForm.BringToFront();
                existingForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frmProject frmProjects = new frmProject();
                frmProjects.MdiParent = this;
                frmProjects.Show();
            }
        }
    }
}
