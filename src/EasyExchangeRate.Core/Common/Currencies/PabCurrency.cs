namespace EasyExchangeRate.Core.Common
{
    public class PabCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("B/.", CurrencyCodes.PAB, "590", "Panamanian Balboa"));
        }
    }
}
