using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculatorDevon.orders;

namespace TaxCalculatorDevon.Input
{
    public class CreateProduct
    {
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
    }
}
