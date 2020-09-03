using ActionSelectorsMVC5_Demo.Models;
using System.Data.Entity;

namespace ActionSelectorsMVC5_Demo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("ProductDB")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}