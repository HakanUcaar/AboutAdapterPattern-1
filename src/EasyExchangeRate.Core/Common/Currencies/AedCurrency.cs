namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// United Arab Emirates dirham
    /// </summary>
    public class AedCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("د.إ.", CurrencyCodes.AED, "784", "United Arab Emirates dirham"));
        }
    }
}
