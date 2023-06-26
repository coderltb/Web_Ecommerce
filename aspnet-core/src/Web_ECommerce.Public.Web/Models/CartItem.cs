using Web_ECommerce.Public.Catalog.Products;

namespace Web_ECommerce.Public.Web.Models
{
    public class CartItem
    {
        public ProductDto  Product { get; set; }
        public int Quantity { get; set; }
    }
}