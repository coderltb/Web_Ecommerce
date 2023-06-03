using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;
using Web_ECommerce.Localization;

namespace Web_ECommerce.Public;

/* Inherit your application services from this class.
 */
public abstract class PublicAppService : ApplicationService
{
    protected PublicAppService()
    {
        LocalizationResource = typeof(Web_ECommerceResource);
    }
}
