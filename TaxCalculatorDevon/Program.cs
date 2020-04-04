using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Add_ProductDescription(ref book, ref cap, ref sandwich, ref imported_book, ref imported_cap, ref imported_sandwich, ref tee_shirt);

            TotalTax_TotalPrice(book, cap, sandwich);

            Console.ReadLine();

            TotalTax_TotalPrice(imported_book, imported_cap, imported_sandwich, tee_shirt);

            Console.ReadLine();
        }

        public static void Add_ProductDescription(ref ProductDescription product1, ref ProductDescription product2, ref ProductDescription product3, ref ProductDescription product4, ref ProductDescription product5, ref ProductDescription product6, ref ProductDescription product7)
        {
            product1 = new ProductDescription
            {
                ItemName = "book",
                Quantity = 1,
                Price = 17,
                itemType = ItemType.LocalItemTax,

            };

            product2 = new ProductDescription
            {
                ItemName = "cap",
                Quantity = 1,
                Price = 45,
                itemType = ItemType.LocalItemTax,

            };


            product3 = new ProductDescription
            {
                ItemName = "sandwich",
                Quantity = 1,
                Price = 19,
                itemType = ItemType.FoodItemLocalTax,

            };

            product4 = new ProductDescription
            {
                ItemName = "Imported Book",
                Quantity = 1,
                Price = 280,
                itemType = ItemType.ImportedItemTax,

            };

            product5 = new ProductDescription
            {
                ItemName = "Imported Cap",
                Quantity = 2,
                Price = 115,
                itemType = ItemType.ImportedItemTax,

            };
            product6 = new ProductDescription
            {
                ItemName = "Imported Sandwich",
                Quantity = 2,
                Price = 75,
                itemType = ItemType.FoodItemImportedTax,

            };

            product7 = new ProductDescription
            {
                ItemName = "Tee-shirt",
                Quantity = 1,
                Price = 300,
                itemType = ItemType.LocalItemTax,

            };
        }
        public static void TotalTax_TotalPrice(params ProductDescription[] products)
        {
            CalculateTaxForBulkOrders blko = new CalculateTaxForBulkOrders(products);
            decimal[] result = blko.CalculateTax();

            displayTaxeResults(products, result);
        }

        public static void displayTaxeResults(ProductDescription[] products, decimal[] result)
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
