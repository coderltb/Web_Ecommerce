using Volo.Abp.Application.Dtos;

namespace Web_ECommerce.Public
{
    public class BaseListFilterDto : PagedResultRequestBase
    {
        public string Keyword { get; set; }
    }
}
