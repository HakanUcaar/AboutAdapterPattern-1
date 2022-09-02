namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Mwk Currency
    /// </summary>
    public class MwkCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("K", CurrencyCodes.MWK, "454", "Malawian kwacha"));
        }
    }
}
