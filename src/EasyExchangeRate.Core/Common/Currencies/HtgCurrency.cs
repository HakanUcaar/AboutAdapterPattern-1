namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Htg Currency
    /// </summary>
    public class HtgCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("G", CurrencyCodes.HTG, "332", "Haitian Gourde"));
        }
    }
}
