using System;

namespace loosely_coupled
{
    public class Product
    {
        public String Name { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsFeatured { get; set; }

        public DiscountedProduct ApplyDiscountFor(IUserContext user)
        {
            bool isPreferred = user.IsInRole(Role.PreferredCustomer);

            decimal discount = isPreferred ? .95m : 1.00m;

            return new DiscountedProduct(name: this.Name, unitPrice: this.UnitPrice * discount);
        }
    }
}