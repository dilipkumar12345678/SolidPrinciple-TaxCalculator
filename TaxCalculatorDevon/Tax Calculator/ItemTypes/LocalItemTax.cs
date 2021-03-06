﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculatorDevon.orders;
using TaxCalculatorDevon.Tax_Calculator.Base;

namespace TaxCalculatorDevon.Tax_Calculator.ItemTypes
{
    public class LocalItemTax : Tax
    {
        
        public override decimal Calulate_Tax(ProductDescription productDescription)
        {
            var result = ((TaxConstants.LocalItemTaxPercentage * (productDescription.Price) / 100) +
                 productDescription.Price) * productDescription.Quantity;
            return result;
        }
    }
}
