namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Usd Currency
    /// </summary>
    public class UsdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.USD, "840", "US Dollar"));
        }
    }
}
