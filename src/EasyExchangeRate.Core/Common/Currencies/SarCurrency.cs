namespace EasyExchangeRate.Core.Common
{
    public class SarCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("ر.س.", CurrencyCodes.SAR, "682", "Saudi Riyal"));
        }
    }
}
