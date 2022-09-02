namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Gbp Currency
    /// </summary>
    public class GbpCurrency : EasyCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("£", CurrencyCodes.GBP, "826", "British Pound"));
        }
    }
}
