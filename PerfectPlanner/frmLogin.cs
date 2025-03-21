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
    public partial class frmLogin: Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void OnClickOnBtnLogin(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Admin" && mtxUserPass.Text.Length != 0)
            {
                frmApp frmApp = new frmApp();
                Program.AppContext.SwitchToForm(frmApp);
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Erreur lors du login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
