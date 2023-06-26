using Web_ECommerce.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

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
