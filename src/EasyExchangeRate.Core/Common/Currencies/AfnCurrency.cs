namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Afghan afghani
    /// </summary>
    public class AfnCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("؋", CurrencyCodes.AFN, "971", "Afghan afghani"));
        }
    }
}
