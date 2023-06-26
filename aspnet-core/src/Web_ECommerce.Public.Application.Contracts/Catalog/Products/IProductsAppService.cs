using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Web_ECommerce.Public.Catalog.Products.Attributes;

namespace Web_ECommerce.Public.Catalog.Products
{
    public interface IProductsAppService : IReadOnlyAppService
        <ProductDto,
        Guid, 
        PagedResultRequestDto>
    {
        Task<PagedResult<ProductInListDto>> GetListFilterAsync(ProductListFilterDto input);
        Task<List<ProductInListDto>> GetListAllAsync();
        Task<string> GetThumbnailImageAsync(string fileName);
        Task<List<ProductAttributeValueDto>> GetListProductAttributeAllAsync(Guid productId);
        Task<PagedResult<ProductAttributeValueDto>> GetListProductAttributesAsync(ProductAttributeListFilterDto input);

        Task<List<ProductInListDto>> GetListTopSellerAsync(int numberOfRecords);
        Task<ProductDto> GetBySlugAsync(string slug);

    }
}
