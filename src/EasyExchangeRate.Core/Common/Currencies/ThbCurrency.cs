namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Thb Currency
    /// </summary>
    public class ThbCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("฿", CurrencyCodes.THB, "764", "Thai Baht"));
        }
    }
}
