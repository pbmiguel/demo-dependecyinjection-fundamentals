using System;
using System.Collections.Generic;
using System.Linq;

namespace loosely_coupled
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IUserContext _userContext;

        public ProductService(IProductRepository repository, IUserContext userContext)
        {
            if (repository == null || userContext == null)
                throw new ArgumentException("repository or userContext");
            
            this._repository = repository;
            this._userContext = userContext;
        }
        
        public IEnumerable<DiscountedProduct> GetFeaturedProducts()
        {
            return from product in this._repository.GetFeaturedProducts() select product.ApplyDiscountFor(this._userContext);
        }
    }
}