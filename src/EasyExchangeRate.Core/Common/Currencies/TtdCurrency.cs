namespace EasyExchangeRate.Core.Common
{
    public class TtdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.TTD, "780", "Trinidad and Tobago Dollar"));
        }
    }
}
