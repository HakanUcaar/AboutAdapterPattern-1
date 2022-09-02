namespace EasyExchangeRate.Core.Common
{
    public class RwfCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("RF", CurrencyCodes.RWF, "646", "Rwandan Franc"));
        }
    }
}
