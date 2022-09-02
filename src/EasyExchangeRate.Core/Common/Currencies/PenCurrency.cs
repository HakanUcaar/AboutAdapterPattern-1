namespace EasyExchangeRate.Core.Common
{
    public class PenCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("S/", CurrencyCodes.PEN, "604", "Peruvian Sol"));
        }
    }
}
