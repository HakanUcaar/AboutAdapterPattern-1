namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Syp Currency
    /// </summary>
    public class SypCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("ل.س.‏", CurrencyCodes.SYP, "760", "Syrian Pound"));
        }
    }
}
