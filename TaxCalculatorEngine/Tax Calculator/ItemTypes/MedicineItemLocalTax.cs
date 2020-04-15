using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculatorEngine.Product_Description;
using TaxCalculatorEngine.Tax_Calculator.Base;
using TaxCalculatorEngine.TaxConstants;

namespace TaxCalculatorEngine.Tax_Calculator.ItemTypes
{
    public class MedicineItemLocalTax : ITax
    {
        public decimal Calulate_Tax(ProductDescription productDescription)
        {
            return ((TaxCalculatorEngine.TaxConstants.TaxConstants.MedicineLocalTaxPercentage * (productDescription.Price) / 100) +
                productDescription.Price) * productDescription.Quantity;
        }
    }
}
