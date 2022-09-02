namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Bhd Currency
    /// </summary>
    public class BhdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("د.ب.", CurrencyCodes.BHD, "048", "Bahraini dinar"));
        }
    }
}
