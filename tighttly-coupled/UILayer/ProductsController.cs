using Microsoft.AspNetCore.Mvc;

namespace tighttly_coupled
{
    public class ProductsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            bool isPreferredCustomer = this.User.IsInRole("PreferredCustomer");
            var service = new ProductService();

            var products = service.GetFeaturedProducts(isPreferredCustomer);

            return Json(products);
        }
    }
}