namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Mmk Currency
    /// </summary>
    public class MmkCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("K", CurrencyCodes.MMK, "104", "Myanmar Kyat"));
        }
    }
}
