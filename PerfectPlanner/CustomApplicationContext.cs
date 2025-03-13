using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectPlanner
{
    public class CustomApplicationContext : ApplicationContext
    {
        private Form currentForm;

        public CustomApplicationContext(Form initialForm)
        {
            currentForm = initialForm;
            currentForm.FormClosed += new FormClosedEventHandler(OnFormClosed);
            currentForm.Show();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            if (currentForm is frmLogin)
            {
                ExitThread();
            }
            else
            {
                // Sinon, ouvrez frmLogin
                currentForm = new frmLogin();
                currentForm.FormClosed += new FormClosedEventHandler(OnFormClosed);
                currentForm.Show();
            }
        }

        public void SwitchToForm(Form newForm)
        {
            currentForm.Hide();
            currentForm = newForm;
            currentForm.FormClosed += new FormClosedEventHandler(OnFormClosed);
            currentForm.Show();
        }
    }
}
