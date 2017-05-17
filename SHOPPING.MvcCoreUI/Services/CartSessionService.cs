using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using SHOPPING.Entities.Concrete;
using SHOPPING.MvcCoreUI.ExtensionMethods;

namespace SHOPPING.MvcCoreUI.Services
{
    public class CartSessionService : ICartSessionService
    {
        private IHttpContextAccessor _httpContextAccessor;

        public CartSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Cart GetCart()
        {
            Cart cartCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            if (cartCheck == null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject("cart", new Cart());
                cartCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            }
            return cartCheck;
        }

        public void SetCard(Cart cart)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("cart", cart);
        }
    }
}
