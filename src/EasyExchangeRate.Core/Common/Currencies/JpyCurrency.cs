namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Jpy Currency
    /// </summary>
    public class JpyCurrency : EasyCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("¥", CurrencyCodes.JPY, "392", "Japanese Yen"));
        }
    }
}
