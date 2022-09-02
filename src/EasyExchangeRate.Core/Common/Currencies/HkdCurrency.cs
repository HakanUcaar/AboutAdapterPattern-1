namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Hkd Currency
    /// </summary>
    public class HkdCurrency 
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.HKD, "344", "Hong Kong Dollar"));
        }
    }
}
