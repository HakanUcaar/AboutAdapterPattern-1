namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Azn Currency
    /// </summary>
    public class AznCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("₼", CurrencyCodes.AZN, "944", "Azerbaijani manat"));
        }
    }
}
