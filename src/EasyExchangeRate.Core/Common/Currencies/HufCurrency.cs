namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Huf Currency
    /// </summary>
    public class HufCurrency : EasyCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("Ft", CurrencyCodes.HUF, "348", "Hungarian Forint"));
        }
    }
}
