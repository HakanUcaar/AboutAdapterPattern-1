namespace EasyExchangeRate.Core.Common
{
    public class SekCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("kr", CurrencyCodes.SEK, "752", "Swedish Krona"));
        }
    }
}
