using NLog.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculatorEngine.TaxConstants
{
    public class TaxConstants
    {
        public const decimal LocalItemTaxPercentage = 7;
        public const decimal ImportedItemTaxPercentage = 17;
        public const decimal FoodImportedTaxPercentage = 10;
        public const decimal MedicineImportedTaxPercentage = 10;
        public const decimal FoodLocalTaxPercentage = 0;
        public const decimal MedicineLocalTaxPercentage = 0;
        
    }
}
