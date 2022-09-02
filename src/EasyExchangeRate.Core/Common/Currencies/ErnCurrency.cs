namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Ern Currency
    /// </summary>
    public class ErnCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("Nfk", CurrencyCodes.ERN, "232", "Eritrean nakfa"));
        }
    }
}
