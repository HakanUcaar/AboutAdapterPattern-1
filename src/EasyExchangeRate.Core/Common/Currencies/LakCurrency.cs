namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Lak Currency
    /// </summary>
    public class LakCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("₭", CurrencyCodes.LAK, "418", "Laotian Kip"));
        }
    }
}
