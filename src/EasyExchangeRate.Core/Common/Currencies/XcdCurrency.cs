namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Xcd Currency
    /// </summary>
    public class XcdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("EC$", CurrencyCodes.XCD, "951", "East Caribbean Dollar"));
        }
    }
}
