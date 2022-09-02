namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Cve Currency
    /// </summary>
    public class CveCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.CVE, "132", "Cape Verdean escudo"));
        }
    }
}
