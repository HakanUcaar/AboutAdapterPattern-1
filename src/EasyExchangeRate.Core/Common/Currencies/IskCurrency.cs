namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Isk Currency
    /// </summary>
    public class IskCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("kr", CurrencyCodes.ISK, "352", "Icelandic Króna"));
        }
    }
}
