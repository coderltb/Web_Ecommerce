using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web_ECommerce.Products;

namespace Web_ECommerce.Configurations.Products
{
    public class ProductAttributeDecimalConfiguration : IEntityTypeConfiguration<ProductAttributeDecimal>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeDecimal> builder)
        {
            builder.ToTable(Web_ECommerceConsts.DbTablePrefix + "ProductAttributeDecimals");
            builder.HasKey(x => x.Id);
        }
    }
}
