namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Top Currency
    /// </summary>
    public class TopCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("T$", CurrencyCodes.TOP, "776", "Tongan paʻanga"));
        }
    }
}
