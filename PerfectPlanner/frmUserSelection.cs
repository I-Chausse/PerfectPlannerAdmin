using PerfectPlanner.Models.Users;
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
    public partial class frmUserSelection: Form
    {
        private IUserAssignable parentForm;
        private List<User> users;
        public frmUserSelection(IUserAssignable parentForm,  List<User> users)
        {
            this.users = users;
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void OnLoadOfFrmUserSelection(object sender, EventArgs e)
        {
            cmbUserSelect.DataSource = users;
            cmbUserSelect.DisplayMember = "user_name";
        }

        private void OnClickOnBtnAddUser(object sender, EventArgs e)
        {
            if (cmbUserSelect.SelectedItem != null)
            {
                User selectedUser = (User)cmbUserSelect.SelectedItem;
                parentForm.AddUser(selectedUser);
                this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnClickOnBtnCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
