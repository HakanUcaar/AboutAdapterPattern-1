namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Aud Currency
    /// </summary>
    public class AudCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.AUD, "036", "Australian dollar"));
        }
    }
}
