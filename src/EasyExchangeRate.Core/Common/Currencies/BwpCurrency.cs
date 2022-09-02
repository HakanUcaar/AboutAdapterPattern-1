namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Bwp Currency
    /// </summary>
    public class BwpCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("P", CurrencyCodes.BWP, "072", "Botswana pula"));
        }
    }
}
