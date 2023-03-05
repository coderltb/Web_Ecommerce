using Web_ECommerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Web_ECommerce;

[DependsOn(
    typeof(Web_ECommerceEntityFrameworkCoreTestModule)
    )]
public class Web_ECommerceDomainTestModule : AbpModule
{

}
