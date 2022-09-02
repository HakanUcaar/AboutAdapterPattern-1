namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Hrk Currency
    /// </summary>
    public class HrkCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("kn", CurrencyCodes.HRK, "191", "Croatian Kuna"));
        }
    }
}
