
using TaxCalculatorEngine.Tax_Calculator.ItemTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TaxCalculatorEngine.Product_Description;

namespace TaxCalculatorEngine.Tax_Calculator.ItemTypes.Tests
{
    [TestFixture]
    public class LocalItemTaxTests
    {
        private ProductDescription prd;
        private LocalItemTax LocalItem;
        [SetUp]
        public void Setup()
        {
            prd = new ProductDescription()
            {
                ItemName = "cap",
                Quantity = 1,
                Price = 45,
                itemType = ItemType.LocalItemTax,
            };
            LocalItem = new LocalItemTax();


        }
        [Test]
        public void Calulate_TaxTest_withUnitTax()
        {
            TaxConstants.TaxConstants.LocalItemTaxPercentage = 1;

            var result = LocalItem.Calulate_Tax(prd);

            NUnit.Framework.Assert.AreEqual("45.45", result.ToString());

        }
        [Test]
        public void Calulate_TaxTest_withTenPercentTax()
        {
            TaxConstants.TaxConstants.LocalItemTaxPercentage = 10;

            var result = LocalItem.Calulate_Tax(prd);

            Assert.AreEqual("49.5", result.ToString());

        }


        [Test]
        public void Calulate_TaxTest_withZeroPercentTax()
        {
            TaxConstants.TaxConstants.LocalItemTaxPercentage = 0;

            var result = LocalItem.Calulate_Tax(prd);

            Assert.AreEqual("45", result.ToString());
        }
        [Test]
        public void Calulate_TaxTest_withLargeQuantity()
        {
            TaxConstants.TaxConstants.LocalItemTaxPercentage = 100;

            var result = LocalItem.Calulate_Tax(prd);

            Assert.AreEqual("90", result.ToString());
        }
    }
}