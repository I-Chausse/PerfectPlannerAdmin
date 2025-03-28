﻿using System;
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
        public frmUserSelection(IUserAssignable parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void OnLoadOfFrmUserSelection(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource
            {
                DataSource = DataProvider.GetUsers()
            };

            cmbUserSelect.DisplayMember = "UserName";
            cmbUserSelect.DataSource = bindingSource;
        }

        private void OnClickOnBtnAddUser(object sender, EventArgs e)
        {
            parentForm.AddUser((User)cmbUserSelect.SelectedItem);
            this.Close();
        }

        private void OnClickOnBtnCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
