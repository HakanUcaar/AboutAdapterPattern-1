namespace EasyExchangeRate.Core.Common
{
    public class SgdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.SGD, "702", "Singapore Dollar"));
        }
    }
}
