using System;
using Volo.Abp.Domain.Entities;

namespace Web_ECommerce.Products
{
    public class ProductAttributeDecimal : Entity<Guid>
    {
        public Guid AttributeId { get; set; }
        public Guid ProductId { get; set; }
        public decimal? Value { get; set; }
    }
}
