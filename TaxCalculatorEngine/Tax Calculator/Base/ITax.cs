using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculatorEngine.Product_Description;

namespace TaxCalculatorEngine.Tax_Calculator.Base
{
    public interface ITax
    {
        decimal Calulate_Tax(ProductDescription productDescription);
    }
}
