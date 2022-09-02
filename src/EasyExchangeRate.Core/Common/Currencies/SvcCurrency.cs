namespace EasyExchangeRate.Core.Common
{
    public class SvcCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("₡", CurrencyCodes.SVC, "222", "Salvadoran colón"));
        }
    }
}
