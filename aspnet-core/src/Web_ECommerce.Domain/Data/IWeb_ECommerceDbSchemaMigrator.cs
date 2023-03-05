using System.Threading.Tasks;

namespace Web_ECommerce.Data;

public interface IWeb_ECommerceDbSchemaMigrator
{
    Task MigrateAsync();
}
