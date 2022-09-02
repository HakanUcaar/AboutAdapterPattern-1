namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Mvr Currency
    /// </summary>
    public class MvrCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("ރ.", CurrencyCodes.MVR, "462", "Maldivian Rufiyaa"));
        }
    }
}
