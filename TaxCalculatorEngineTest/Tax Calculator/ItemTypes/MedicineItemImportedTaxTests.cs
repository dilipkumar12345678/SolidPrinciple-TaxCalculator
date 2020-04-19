
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
    public class MedicineItemImportedTaxTests
    {
        private ProductDescription prd;
        private MedicineItemImportedTax MedImpItem;
        [SetUp]
        public void Setup()
        {
            prd = new ProductDescription()
            {
                ItemName = "Imported Medicine",
                Quantity = 2,
                Price = 50,
                itemType = ItemType.MedicineItemImportedTax,
            };
            MedImpItem = new MedicineItemImportedTax();


        }
        [Test]
        public void Calulate_TaxTest_withUnitTax()
        {
            TaxConstants.TaxConstants.MedicineImportedTaxPercentage = 1;

            var result = MedImpItem.Calulate_Tax(prd);

            NUnit.Framework.Assert.AreEqual("101.0", result.ToString());

        }
        [Test]
        public void Calulate_TaxTest_withTenPercentTax()
        {
            TaxConstants.TaxConstants.MedicineImportedTaxPercentage = 10;

            var result = MedImpItem.Calulate_Tax(prd);

            Assert.AreEqual("110", result.ToString());

        }


        [Test]
        public void Calulate_TaxTest_withZeroPercentTax()
        {
            TaxConstants.TaxConstants.MedicineImportedTaxPercentage = 0;

            var result = MedImpItem.Calulate_Tax(prd);

            Assert.AreEqual("100", result.ToString());
        }
        [Test]
        public void Calulate_TaxTest_withLargeQuantity()
        {
            TaxConstants.TaxConstants.MedicineImportedTaxPercentage = 100;

            var result = MedImpItem.Calulate_Tax(prd);

            Assert.AreEqual("200", result.ToString());
        }
    }
}