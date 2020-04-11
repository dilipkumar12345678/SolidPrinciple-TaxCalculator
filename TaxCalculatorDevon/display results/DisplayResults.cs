using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculatorDevon.orders;

namespace TaxCalculatorDevon.display_results
{
    public class DisplayResults
    {
        public static void displayTaxeResults(decimal[] result,params ProductDescription[] products)
        {
            Console.WriteLine("ItemName" + "\t\t" + "Quantity" + "\t\t" + "Price" + "\t\t" + "PriceAfterTax");
            foreach (var item in products)
            {
                if (item.ItemName.Length > 13)
                    Console.WriteLine(item.ItemName + "\t" + item.Quantity + "\t\t\t" + item.Price + "\t\t\t" + item.PriceAfterTax);
                else if (item.ItemName.Length > 4)
                    Console.WriteLine(item.ItemName + "\t\t" + item.Quantity + "\t\t\t" + item.Price + "\t\t\t" + item.PriceAfterTax);
                else
                    Console.WriteLine(item.ItemName + "\t\t\t" + item.Quantity + "\t\t\t" + item.Price + "\t\t\t" + item.PriceAfterTax);
            }
            Console.WriteLine();
            Console.WriteLine("Total tax =" + result[2]);
            Console.WriteLine("Total amount =" + result[1]);
        }
    }
}
