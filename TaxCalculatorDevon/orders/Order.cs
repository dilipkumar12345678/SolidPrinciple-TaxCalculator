using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculatorDevon.Tax_Calculator.Base;
using TaxCalculatorDevon.Tax_Calculator.ItemTypes;

namespace TaxCalculatorDevon.orders
{
    public class Order
    {
        public ProductDescription productdesc;
        ITaxFactory _taxfactory;

        public Order(ProductDescription product) : this(new ItemTypeBasedTaxFactory(product))
        {
            this.productdesc = product;
        }

        private Order(ITaxFactory taxfactory)
        {
            _taxfactory = taxfactory;
        }
        
        public decimal calculate_PriceAfterTax()
        {
            Tax tax = _taxfactory.GetTaxObject();
            decimal actual_tax = tax.Calulate_Tax(productdesc);
            decimal roundedoff = RoundOff.RoundOffdecimal(actual_tax);

            return roundedoff;
        }


    }
}
