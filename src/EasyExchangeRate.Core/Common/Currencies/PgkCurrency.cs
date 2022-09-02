namespace EasyExchangeRate.Core.Common
{
    public class PgkCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("K", CurrencyCodes.PGK, "598", "Papua New Guinean kina"));
        }
    }
}
