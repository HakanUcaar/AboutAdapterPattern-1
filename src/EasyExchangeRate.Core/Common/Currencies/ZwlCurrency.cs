namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Zwl Currency
    /// </summary>
    public class ZwlCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("", CurrencyCodes.ZWL, "932", "Zimbabwean dollar"));
        }
    }
}
