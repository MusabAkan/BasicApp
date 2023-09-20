using BasicApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BasicApp.DataAccess.Concrete.EntityFramework
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true;");
        }
        public DbSet<Product> Products { get; set; }    
        public DbSet<Category> Categories { get; set; }

    }
}
