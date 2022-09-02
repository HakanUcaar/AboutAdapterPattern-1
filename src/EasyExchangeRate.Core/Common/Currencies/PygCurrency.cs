namespace EasyExchangeRate.Core.Common
{
    public class PygCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("₲", CurrencyCodes.PYG, "600", "Paraguayan Guarani"));
        }
    }
}
