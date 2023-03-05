using Web_ECommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Web_ECommerce.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Web_ECommerceController : AbpControllerBase
{
    protected Web_ECommerceController()
    {
        LocalizationResource = typeof(Web_ECommerceResource);
    }
}
