using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculatorDevon.orders
{
    public class RoundOff
    {
        public static decimal RoundOffdecimal(decimal round)
        {
            decimal extract_decimal = (round - Math.Floor(round)) * 100;

            decimal roundedoff = Math.Floor((extract_decimal + 4) / 5) * 5;

            return Math.Floor(round) + roundedoff/100;

        }
    }
}
