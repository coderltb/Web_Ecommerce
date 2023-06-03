using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Web_ECommerce.Manufacturers;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Polly;
using Web_ECommerce.Admin.Permissions;

namespace Web_ECommerce.Admin.Catalog.Manufacturers
{
    [Authorize(Web_ECommerceAdminPermissions.Manufacturer.Default, Policy = "AdminOnly")]
    public class ManufacturersAppService : CrudAppService<
        Manufacturer,
        ManufacturerDto,
        Guid,
        PagedResultRequestDto,
        CreateUpdateManufacturerDto,
        CreateUpdateManufacturerDto>, IManufacturersAppService
    {
        public ManufacturersAppService(IRepository<Manufacturer, Guid> repository)
            : base(repository)
        {
            GetPolicyName = Web_ECommerceAdminPermissions.Manufacturer.Default;
            GetListPolicyName = Web_ECommerceAdminPermissions.Manufacturer.Default;
            CreatePolicyName = Web_ECommerceAdminPermissions.Manufacturer.Create;
            UpdatePolicyName = Web_ECommerceAdminPermissions.Manufacturer.Update;
            DeletePolicyName = Web_ECommerceAdminPermissions.Manufacturer.Delete;
        }

        [Authorize(Web_ECommerceAdminPermissions.Manufacturer.Delete)]
        public async Task DeleteMultipleAsync(IEnumerable<Guid> ids)
        {
            await Repository.DeleteManyAsync(ids);
            await UnitOfWorkManager.Current.SaveChangesAsync();
        }
        
        [Authorize(Web_ECommerceAdminPermissions.Manufacturer.Default)]
        public async Task<List<ManufacturerInListDto>> GetListAllAsync()
        {
            var query = await Repository.GetQueryableAsync();
            query = query.Where(x => x.IsActive == true);
            var data = await AsyncExecuter.ToListAsync(query);

            return ObjectMapper.Map<List<Manufacturer>, List<ManufacturerInListDto>>(data);

        }

        [Authorize(Web_ECommerceAdminPermissions.Manufacturer.Default)]
        public async Task<PagedResultDto<ManufacturerInListDto>> GetListFilterAsync(BaseListFilterDto input)
        {
            var query = await Repository.GetQueryableAsync();
            query = query.WhereIf(!string.IsNullOrWhiteSpace(input.Keyword), x => x.Name.Contains(input.Keyword));

            var totalCount = await AsyncExecuter.LongCountAsync(query);
            var data = await AsyncExecuter.ToListAsync(query.Skip(input.SkipCount).Take(input.MaxResultCount));

            return new PagedResultDto<ManufacturerInListDto>(totalCount, ObjectMapper.Map<List<Manufacturer>, List<ManufacturerInListDto>>(data));
        }
    }
}