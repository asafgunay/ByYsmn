using ByYsmn.Entityframework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
namespace ByYsmn.Entityframework
{
    // appsettings.json icerisindeki veritabani adresini oku
    // bu sayede OOPTut.EntityFramework hic bir referansa sahip olmadan migration yapabilir.
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var dbContext = new ApplicationDbContext(
                new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(
                new ConfigurationBuilder()
                .AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), $"appsettings.json"))
                .Build()
                .GetConnectionString("DatabaseConnection")
                ).Options);
            // dbContext.Database.Migrate();
            return dbContext;
        }
    }
}
