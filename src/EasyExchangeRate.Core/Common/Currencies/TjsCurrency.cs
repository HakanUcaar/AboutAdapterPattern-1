namespace EasyExchangeRate.Core.Common
{
    public class TjsCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("смн", CurrencyCodes.TJS, "972", "Tajikistani Somoni"));
        }
    }
}
