using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SHOPPING.Bussiness.Abstract;
using SHOPPING.MvcCoreUI.Models;

namespace SHOPPING.MvcCoreUI.Controller
{
    public class ProductController : Microsoft.AspNetCore.Mvc.Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index(int page = 1, int category = 0)
        {
            int pageSize = 10;
            var products = _productService.GetByGategory(category);
            ProductListViewModel model = new ProductListViewModel()
            {
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling((products.Count / (pageSize * 1.00))),
                PageSize = pageSize,
                CurrentCategory = category,
                CurrentPage = page
            };

            return View(model);
        }


    }
}
