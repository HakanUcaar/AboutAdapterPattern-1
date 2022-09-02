namespace EasyExchangeRate.Core.Common
{
    public class SzlCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("L", CurrencyCodes.SZL, "748", "Swazi lilangeni"));
        }
    }
}
