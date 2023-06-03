
using Volo.Abp.AspNetCore.Mvc;
using Web_ECommerce.Localization;

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
