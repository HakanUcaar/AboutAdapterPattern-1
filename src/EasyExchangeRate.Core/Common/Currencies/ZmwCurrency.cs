namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Zmw Currency
    /// </summary>
    public class ZmwCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("K", CurrencyCodes.ZMW, "967", "Zambian kwacha"));
        }
    }
}
