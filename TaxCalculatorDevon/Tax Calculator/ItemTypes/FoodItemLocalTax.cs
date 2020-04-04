using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculatorDevon.orders;
using TaxCalculatorDevon.Tax_Calculator.Base;

namespace TaxCalculatorDevon.Tax_Calculator.ItemTypes
{
    public class FoodItemLocalTax : Tax
    {
        public override decimal Calulate_Tax(ProductDescription productDescription)
        {
            return ((TaxConstants.FoodLocalTaxPercentage * (productDescription.Price) / 100) +
                productDescription.Price) * productDescription.Quantity;
        }
    }
}
