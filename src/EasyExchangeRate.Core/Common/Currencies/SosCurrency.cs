namespace EasyExchangeRate.Core.Common
{
    public class SrdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.SRD, "968", "Surinamese dollarc"));
        }
    }
}
