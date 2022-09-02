namespace EasyExchangeRate.Core.Common
{
    public class SdgCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("SDG", CurrencyCodes.SDG, "938", "Sudanese pound"));
        }
    }
}
