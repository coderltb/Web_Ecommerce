using System;
using System.Collections.Generic;
using System.Text;
using Web_ECommerce.Localization;
using Volo.Abp.Application.Services;

namespace Web_ECommerce;

/* Inherit your application services from this class.
 */
public abstract class Web_ECommerceAppService : ApplicationService
{
    protected Web_ECommerceAppService()
    {
        LocalizationResource = typeof(Web_ECommerceResource);
    }
}
