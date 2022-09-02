namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Krw Currency
    /// </summary>
    public class KrwCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("₩", CurrencyCodes.KRW, "410", "South Korean Won"));
        }
    }
}
