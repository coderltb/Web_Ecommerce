using System;

namespace Web_ECommerce.Public.Catalog.Products
{
    public class ProductListFilterDto : BaseListFilterDto
    {
        public Guid? CategoryId { get; set; }
    }
}
