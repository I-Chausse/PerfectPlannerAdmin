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
    public partial class frmDetailUser: Form
    {
        public frmDetailUser()
        {
            InitializeComponent();
            btnSave.Text = "Ajouter";
            grpUsersAssigned.Visible = false;

        }

        public frmDetailUser(User user)
        {
            InitializeComponent();
            txtUserName.Text = user.UserName;
            txtPersonName.Text = user.LastName;
            txtPersonFirstName.Text = user.FirstName;
            txtPersonMail.Text = user.Email;
            cmbUserRole.Text = user.Role;
            if (cmbUserRole.SelectedIndex == 0)
            {
                grpUsersAssigned.Visible = false;
            }
        }

        private void cmbUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUserRole.SelectedIndex == 0)
            {
                grpUsersAssigned.Visible = false;
            }
            else
            {
                grpUsersAssigned.Visible = true;
            }
        }
    }
}
