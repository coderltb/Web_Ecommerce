using Volo.Abp.Modularity;

namespace Web_ECommerce.Public;

[DependsOn(
    typeof(PublicApplicationModule),
    typeof(Web_ECommerceDomainTestModule)
    )]
public class PublicApplicationTestModule : AbpModule
{

}
