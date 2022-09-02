namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Lkr Currency
    /// </summary>
    public class LkrCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("රු.", CurrencyCodes.LKR, "144", "Sri Lankan Rupee"));
        }
    }
}
