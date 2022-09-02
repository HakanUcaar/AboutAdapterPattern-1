namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Cuc Currency
    /// </summary>
    public class CucCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.CUC, "931", "Cuban convertible peso"));
        }
    }
}
