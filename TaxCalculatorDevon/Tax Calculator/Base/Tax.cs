using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculatorDevon.orders;

namespace TaxCalculatorDevon.Tax_Calculator.Base
{
    public abstract class Tax
    {
        public abstract decimal Calulate_Tax(ProductDescription productDescription);
    }
}
