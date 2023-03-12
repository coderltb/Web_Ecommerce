using Volo.Abp.Domain.Entities;

namespace Web_ECommerce.Products
{
    public class Tag : Entity<string>
    {
        public string Name { get; set; }
    }
}
