using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculatorDevon.Tax_Calculator.Base
{
    public interface ITaxFactory
    {
        Tax GetTaxObject();
    }
}
