namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Eur Currency
    /// </summary>
    public class EurCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("€", CurrencyCodes.EUR, "978", "Euro"));
        }
    }
}
