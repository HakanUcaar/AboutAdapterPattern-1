namespace EasyExchangeRate.Core.Common
{
    public class RubCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("₽", CurrencyCodes.RUB, "643", "Russian Ruble"));
        }
    }
}
