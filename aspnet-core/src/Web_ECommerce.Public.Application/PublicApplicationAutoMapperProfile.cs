using AutoMapper;
using Web_ECommerce.Manufacturers;
using Web_ECommerce.Orders;
using Web_ECommerce.ProductAttributes;
using Web_ECommerce.ProductCategories;
using Web_ECommerce.Products;
using Web_ECommerce.Public.Catalog.Manufacturers;
using Web_ECommerce.Public.Catalog.ProductAttributes;
using Web_ECommerce.Public.Catalog.ProductCategories;
using Web_ECommerce.Public.Catalog.Products;
using Web_ECommerce.Public.Orders;

namespace Web_ECommerce.Public;

public class PublicApplicationAutoMapperProfile : Profile
{
    public PublicApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<ProductCategory, ProductCategoryInListDto>();

        //Product
        CreateMap<Product, ProductDto>();
        CreateMap<Product, ProductInListDto>();

        CreateMap<Manufacturer, ManufacturerDto>();
        CreateMap<Manufacturer, ManufacturerInListDto>();

        //Product attribute
        CreateMap<ProductAttribute, ProductAttributeDto>();
        CreateMap<ProductAttribute, ProductAttributeInListDto>();

        //Order
        CreateMap<Order, OrderDto>();
    }
}
