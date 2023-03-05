using Volo.Abp.Application.Services;
using Web_ECommerce.Localization;

namespace Web_ECommerce.Admin;

/* Inherit your application services from this class.
 */
public abstract class Web_ECommerceAdminAppService : ApplicationService
{
    protected Web_ECommerceAdminAppService()
    {
        LocalizationResource = typeof(Web_ECommerceResource);
    }
}
