namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Mkd Currency
    /// </summary>
    public class MkdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("ден", CurrencyCodes.MKD, "807", "Macedonian Denar"));
        }
    }
}
