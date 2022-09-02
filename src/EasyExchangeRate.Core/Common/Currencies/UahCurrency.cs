namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Uah Currency
    /// </summary>
    public class UahCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("₴", CurrencyCodes.UAH, "980", "Ukrainian Hryvnia"));
        }
    }
}
