using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculatorDevon.display_results;
using TaxCalculatorDevon.Input;
using TaxCalculatorDevon.orders;
using TaxCalculatorEngine.Product_Description;
using TaxCalculatorEngine.TaxConstants;

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

            ReadTaxConstants();

            decimal[] result = null;

            CreateProduct.Add_ProductDescription(ref book, ref cap, ref sandwich, ref imported_book, ref imported_cap, ref imported_sandwich, ref tee_shirt);

            #region Input 1

            result = TotalTax_TotalPrice(book, cap, sandwich);

            DisplayResults.displayTaxeResults(result, book, cap, sandwich);

            #endregion

            Console.ReadLine();

            #region Input 2

            result = TotalTax_TotalPrice(imported_book, imported_cap, imported_sandwich, tee_shirt);

            DisplayResults.displayTaxeResults(result, imported_book, imported_cap, imported_sandwich, tee_shirt);
            #endregion

            Console.ReadLine();
        }


        public static decimal[] TotalTax_TotalPrice(params ProductDescription[] products)
        {
            CalculateTaxForBulkOrders blko = new CalculateTaxForBulkOrders(products);
            return blko.CalculateTax();

        }

        public static void ReadTaxConstants()
        {
            TaxConstants.LocalItemTaxPercentage = Convert.ToInt32(ConfigurationManager.AppSettings["LocalItemTaxPercentage"]);
            TaxConstants.ImportedItemTaxPercentage = Convert.ToInt32(ConfigurationManager.AppSettings["ImportedItemTaxPercentage"]);
            TaxConstants.FoodImportedTaxPercentage = Convert.ToInt32(ConfigurationManager.AppSettings["FoodImportedTaxPercentage"]);
            TaxConstants.MedicineImportedTaxPercentage = Convert.ToInt32(ConfigurationManager.AppSettings["MedicineImportedTaxPercentage"]);
            TaxConstants.FoodLocalTaxPercentage = Convert.ToInt32(ConfigurationManager.AppSettings["FoodLocalTaxPercentage"]);
            TaxConstants.MedicineLocalTaxPercentage = Convert.ToInt32(ConfigurationManager.AppSettings["MedicineLocalTaxPercentage"]);
        }


    }
}
