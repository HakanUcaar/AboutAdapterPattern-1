namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Nzd Currency
    /// </summary>
    public class NzdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.NZD, "554", "New Zealand Dollar"));
        }
    }
}
