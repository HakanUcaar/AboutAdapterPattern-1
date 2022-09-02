namespace EasyExchangeRate.Core.Common
{
    public class SbdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.SBD, "090", "Solomon Islands dollar"));
        }
    }
}
