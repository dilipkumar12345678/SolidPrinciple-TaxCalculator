using TaxCalculatorEngine.Tax_Calculator.ItemTypes;
using System;
using TaxCalculatorEngine.Product_Description;
using NUnit.Framework;

namespace TaxCalculatorEngine.Tax_Calculator.ItemTypes.Tests
{
    [TestFixture]
    public class FoodItemImportedTaxTests
    {
        private ProductDescription prd;
        private FoodItemImportedTax foodImp;
        [SetUp]
        public void Setup()
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
        [Test]
        public void Calulate_TaxTest_withUnitQuantity()
        {

            var result = foodImp.Calulate_Tax(prd);
            NUnit.Framework.Assert.AreEqual("18.7", result.ToString());

        }
        [Test]
        public void Calulate_TaxTest_withMoreThanOneQuantity()
        {
            prd.Quantity = 3;
            var result = foodImp.Calulate_Tax(prd);
            Assert.AreEqual("56.1", result.ToString());

        }
        [Test]
        public void Calulate_TaxTest_withZeroQuantity()
        {
            prd.Quantity = 0;
            Assert.Throws<Exception>(() => foodImp.Calulate_Tax(prd));
        }
        [Test]
        public void Calulate_TaxTest_withLargeQuantity()
        {
            prd.Quantity = 0;
            Assert.Throws<Exception>(() => foodImp.Calulate_Tax(prd));
        }
    }
}