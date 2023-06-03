using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Polly;

using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Web_ECommerce.Admin.Permissions;
using Web_ECommerce.ProductCategories;

namespace Web_ECommerce.Admin.Catalog.ProductCategories
{
    [Authorize(Web_ECommerceAdminPermissions.ProductCategory.Default, Policy = "AdminOnly")]
    public class ProductCategoriesAppService : CrudAppService<
        ProductCategory,
        ProductCategoryDto,
        Guid,
        PagedResultRequestDto,
        CreateUpdateProductCategoryDto,
        CreateUpdateProductCategoryDto>, IProductCategoriesAppService
    {
        private readonly IRepository<ProductCategory, Guid> _repository;

        public ProductCategoriesAppService(IRepository<ProductCategory, Guid> repository)
            : base(repository)
        {
            _repository = repository;
            GetPolicyName = Web_ECommerceAdminPermissions.ProductCategory.Default;
            GetListPolicyName = Web_ECommerceAdminPermissions.ProductCategory.Default;
            CreatePolicyName = Web_ECommerceAdminPermissions.ProductCategory.Create;
            UpdatePolicyName = Web_ECommerceAdminPermissions.ProductCategory.Update;
            DeletePolicyName = Web_ECommerceAdminPermissions.ProductCategory.Delete;
        }

        [Authorize(Web_ECommerceAdminPermissions.ProductCategory.Delete)]
        public async Task DeleteMultipleAsync(IEnumerable<Guid> ids)
        {
            await Repository.DeleteManyAsync(ids);
            await UnitOfWorkManager.Current.SaveChangesAsync();
        }

        [Authorize(Web_ECommerceAdminPermissions.ProductCategory.Delete)]
        public async Task<List<ProductCategoryInListDto>> GetListAllAsync()
        {
            var query = await Repository.GetQueryableAsync();
            query = query.Where(x => x.IsActive == true);
            var data = await AsyncExecuter.ToListAsync(query);

            return ObjectMapper.Map<List<ProductCategory>, List<ProductCategoryInListDto>>(data);

        }

        [Authorize(Web_ECommerceAdminPermissions.ProductCategory.Default)]
        public async Task<PagedResultDto<ProductCategoryInListDto>> GetListFilterAsync(BaseListFilterDto input)
        {
            var query = await Repository.GetQueryableAsync();
            query = query.WhereIf(!string.IsNullOrWhiteSpace(input.Keyword), x => x.Name.Contains(input.Keyword));

            var totalCount = await AsyncExecuter.LongCountAsync(query);
            var data = await AsyncExecuter.ToListAsync(query.Skip(input.SkipCount).Take(input.MaxResultCount));
            return new PagedResultDto<ProductCategoryInListDto>(totalCount, ObjectMapper.Map<List<ProductCategory>, List<ProductCategoryInListDto>>(data));
        }
    }
}