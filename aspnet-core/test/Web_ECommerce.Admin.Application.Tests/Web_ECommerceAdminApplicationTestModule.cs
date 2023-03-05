using Volo.Abp.Modularity;

namespace Web_ECommerce.Admin;

[DependsOn(
    typeof(Web_ECommerceAdminApplicationModule),
    typeof(Web_ECommerceDomainTestModule)
    )]
public class Web_ECommerceAdminApplicationTestModule : AbpModule
{

}
