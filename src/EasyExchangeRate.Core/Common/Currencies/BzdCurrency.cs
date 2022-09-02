namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Bzd Currency
    /// </summary>
    public class BzdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.BZD, "084", "Belize dollar"));
        }
    }
}
