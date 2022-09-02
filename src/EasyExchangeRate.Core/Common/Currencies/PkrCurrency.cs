namespace EasyExchangeRate.Core.Common
{
    public class PkrCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("Rs", CurrencyCodes.PKR, "586", "Pakistani Rupee"));
        }
    }
}
