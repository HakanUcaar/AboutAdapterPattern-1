namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Myr Currency
    /// </summary>
    public class MyrCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("RM", CurrencyCodes.MYR, "458", "Malaysian Ringgit"));
        }
    }
}
