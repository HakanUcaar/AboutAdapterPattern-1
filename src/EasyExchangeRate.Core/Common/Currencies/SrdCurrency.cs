namespace EasyExchangeRate.Core.Common
{
    public class SosCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("S", CurrencyCodes.SOS, "706", "Somali Shilling"));
        }
    }
}
