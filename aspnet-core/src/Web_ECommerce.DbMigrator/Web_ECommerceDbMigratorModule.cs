using Web_ECommerce.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Web_ECommerce.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Web_ECommerceEntityFrameworkCoreModule),
    typeof(Web_ECommerceApplicationContractsModule)
    )]
public class Web_ECommerceDbMigratorModule : AbpModule
{

}
