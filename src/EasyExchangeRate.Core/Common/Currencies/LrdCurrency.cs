namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Lrd Currency
    /// </summary>
    public class LrdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.LRD, "430", "Liberian dollar"));
        }
    }
}
