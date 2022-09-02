namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Fjd Currency
    /// </summary>
    public class FjdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("FJ$", CurrencyCodes.FJD, "242", "Fiji dollar"));
        }
    }
}
