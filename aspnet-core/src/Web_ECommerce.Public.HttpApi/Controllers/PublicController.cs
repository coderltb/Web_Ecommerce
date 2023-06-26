using Web_ECommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Web_ECommerce.Public.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PublicController : AbpControllerBase
{
    protected PublicController()
    {
        LocalizationResource = typeof(Web_ECommerceResource);
    }
}
