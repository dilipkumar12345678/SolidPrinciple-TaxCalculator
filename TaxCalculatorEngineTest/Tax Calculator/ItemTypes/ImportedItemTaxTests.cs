
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
    public class ImportedItemTaxTests
    {
        private ProductDescription prd;
        private ImportedItemTax ImpItem;
        [SetUp]
        public void Setup()
        {
            prd = new ProductDescription()
            {
                ItemName = "Imported Book",
                Quantity = 1,
                Price = 280,
                itemType = ItemType.ImportedItemTax,
            };
            ImpItem = new ImportedItemTax();


        }
        [Test]
        public void Calulate_TaxTest_withUnitTax()
        {
            TaxConstants.TaxConstants.ImportedItemTaxPercentage = 1;

            var result = ImpItem.Calulate_Tax(prd);

            NUnit.Framework.Assert.AreEqual("282.8", result.ToString());

        }
        [Test]
        public void Calulate_TaxTest_withTenPercentTax()
        {
            TaxConstants.TaxConstants.ImportedItemTaxPercentage = 10;

            var result = ImpItem.Calulate_Tax(prd);

            Assert.AreEqual("308", result.ToString());

        }


        [Test]
        public void Calulate_TaxTest_withZeroPercentTax()
        {
            TaxConstants.TaxConstants.ImportedItemTaxPercentage = 0;

            var result = ImpItem.Calulate_Tax(prd);

            Assert.AreEqual("280", result.ToString());
        }
        [Test]
        public void Calulate_TaxTest_withLargeQuantity()
        {
            TaxConstants.TaxConstants.ImportedItemTaxPercentage = 100;

            var result = ImpItem.Calulate_Tax(prd);

            Assert.AreEqual("560", result.ToString());
        }
    }
}