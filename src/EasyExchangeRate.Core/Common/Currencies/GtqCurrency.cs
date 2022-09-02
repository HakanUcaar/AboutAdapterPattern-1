namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Gtq Currency
    /// </summary>
    public class GtqCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("Q", CurrencyCodes.GTQ, "320", "Guatemalan Quetzal"));
        }
    }
}
