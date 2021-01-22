using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Shop.Models
{
  public class ShopContextFactory : IDesignTimeDbContextFactory<ShopContext>
  {
    ShopContext IDesignTimeDbContextFactory<ShopContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build()

      var builder = new DbContextOptionsBuilder<ShopContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new ShopContext(builder.Options);
    }
  }
}