using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxCalculatorEngine.Tax_Calculator.ItemTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculatorEngine.Product_Description;

namespace TaxCalculatorEngine.Tax_Calculator.ItemTypes.Tests
{
    [TestClass()]
    public class FoodItemImportedTaxTests
    {
        private ProductDescription prd;
        private FoodItemImportedTax foodImp;
        [TestInitialize]
        public void TestInit()
        {
            prd = new ProductDescription()
            {
                ItemName = "Imported Sandwich",
                Quantity = 1,
                Price = 17,
                itemType = ItemType.FoodItemImportedTax,
            };
            foodImp = new FoodItemImportedTax();
        }
        [TestMethod()]
        public void Calulate_TaxTest_withUnitQuantity()
        {

            var result = foodImp.Calulate_Tax(prd);
            Assert.AreEqual("18.7", result.ToString());

        }
        [TestMethod()]
        public void Calulate_TaxTest_withMoreThanOneQuantity()
        {
            prd.Quantity = 3;
            var result = foodImp.Calulate_Tax(prd);
            Assert.AreEqual("56.1", result.ToString());

        }
        [TestMethod()]
        public void Calulate_TaxTest_withZeroQuantity()
        {
            prd.Quantity = 0;
            var result = foodImp.Calulate_Tax(prd);
            //Assert.AreEqual("Quantity should Greater than 0", result.ToString());
           // Assert.AreEqual(typeof(Exception),typeof(res))

        }
    }
}