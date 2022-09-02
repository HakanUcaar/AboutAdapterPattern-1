namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Vuv Currency
    /// </summary>
    public class VuvCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("VT", CurrencyCodes.VUV, "548", "Vanuatu vatu"));
        }
    }
}
