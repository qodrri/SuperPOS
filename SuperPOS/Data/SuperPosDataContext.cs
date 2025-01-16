using SuperPOS.Models;
using System.Data.Entity;

namespace SuperPOS.Data
{
    internal class SuperPosDataContext : DbContext
    {
        // Registrasi Table Berdasarkan Class Models
        public DbSet<User> Users { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
