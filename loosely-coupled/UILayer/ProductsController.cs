using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace loosely_coupled.UILayer
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            if (_productService == null)
                throw new ArgumentNullException("productService");

            this._productService = productService;
        }
        
        // GET
        public IActionResult Index()
        {
            IEnumerable<DiscountedProduct> products = this._productService.GetFeaturedProducts();

            var vm = new FeaturedProductsViewModel(from product in products select new ProductsViewModel(product));
            
            return Json(vm);
        }
    }
}