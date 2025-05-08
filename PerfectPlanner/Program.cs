using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;

namespace PerfectPlanner
{
    static class Program
    {
        public static CustomApplicationContext AppContext;
        public static IServiceProvider ServiceProvider;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();
            frmLogin loginForm = ServiceProvider.GetRequiredService<frmLogin>();
            AppContext = new CustomApplicationContext(loginForm, ServiceProvider);
            Application.Run(AppContext);
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient("MyApiClient", client =>
            {
                client.BaseAddress = new Uri("https://f594-195-176-241-239.ngrok-free.app/api/");
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                if (!string.IsNullOrEmpty(Program.AppContext.GetToken()))
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Program.AppContext.GetToken());
                }
            });

            services.AddTransient<frmLogin>();
            services.AddTransient<frmApp>();
            services.AddTransient<frmUser>();
            services.AddTransient<frmProject>();
        }

    }

}
