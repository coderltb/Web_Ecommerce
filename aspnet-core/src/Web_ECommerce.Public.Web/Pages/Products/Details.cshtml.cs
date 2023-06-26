using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_ECommerce.Public.Catalog.ProductCategories;
using Web_ECommerce.Public.Catalog.Products;

namespace Web_ECommerce.Public.Web.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly IProductsAppService _productsAppService;
        private readonly IProductCategoriesAppService _productCategoriesAppService;
        public DetailsModel(IProductsAppService productsAppService, 
            IProductCategoriesAppService productCategoriesAppService)
        {
            _productsAppService = productsAppService;
            _productCategoriesAppService = productCategoriesAppService;
        }
        public ProductCategoryDto Category { get; set; }
        public ProductDto Product { get; set; }
        public async Task OnGetAsync(string categorySlug, string slug)
        {
            Category = await _productCategoriesAppService.GetBySlugAsync(categorySlug);
            Product = await _productsAppService.GetBySlugAsync(slug);
        }
    }
}