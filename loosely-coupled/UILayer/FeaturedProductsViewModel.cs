using System.Collections;
using System.Collections.Generic;

namespace loosely_coupled.UILayer
{
    public class FeaturedProductsViewModel
    {
        public IEnumerable<ProductsViewModel> Products { get; }
        
        public FeaturedProductsViewModel(IEnumerable<ProductsViewModel> products)
        {
            this.Products = products;
        }
    }
}