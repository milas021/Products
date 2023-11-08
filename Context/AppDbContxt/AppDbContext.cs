using Microsoft.EntityFrameworkCore;
using Products.Model;
using System.Reflection.Metadata.Ecma335;

namespace Products.Context.AppDbContxt
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product>   Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=Shop;User Id=sa;Password=123456;");
        }
    }
}
