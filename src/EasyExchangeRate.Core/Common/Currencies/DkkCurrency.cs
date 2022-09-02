namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Dkk Currency
    /// </summary>
    public class DkkCurrency : EasyCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("kr.", CurrencyCodes.DKK, "208", "Danish krone"));
        }
    }
}
