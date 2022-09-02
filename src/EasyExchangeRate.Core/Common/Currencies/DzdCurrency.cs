namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Dzd Currency
    /// </summary>
    public class DzdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("د.ج.", CurrencyCodes.DZD, "012", "Algerian dinar"));
        }
    }
}
