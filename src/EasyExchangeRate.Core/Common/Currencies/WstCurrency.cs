namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Wst Currency
    /// </summary>
    public class WstCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("WS$", CurrencyCodes.WST, "882", "Samoan tala"));
        }
    }
}
