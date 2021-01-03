using System.Collections;
using System.Collections.Generic;

namespace loosely_coupled
{
    public interface IProductService
    {
        IEnumerable<DiscountedProduct> GetFeaturedProducts();
    }
}