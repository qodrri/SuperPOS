using Microsoft.Extensions.DependencyInjection;
using SuperPOS.Data;
using SuperPOS.Models;
using SuperPOS.Repositories.UserRepository;
using SuperPOS.Views;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace SuperPOS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Mengapplikasikan inisialisasi data user admin
            Database.SetInitializer(new AppDbInitializer());

            // Registrasi data context
            using (var context = new SuperPosDataContext())
            {
                context.Database.Initialize(force: false);
            }

            // membuat Service Collection
            var services = new ServiceCollection();

            // Mendaftarkan dependencies
            ConfigureServices(services);

            // Membangun servie provider
            ServiceProvider = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<SuperPosDataContext>();
            services.AddScoped<IUserRepository, EntityFrameworkUserrepository>();
        }

        public static ServiceProvider ServiceProvider { get; private set; }
        public static User CurrentUser { get; set; }
    }
}
