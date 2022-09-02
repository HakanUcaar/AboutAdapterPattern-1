namespace EasyExchangeRate.Core.Common
{
    public class ScrCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("SCR", CurrencyCodes.SCR, "690", "Seychelles rupee"));
        }
    }
}
