using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Core.Common
{
    public class EasyCurrency : EasyValueOf<(string Symbol, CurrencyCodes IsoCode, string NumericCode, string Name), EasyCurrency>
    {
        public override string ToString()
        {
            return Value.Name;
        }
    }
}
