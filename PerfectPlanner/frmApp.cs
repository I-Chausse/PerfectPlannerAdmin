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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tsmiUser_Click(object sender, EventArgs e)
        {
            frmUser frmUser = new frmUser();
            frmUser.MdiParent = this;
            frmUser.Show();
        }
    }
}
