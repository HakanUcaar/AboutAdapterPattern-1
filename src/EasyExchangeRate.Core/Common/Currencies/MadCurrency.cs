namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Mad Currency
    /// </summary>
    public class MadCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("د.م.", CurrencyCodes.MAD, "504", "Moroccan Dirham"));
        }
    }
}
