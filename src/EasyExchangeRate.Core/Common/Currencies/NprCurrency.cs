namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Npr Currency
    /// </summary>
    public class NprCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("रु", CurrencyCodes.NPR, "524", "Nepalese Rupee"));
        }
    }
}
