﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web_ECommerce.Public.Catalog.ProductCategories;

namespace Web_ECommerce.Public.Web.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly IProductCategoriesAppService _productCategoriesAppService;
        public HeaderViewComponent(IProductCategoriesAppService productCategoriesAppService)
        {
            _productCategoriesAppService = productCategoriesAppService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _productCategoriesAppService.GetListAllAsync();
            return View(model);
        }
    }
}
