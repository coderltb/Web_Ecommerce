using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Web_ECommerce.Public.Catalog.ProductAttributes
{
    public interface IProductAttributesAppService : IReadOnlyAppService
        <ProductAttributeDto,
        Guid, 
        PagedResultRequestDto>
    {
        Task<PagedResult<ProductAttributeInListDto>> GetListFilterAsync(BaseListFilterDto input);
        Task<List<ProductAttributeInListDto>> GetListAllAsync();
   }
}
