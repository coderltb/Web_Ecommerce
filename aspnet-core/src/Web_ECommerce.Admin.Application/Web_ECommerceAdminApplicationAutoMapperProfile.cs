using AutoMapper;
using Web_ECommerce.Admin.Manufacturers;
using Web_ECommerce.Admin.ProductCategories;
using Web_ECommerce.Admin.Products;
using Web_ECommerce.Manufacturers;
using Web_ECommerce.ProductCategories;
using Web_ECommerce.Products;

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
    }
}
