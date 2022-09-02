namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Albanian lek
    /// </summary>
    public class AllCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("L", CurrencyCodes.ALL, "008", "Albanian lek"));
        }
    }
}
