using AutoMapper;
using Volo.Abp.Identity;
using Web_ECommerce.Admin.Catalog.Manufacturers;
using Web_ECommerce.Admin.Catalog.ProductAttributes;
using Web_ECommerce.Admin.Catalog.ProductCategories;
using Web_ECommerce.Admin.Catalog.Products;
using Web_ECommerce.Admin.System.Roles;
using Web_ECommerce.Admin.System.Users;
using Web_ECommerce.Manufacturers;
using Web_ECommerce.ProductAttributes;
using Web_ECommerce.ProductCategories;
using Web_ECommerce.Products;
using Web_ECommerce.Roles;

namespace Web_ECommerce.Admin;

public class Web_ECommerceAdminApplicationAutoMapperProfile : Profile
{
    public Web_ECommerceAdminApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        //Product Categories
        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<ProductCategory, ProductCategoryInListDto>();
        CreateMap<CreateUpdateProductCategoryDto, ProductCategory>();

        //Product
        CreateMap<Product, ProductDto>();
        CreateMap<Product, ProductInListDto>();
        CreateMap<CreateUpdateProductDto, Product>();

        CreateMap<Manufacturer, ManufacturerDto>();
        CreateMap<Manufacturer, ManufacturerInListDto>();
        CreateMap<CreateUpdateManufacturerDto, Manufacturer>();


        //Product attribute
        CreateMap<ProductAttribute, ProductAttributeDto>();
        CreateMap<ProductAttribute, ProductAttributeInListDto>();
        CreateMap<CreateUpdateProductAttributeDto, ProductAttribute>();


        
        //Roles
        CreateMap<IdentityRole, RoleDto>().ForMember(x => x.Description,
            map => map.MapFrom(x => x.ExtraProperties.ContainsKey(RoleConsts.DescriptionFieldName)
                ?
                x.ExtraProperties[RoleConsts.DescriptionFieldName]
                :
                null));
        CreateMap<IdentityRole, RoleInListDto>().ForMember(x => x.Description,
            map => map.MapFrom(x => x.ExtraProperties.ContainsKey(RoleConsts.DescriptionFieldName)
                ?
                x.ExtraProperties[RoleConsts.DescriptionFieldName]
                :
                null));
        CreateMap<CreateUpdateRoleDto, IdentityRole>();

        //User
        CreateMap<IdentityUser, UserDto>();
        CreateMap<IdentityUser, UserInListDto>();
    }
}
