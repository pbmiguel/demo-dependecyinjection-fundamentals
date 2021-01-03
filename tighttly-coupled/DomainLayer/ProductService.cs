using System.Collections.Generic;
using System.Linq;

namespace tighttly_coupled
{
    public class ProductService
    {
        private readonly CommerceContext dbContext;

        public ProductService()
        {
            this.dbContext = new CommerceContext();
        }

        public IEnumerable<Product> GetFeaturedProducts(bool isCustomerPreferred)
        {
            decimal discount = isCustomerPreferred ? .95m : 1;

            var featuredProducts = from product in this.dbContext.Products where product.IsFeatured select product;

            return from product in featuredProducts.AsEnumerable()
                select new Product
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    IsFeatured = product.IsFeatured,
                    UnitPrice = product.UnitPrice * discount
                };
        }
    }
}