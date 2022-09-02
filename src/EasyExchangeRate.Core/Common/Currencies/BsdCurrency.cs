namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Bsd Currency
    /// </summary>
    public class BsdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.BSD, "044", "Bahamian dollar"));
        }
    }
}
