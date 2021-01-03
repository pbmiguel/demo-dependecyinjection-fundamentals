using System;
using System.Collections.Generic;
using System.Linq;

namespace loosely_coupled.DataAccessLayer
{
    public class SqlProductRepository : IProductRepository
    {
        private readonly CommerceContext _commerceContext;

        public SqlProductRepository(CommerceContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            this._commerceContext = context;
        }
        
        public IEnumerable<Product> GetFeaturedProducts()
        {
            return from product in this._commerceContext.Products where product.IsFeatured select product;
        }
    }
}