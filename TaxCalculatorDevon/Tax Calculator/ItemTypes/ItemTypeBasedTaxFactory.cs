using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculatorDevon.orders;
using TaxCalculatorDevon.Tax_Calculator.Base;

namespace TaxCalculatorDevon.Tax_Calculator.ItemTypes
{
    class ItemTypeBasedTaxFactory : ITaxFactory
    {
        private ProductDescription _productDescription;
        public ItemTypeBasedTaxFactory(ProductDescription productDescription)
        {
            this._productDescription = productDescription;
        }
        public Tax GetTaxObject()
        {
            Tax tax = null;
            try
            {
                tax = (Tax)Activator.CreateInstance(Type.GetType("TaxCalculatorDevon.Tax_Calculator.ItemTypes." + _productDescription.itemType));
            }
            catch (Exception ex)
            {
                //test
            }
            return tax;
        }
    }
}
