namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Ils Currency
    /// </summary>
    public class IlsCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("₪", CurrencyCodes.ILS, "376", "Israeli New Shekel"));
        }
    }
}
