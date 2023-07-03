using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Volo.Abp.Emailing;
using Volo.Abp.EventBus.Local;
using Volo.Abp.TextTemplating;
using Web_ECommerce.Emailing;
using Web_ECommerce.Orders.Events;
using Web_ECommerce.Public.Orders;
using Web_ECommerce.Public.Web.Extensions;
using Web_ECommerce.Public.Web.Models;

namespace Web_ECommerce.Public.Web.Pages.Cart
{
    public class CheckoutModel : PageModel
    {
          private readonly IOrdersAppService _ordersAppService;
          private readonly ILocalEventBus _localEventBus;
        public CheckoutModel(IOrdersAppService ordersAppService, ILocalEventBus localEventBus)
        {
            _ordersAppService = ordersAppService;
            _localEventBus = localEventBus;
        }
        public List<CartItem> CartItems { get; set; }

        public bool? CreateStatus { set; get; }

        [BindProperty]
        public OrderDto Order { set; get; }

        public void OnGet()
        {
            CartItems = GetCartItems();

        }

        public async Task OnPostAsync()
        {
            if (ModelState.IsValid == false)
            {

            }
            var cartItems = new List<OrderItemDto>();
            foreach (var item in GetCartItems())
            {
                cartItems.Add(new OrderItemDto()
                {
                    Price = item.Product.SellPrice,
                    ProductId = item.Product.Id,
                    Quantity = item.Quantity
                });
            }
            Guid? currentUserId = User.Identity.IsAuthenticated ? User.GetUserId() : null;
            var order = await _ordersAppService.CreateAsync(new CreateOrderDto()
            {
                CustomerName = Order.CustomerName,
                CustomerAddress = Order.CustomerAddress,
                CustomerPhoneNumber = Order.CustomerPhoneNumber,
                Items = cartItems,
                CustomerUserId = currentUserId
            });
            CartItems = GetCartItems();

            if (order != null)
            {
                if (User.Identity.IsAuthenticated)
                {
                    var email = User.GetSpecificClaim(ClaimTypes.Email);
                    await _localEventBus.PublishAsync(new NewOrderCreatedEvent()
                    {
                        CustomerEmail = email,
                        Message = "Create order success"
                    });
                }

                CreateStatus = true;
            }

            else
                CreateStatus = false;
        }

        private List<CartItem> GetCartItems()
        {
            var cart = HttpContext.Session.GetString(Web_ECommerceConsts.Cart);
            var productCarts = new Dictionary<string, CartItem>();
            if (cart != null)
            {
                productCarts = JsonSerializer.Deserialize<Dictionary<string, CartItem>>(cart);
            }
            return productCarts.Values.ToList();
        }

    }
}