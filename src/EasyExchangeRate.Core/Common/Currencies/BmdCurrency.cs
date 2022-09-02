namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Bmd Currency
    /// </summary>
    public class BmdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.BMD, "060", "Bermudian dollar"));
        }
    }
}
