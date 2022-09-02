namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Gmd Currency
    /// </summary>
    public class GmdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("D", CurrencyCodes.GMD, "270", "Gambian dalasi"));
        }
    }
}
