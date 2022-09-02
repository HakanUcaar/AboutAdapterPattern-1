namespace EasyExchangeRate.Core.Common
{
    public class TwdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("NT$", CurrencyCodes.TWD, "901", "New Taiwan Dollar"));
        }
    }
}
