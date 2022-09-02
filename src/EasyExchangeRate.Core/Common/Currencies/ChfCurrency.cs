namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Chf Currency
    /// </summary>
    public class ChfCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("CHF", CurrencyCodes.CHF, "756", "Swiss franc"));
        }
    }
}
