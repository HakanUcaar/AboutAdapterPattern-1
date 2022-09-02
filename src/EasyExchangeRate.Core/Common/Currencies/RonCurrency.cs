namespace EasyExchangeRate.Core.Common
{
    public class RonCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("lei", CurrencyCodes.RON, "946", "Romanian Leu"));
        }
    }
}
