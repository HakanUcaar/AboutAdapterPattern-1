namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Bif Currency
    /// </summary>
    public class BifCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("FBu", CurrencyCodes.BIF, "108", "Burundian franc"));
        }
    }
}
