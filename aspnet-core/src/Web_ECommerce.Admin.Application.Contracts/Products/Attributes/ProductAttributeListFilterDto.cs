using System;
using System.Collections.Generic;
using System.Text;

namespace Web_ECommerce.Admin.Products.Attributes
{
    public class ProductAttributeListFilterDto : BaseListFilterDto
    {
        public Guid ProductId { get; set; }
    }
}