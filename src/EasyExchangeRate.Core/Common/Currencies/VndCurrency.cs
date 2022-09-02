namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Vnd Currency
    /// </summary>
    public class VndCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("₫", CurrencyCodes.VND, "704", "Vietnamese Dong"));
        }
    }
}
