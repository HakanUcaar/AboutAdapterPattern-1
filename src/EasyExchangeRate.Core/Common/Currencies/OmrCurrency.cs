namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Omr Currency
    /// </summary>
    public class OmrCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("ر.ع.", CurrencyCodes.OMR, "512", "Omani Rial"));
        }
    }
}
