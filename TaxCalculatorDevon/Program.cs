using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculatorDevon.display_results;
using TaxCalculatorDevon.Input;
using TaxCalculatorDevon.orders;

namespace TaxCalculatorDevon
{
    class Program
    {
        public static ProductDescription book;
        public static ProductDescription cap;
        public static ProductDescription sandwich;
        public static ProductDescription imported_book;
        public static ProductDescription imported_cap;
        public static ProductDescription imported_sandwich;
        public static ProductDescription tee_shirt;

        static void Main(string[] args)
        {

            CreateProduct.Add_ProductDescription(ref book, ref cap, ref sandwich, ref imported_book, ref imported_cap, ref imported_sandwich, ref tee_shirt);

            TotalTax_TotalPrice(book, cap, sandwich);

            Console.ReadLine();

            TotalTax_TotalPrice(imported_book, imported_cap, imported_sandwich, tee_shirt);

            Console.ReadLine();
        }


        public static void TotalTax_TotalPrice(params ProductDescription[] products)
        {
            CalculateTaxForBulkOrders blko = new CalculateTaxForBulkOrders(products);
            decimal[] result = blko.CalculateTax();

            DisplayResults.displayTaxeResults(products, result);
        }

       
    }
}
