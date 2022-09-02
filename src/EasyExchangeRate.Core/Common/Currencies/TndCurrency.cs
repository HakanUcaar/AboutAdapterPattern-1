namespace EasyExchangeRate.Core.Common
{
    public class TndCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("د.ت.", CurrencyCodes.TND, "788", "Tunisian Dinar"));
        }
    }
}
