namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Kgs Currency
    /// </summary>
    public class KgsCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("сом", CurrencyCodes.KGS, "417", "Kyrgystani Som"));
        }
    }
}
