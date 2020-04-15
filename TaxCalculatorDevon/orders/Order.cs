using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TaxCalculatorEngine.Product_Description;
using TaxCalculatorEngine.Tax_Calculator.Base;
using TaxCalculatorEngine.Tax_Calculator.ItemTypes;
using TaxCalculatorEngine.Tax_Calculator.RoundOff;

namespace TaxCalculatorDevon.orders
{
    public class Order
    {
        public TaxCalculatorEngine.Product_Description.ProductDescription productdesc;
        ITaxFactory _taxfactory;
        
        public Order(TaxCalculatorEngine.Product_Description.ProductDescription product) : this(new ItemTypeBasedTaxFactory(product))
        {
            this.productdesc = product;
        }

        private Order(ITaxFactory taxfactory)
        {
            _taxfactory = taxfactory;
        }
        
        public decimal calculate_PriceAfterTax()
        {
            ITax tax = _taxfactory.GetTaxObject();
            decimal actual_tax = tax.Calulate_Tax(productdesc);
            decimal roundedoff = RoundOff.RoundOffdecimal(actual_tax);

            return roundedoff;
        }


    }
}
