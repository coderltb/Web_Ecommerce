using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Web_ECommerce.Admin.Permissions;
using Web_ECommerce.ProductAttributes;

namespace Web_ECommerce.Admin.Catalog.ProductAttributes
{
    [Authorize(Web_ECommerceAdminPermissions.Attribute.Default, Policy = "AdminOnly")]
    public class ProductAttributesAppService : CrudAppService<
        ProductAttribute,
        ProductAttributeDto,
        Guid,
        PagedResultRequestDto,
        CreateUpdateProductAttributeDto,
        CreateUpdateProductAttributeDto>, IProductAttributesAppService
    {
        public ProductAttributesAppService(IRepository<ProductAttribute, Guid> repository)
            : base(repository)
        {
            GetPolicyName = Web_ECommerceAdminPermissions.Attribute.Default;
            GetListPolicyName = Web_ECommerceAdminPermissions.Attribute.Default;
            CreatePolicyName = Web_ECommerceAdminPermissions.Attribute.Create;
            UpdatePolicyName = Web_ECommerceAdminPermissions.Attribute.Update;
            DeletePolicyName = Web_ECommerceAdminPermissions.Attribute.Delete;
        }
        
        [Authorize(Web_ECommerceAdminPermissions.Attribute.Delete)]
        public async Task DeleteMultipleAsync(IEnumerable<Guid> ids)
        {
            await Repository.DeleteManyAsync(ids);
            await UnitOfWorkManager.Current.SaveChangesAsync();
        }

        [Authorize(Web_ECommerceAdminPermissions.Attribute.Default)]
        public async Task<List<ProductAttributeInListDto>> GetListAllAsync()
        {
            var query = await Repository.GetQueryableAsync();
            query = query.Where(x => x.IsActive == true);
            var data = await AsyncExecuter.ToListAsync(query);

            return ObjectMapper.Map<List<ProductAttribute>, List<ProductAttributeInListDto>>(data);

        }

        [Authorize(Web_ECommerceAdminPermissions.Attribute.Default)]
        public async Task<PagedResultDto<ProductAttributeInListDto>> GetListFilterAsync(BaseListFilterDto input)
        {
            var query = await Repository.GetQueryableAsync();
            query = query.WhereIf(!string.IsNullOrWhiteSpace(input.Keyword), x => x.Label.Contains(input.Keyword));

            var totalCount = await AsyncExecuter.LongCountAsync(query);
            var data = await AsyncExecuter.ToListAsync(query.Skip(input.SkipCount).Take(input.MaxResultCount));

            return new PagedResultDto<ProductAttributeInListDto>(totalCount, ObjectMapper.Map<List<ProductAttribute>, List<ProductAttributeInListDto>>(data));
        }
    }
}