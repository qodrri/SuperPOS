using SuperPOS.Core.Helpers;
using SuperPOS.Models;
using System.Data.Entity;

namespace SuperPOS.Data
{
    internal class AppDbInitializer : CreateDatabaseIfNotExists<SuperPosDataContext>
    {
        protected override void Seed(SuperPosDataContext context)
        {
            // Mendaftarkan user admin
            context.Users.Add(new User
            {
                Firstname = "Admin",
                Lastname = "User",
                Username = "admin",
                Password = PasswordHelper.HashPassword("Rahasia@123"),
                IsAdmin = true,
            });
            base.Seed(context);
        }
    }
}
