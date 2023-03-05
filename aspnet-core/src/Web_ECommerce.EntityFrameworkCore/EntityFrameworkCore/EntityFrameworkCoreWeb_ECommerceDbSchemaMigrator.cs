using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Web_ECommerce.Data;
using Volo.Abp.DependencyInjection;

namespace Web_ECommerce.EntityFrameworkCore;

public class EntityFrameworkCoreWeb_ECommerceDbSchemaMigrator
    : IWeb_ECommerceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreWeb_ECommerceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the Web_ECommerceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Web_ECommerceDbContext>()
            .Database
            .MigrateAsync();
    }
}
