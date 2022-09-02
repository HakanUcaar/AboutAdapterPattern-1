namespace EasyExchangeRate.Core.Common
{
    public class PlnCurrency 
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("zł", CurrencyCodes.PLN, "985", "Polish Zloty"));
        }
    }
}
