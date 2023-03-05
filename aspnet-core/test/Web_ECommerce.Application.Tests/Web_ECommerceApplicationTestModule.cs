using Volo.Abp.Modularity;

namespace Web_ECommerce;

[DependsOn(
    typeof(Web_ECommerceApplicationModule),
    typeof(Web_ECommerceDomainTestModule)
    )]
public class Web_ECommerceApplicationTestModule : AbpModule
{

}
