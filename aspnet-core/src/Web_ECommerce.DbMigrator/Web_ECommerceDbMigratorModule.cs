using Web_ECommerce.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Web_ECommerce.Public;

namespace Web_ECommerce.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Web_ECommerceEntityFrameworkCoreModule),
    typeof(PublicApplicationContractsModule)
    )]
public class Web_ECommerceDbMigratorModule : AbpModule
{

}
