using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculatorDevon.orders
{
    public class CalculateTaxForBulkOrders
    {
        public List<ProductDescription> orderlist = new List<ProductDescription>();
        public decimal Total_Price_without_Tax { get; set; }
        public decimal Total_Price_with_Tax { get; set; }
        public CalculateTaxForBulkOrders(params ProductDescription[] products)
        {
            orderlist.AddRange(products);
        }

        public decimal Calculate_total_Price_Without_Tax()
        {
            return Total_Price_without_Tax = orderlist.Sum(x => x.Price);
        }

        public decimal Calculate_total_Price_Tax()
        {
            foreach (var item in orderlist)
            {
                Order ord = new Order(item);
                item.PriceAfterTax = ord.calculate_PriceAfterTax();
            }

            return Total_Price_with_Tax = orderlist.Sum(x => x.PriceAfterTax);
        }

        public decimal[] CalculateTax()
        {
            decimal[] result = new decimal[3];
            result[0] = Calculate_total_Price_Without_Tax();
            result[1] = Calculate_total_Price_Tax();
            result[2] = TaxOnlySum();

            return result;
        }
        public decimal TaxOnlySum()
        {
            return Total_Price_with_Tax - Total_Price_without_Tax;
        }
    }
}
