using System;

namespace tighttly_coupled
{
    public class Product
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsFeatured { get; set; }
    }
}