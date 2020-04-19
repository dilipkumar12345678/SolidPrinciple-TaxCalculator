
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
    public class MedicineItemLocalTaxTests
    {
        private ProductDescription prd;
        private MedicineItemLocalTax MedLocItem;
        [SetUp]
        public void Setup()
        {
            prd = new ProductDescription()
            {
                ItemName = "Medicine",
                Quantity = 5,
                Price = 100,
                itemType = ItemType.MedicineItemLocalTax,
            };
            MedLocItem = new MedicineItemLocalTax();


        }
        [Test]
        public void Calulate_TaxTest_withUnitTax()
        {
            TaxConstants.TaxConstants.MedicineImportedTaxPercentage = 1;

            var result = MedLocItem.Calulate_Tax(prd);

            NUnit.Framework.Assert.AreEqual("500", result.ToString());

        }
        [Test]
        public void Calulate_TaxTest_withTenPercentTax()
        {
            TaxConstants.TaxConstants.MedicineImportedTaxPercentage = 10;

            var result = MedLocItem.Calulate_Tax(prd);

            Assert.AreEqual("500", result.ToString());

        }


        [Test]
        public void Calulate_TaxTest_withZeroPercentTax()
        {
            TaxConstants.TaxConstants.MedicineImportedTaxPercentage = 0;

            var result = MedLocItem.Calulate_Tax(prd);

            Assert.AreEqual("500", result.ToString());
        }
        [Test]
        public void Calulate_TaxTest_withLargeQuantity()
        {
            TaxConstants.TaxConstants.MedicineImportedTaxPercentage = 100;

            var result = MedLocItem.Calulate_Tax(prd);

            Assert.AreEqual("500", result.ToString());
        }
    }
}