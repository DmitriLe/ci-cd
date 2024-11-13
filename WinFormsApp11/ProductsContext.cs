using Microsoft.EntityFrameworkCore;
using WinFormsApp11;

namespace WinFormsApp11;

public class ProductsContext : DbContext
{
   
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=products;User Id=SA;password =<YourStrong@Passw0rd>;TrustServerCertificate=True;Trusted_Connection=false;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Leontev D.V.", Number = 623050, DR = new DateTime(2009,2,20), DP = new DateTime(2019, 12, 20) },
            new Category { Id = 2, Name = "Bodrov S.S.", Number = 641139, DR = new DateTime(2003, 5, 1), DP = new DateTime(2019, 12, 3) });
    }
}