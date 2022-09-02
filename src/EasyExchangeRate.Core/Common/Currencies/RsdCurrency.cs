namespace EasyExchangeRate.Core.Common
{
    public class RsdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("дин.", CurrencyCodes.RSD, "941", "Serbian Dinar"));
        }
    }
}
