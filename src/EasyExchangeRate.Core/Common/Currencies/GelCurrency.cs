namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Gel Currency
    /// </summary>
    public class GelCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("₾", CurrencyCodes.GEL, "981", "Georgian Lari"));
        }
    }
}
