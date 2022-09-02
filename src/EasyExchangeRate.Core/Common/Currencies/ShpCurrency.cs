namespace EasyExchangeRate.Core.Common
{
    public class ShpCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("£", CurrencyCodes.SHP, "654", "Saint Helena pound"));
        }
    }
}
