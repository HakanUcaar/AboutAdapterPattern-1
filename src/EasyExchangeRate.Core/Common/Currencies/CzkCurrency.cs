namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Czk Currency
    /// </summary>
    public class CzkCurrency : EasyCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("Kč", CurrencyCodes.CZK, "203", "Czech koruna"));
        }
    }
}
