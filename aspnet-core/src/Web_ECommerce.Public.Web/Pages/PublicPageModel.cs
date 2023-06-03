
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
using Web_ECommerce.Localization;

namespace Web_ECommerce.Public.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class PublicPageModel : AbpPageModel
{
    protected PublicPageModel()
    {
        LocalizationResourceType = typeof(Web_ECommerceResource);
    }
}
