namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Lsl Currency
    /// </summary>
    public class LslCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("L", CurrencyCodes.LSL, "426", "Lesotho loti"));
        }
    }
}
