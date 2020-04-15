using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculatorEngine.Product_Description;
using TaxCalculatorEngine.Tax_Calculator.Base;

namespace TaxCalculatorEngine.Tax_Calculator.ItemTypes
{
    public class ItemTypeBasedTaxFactory : ITaxFactory
    {
        private ProductDescription _productDescription;
        public ItemTypeBasedTaxFactory(ProductDescription productDescription)
        {
            this._productDescription = productDescription;
        }
        public ITax GetTaxObject()
        {
            ITax tax = null;
            try
            {
                tax = (ITax)Activator.CreateInstance(Type.GetType("TaxCalculatorEngine.Tax_Calculator.ItemTypes." + _productDescription.itemType));
            }
            catch (Exception ex)
            {
                //test
            }
            return tax;
        }
    }
}
