using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Web_ECommerce.Data;

/* This is used if database provider does't define
 * IWeb_ECommerceDbSchemaMigrator implementation.
 */
public class NullWeb_ECommerceDbSchemaMigrator : IWeb_ECommerceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
