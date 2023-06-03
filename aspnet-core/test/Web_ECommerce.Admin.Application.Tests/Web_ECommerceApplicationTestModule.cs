using Volo.Abp.Modularity;
using Web_ECommerce.Admin;

namespace Web_ECommerce;

[DependsOn(
    typeof(Web_ECommerceAdminApplicationModule),
    typeof(Web_ECommerceDomainTestModule)
    )]
public class Web_ECommerceApplicationTestModule : AbpModule
{

}
