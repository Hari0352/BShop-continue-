using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bshop.Data.EF
{
    public class BShopDbContextFactory : IDesignTimeDbContextFactory<BShopDbContext>
    {
        public BShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("BshopDb");

            var optionsBuilder = new DbContextOptionsBuilder<BShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new BShopDbContext(optionsBuilder.Options);
        }
    }
}
