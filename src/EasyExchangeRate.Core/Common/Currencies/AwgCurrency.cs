namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Awg Currency
    /// </summary>
    public class AwgCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("Afl", CurrencyCodes.AUD, "533", "Aruban florin"));
        }
    }
}
