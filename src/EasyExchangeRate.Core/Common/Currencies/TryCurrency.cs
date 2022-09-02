namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Try Currency
    /// </summary>
    public class TryCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("₺", CurrencyCodes.TRY, "949", "Turkish Lira"));
        }
    }
}
