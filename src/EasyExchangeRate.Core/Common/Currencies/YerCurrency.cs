namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Yer Currency
    /// </summary>
    public class YerCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("ر.ي.", CurrencyCodes.YER, "886", "Yemeni Rial"));
        }
    }
}
