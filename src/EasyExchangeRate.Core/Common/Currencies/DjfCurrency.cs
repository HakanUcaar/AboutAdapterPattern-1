namespace EasyExchangeRate.Core.Common
{
    public class DjfCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("Fdj", CurrencyCodes.DJF, "262", "Djiboutian franc"));
        }
    }
}
