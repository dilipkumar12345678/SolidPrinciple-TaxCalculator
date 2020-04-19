
using TaxCalculatorEngine.Tax_Calculator.ItemTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculatorEngine.Product_Description;
using NUnit.Framework;

namespace TaxCalculatorEngine.Tax_Calculator.ItemTypes.Tests
{
    [TestFixture]
    public class FoodItemLocalTaxTests
    {
        private ProductDescription prd;
        private FoodItemLocalTax foodLoc;
        [SetUp]
        public void Setup()
        {
            prd = new ProductDescription()
            {
                ItemName = "sandwich",
                Quantity = 1,
                Price = 19,
                itemType = ItemType.FoodItemLocalTax,
            };
            foodLoc = new FoodItemLocalTax();


        }
        [Test]
        public void Calulate_TaxTest_withUnitTax()
        {
            TaxConstants.TaxConstants.FoodLocalTaxPercentage = 1;

            var result = foodLoc.Calulate_Tax(prd);

            NUnit.Framework.Assert.AreEqual("19.19", result.ToString());

        }
        [Test]
        public void Calulate_TaxTest_withTenPercentTax()
        {
            TaxConstants.TaxConstants.FoodLocalTaxPercentage = 10;

            var result = foodLoc.Calulate_Tax(prd);

            Assert.AreEqual("20.9", result.ToString());

        }


        [Test]
        public void Calulate_TaxTest_withZeroPercentTax()
        {
            TaxConstants.TaxConstants.FoodLocalTaxPercentage = 0;

            var result = foodLoc.Calulate_Tax(prd);

            Assert.AreEqual("19", result.ToString());
        }
        [Test]
        public void Calulate_TaxTest_withLargeQuantity()
        {
            TaxConstants.TaxConstants.FoodLocalTaxPercentage = 100;

            var result = foodLoc.Calulate_Tax(prd);

            Assert.AreEqual("38", result.ToString());
        }
    }
}