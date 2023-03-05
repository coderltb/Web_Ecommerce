using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Web_ECommerce.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class Web_ECommerceDbContextFactory : IDesignTimeDbContextFactory<Web_ECommerceDbContext>
{
    public Web_ECommerceDbContext CreateDbContext(string[] args)
    {
        Web_ECommerceEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<Web_ECommerceDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new Web_ECommerceDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Web_ECommerce.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
