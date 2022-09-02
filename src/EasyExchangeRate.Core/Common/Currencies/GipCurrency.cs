namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Gip Currency
    /// </summary>
    public class GipCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("£", CurrencyCodes.GIP, "292", "Gibraltar pound"));
        }
    }
}
