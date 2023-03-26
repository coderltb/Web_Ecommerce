using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Web_ECommerce.Admin.Products
{
    public interface IProductsAppService : ICrudAppService
    <ProductDto,
        Guid, 
        PagedResultRequestDto,
        CreateUpdateProductDto, 
        CreateUpdateProductDto>
    {
        Task<PagedResultDto<ProductInListDto>> GetListFilterAsync(ProductListFilterDto input);
        Task<List<ProductInListDto>> GetListAllAsync();
        Task DeleteMultipleAsync(IEnumerable<Guid> ids);
    }
}