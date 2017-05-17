using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SHOPPING.Bussiness.Abstract;
using SHOPPING.MvcCoreUI.Models;
using SHOPPING.MvcCoreUI.Services;

namespace SHOPPING.MvcCoreUI.Controller
{
    public class CartController : Microsoft.AspNetCore.Mvc.Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;

        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public ActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);
            var cart = _cartSessionService.GetCart();

            _cartService.AddToCart(cart, productToBeAdded);
            _cartSessionService.SetCard(cart);

            TempData.Add("message", String.Format("Your Product , {0}, was Added To the Cart", productToBeAdded.ProductName));

            return RedirectToAction("Index", "Product");
        }

        
    }
}
