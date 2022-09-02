namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Uyu Currency
    /// </summary>
    public class UyuCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.UYU, "858", "Uruguayan Peso"));
        }
    }
}
