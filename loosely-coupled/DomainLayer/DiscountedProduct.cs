using System;

namespace loosely_coupled
{
    public class DiscountedProduct
    {
        public string Name { get; }
        
        public decimal UnitPrice { get; }

        public DiscountedProduct(string name, decimal unitPrice)
        {
            if (name == null) throw new ArgumentNullException("name");

            this.Name = name;
            this.UnitPrice = unitPrice;
        }
    }
}