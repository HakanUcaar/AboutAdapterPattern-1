namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Khr Currency
    /// </summary>
    public class KhrCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("៛", CurrencyCodes.KHR, "116", "Cambodian Riel"));
        }
    }
}
