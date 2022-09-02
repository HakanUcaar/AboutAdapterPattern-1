namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Zar Currency
    /// </summary>
    public class ZarCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("", CurrencyCodes.XPF, "953", "CFP franc"));
        }
    }
}
