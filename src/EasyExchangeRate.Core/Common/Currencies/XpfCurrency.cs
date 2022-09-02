namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Xpf Currency
    /// </summary>
    public class XpfCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("R", CurrencyCodes.ZAR, "710", "South African Rand"));
        }
    }
}
