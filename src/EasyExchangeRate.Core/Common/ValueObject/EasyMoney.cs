using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Core.Common
{
    public class EasyMoney : EasyValueOf<(decimal Amount, EasyCurrency Currency), EasyMoney>
    {
        public override string ToString()
        {
            return $"{Value.Amount}{Value.Currency.Value.Symbol}";
        }

        protected static bool Equal(EasyMoney a, EasyMoney b)
        {
            if (a is null || b is null)
                return false;

            return a.Value.Currency.Value.Symbol == b.Value.Currency.Value.Symbol;
        }


        public static EasyMoney operator + (EasyMoney a, EasyMoney b)
        {
            if (!Equal(a,b))
            {
                throw new NotEqualMoneyCurrencyException();
            }

            return EasyMoney.From(((a.Value.Amount + b.Value.Amount), a.Value.Currency));
        }

        public static EasyMoney operator - (EasyMoney a, EasyMoney b)
        {
            if (!Equal(a, b))
            {
                throw new NotEqualMoneyCurrencyException();
            }

            return EasyMoney.From(((a.Value.Amount - b.Value.Amount), a.Value.Currency));
        }
    }
}
