namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Kzt Currency
    /// </summary>
    public class KztCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("₸", CurrencyCodes.KZT, "398", "Kazakhstani Tenge"));
        }
    }
}
