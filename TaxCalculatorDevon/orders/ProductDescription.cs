using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculatorDevon.orders
{
    public class ProductDescription
    {
        public string ItemName { get; set; }
        public ItemType itemType { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal PriceAfterTax { get; set; }
    }
}
