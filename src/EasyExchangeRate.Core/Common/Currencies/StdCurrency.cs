namespace EasyExchangeRate.Core.Common
{
    public class StdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("Db", CurrencyCodes.STD, "678", "São Tomé and Príncipe dobra"));
        }
    }
}
