using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Web_ECommerce;

[Dependency(ReplaceServices = true)]
public class Web_ECommerceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Web_ECommerce";
}
