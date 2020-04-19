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
        public void Calulate_TaxTest_withUnitTax()
        {
            TaxConstants.TaxConstants.FoodImportedTaxPercentage = 1;

            var result = foodImp.Calulate_Tax(prd);
            
            NUnit.Framework.Assert.AreEqual("17.17", result.ToString());

        }
        [Test]
        public void Calulate_TaxTest_withTenPercentTax()
        {
            TaxConstants.TaxConstants.FoodImportedTaxPercentage = 10;

            var result = foodImp.Calulate_Tax(prd);
            
            Assert.AreEqual("18.7", result.ToString());

        }

        
        [Test]
        public void Calulate_TaxTest_withZeroPercentTax()
        {
            TaxConstants.TaxConstants.FoodImportedTaxPercentage = 0;

            var result = foodImp.Calulate_Tax(prd);

            Assert.AreEqual("17", result.ToString());
        }
        [Test]
        public void Calulate_TaxTest_withLargeQuantity()
        {
            TaxConstants.TaxConstants.FoodImportedTaxPercentage = 100;

            var result = foodImp.Calulate_Tax(prd);

            Assert.AreEqual("34", result.ToString());
        }
    }
}