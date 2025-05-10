using Microsoft.Extensions.DependencyInjection;
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
        private readonly IServiceProvider _serviceProvider;
        private Form currentForm;
        private String token;
        private bool isAdvancedMode = false;

        public CustomApplicationContext(Form initialForm, IServiceProvider serviceProvider)
        {
            currentForm = initialForm;
            currentForm.FormClosed += new FormClosedEventHandler(OnFormClosed);
            currentForm.Show();
            _serviceProvider = serviceProvider;
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
                currentForm = _serviceProvider.GetRequiredService<frmLogin>();
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

        public void SwitchAdvancedMode()
        {
            isAdvancedMode = !isAdvancedMode;
        }

        public bool IsAdvancedMode()
        {
            return isAdvancedMode;
        }

        public void SetToken(string token)
        {
            this.token = token;
        }
        public string GetToken()
        {
            return token;
        }
    }
}
