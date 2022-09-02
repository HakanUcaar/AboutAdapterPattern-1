namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Mnt Currency
    /// </summary>
    public class MntCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("₮", CurrencyCodes.MNT, "496", "Mongolian Tugrik"));
        }
    }
}
