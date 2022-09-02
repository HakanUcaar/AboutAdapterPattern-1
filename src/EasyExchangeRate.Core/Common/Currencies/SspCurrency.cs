namespace EasyExchangeRate.Core.Common
{
    public class SspCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("SS£", CurrencyCodes.SSP, "728", "South Sudanese pound"));
        }
    }
}
