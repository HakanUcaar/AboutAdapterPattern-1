namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Bnd Currency
    /// </summary>
    public class BndCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.BND, "096", "Brunei dollar"));
        }
    }
}
