namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Kpw Currency
    /// </summary>
    public class KpwCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("₩", CurrencyCodes.KPW, "408", "North Korean won"));
        }
    }
}
