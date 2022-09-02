namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Egp Currency
    /// </summary>
    public class EgpCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("ج.م.", CurrencyCodes.EGP, "818", "Egyptian pound"));
        }
    }
}
