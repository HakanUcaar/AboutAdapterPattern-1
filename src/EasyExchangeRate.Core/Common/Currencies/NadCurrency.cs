namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Nad Currency
    /// </summary>
    public class NadCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.NAD, "516", "Namibian dollar"));
        }
    }
}
