namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Nok Currency
    /// </summary>
    public class NokCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("kr", CurrencyCodes.NOK, "578", "Norwegian Krone"));
        }
    }
}
