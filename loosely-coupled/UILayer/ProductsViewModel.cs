using System.Globalization;

namespace loosely_coupled.UILayer
{
    public class ProductsViewModel
    {
        private static CultureInfo PriceCulture = new CultureInfo("en-US");
        
        public string SummaryText { get; }

        public ProductsViewModel(DiscountedProduct product)
        {
            this.SummaryText = string.Format(PriceCulture, "{0} ({1:C})", product.Name, product.UnitPrice);
        }
    }
}