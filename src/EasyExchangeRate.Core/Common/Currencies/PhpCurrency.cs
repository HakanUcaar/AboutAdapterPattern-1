namespace EasyExchangeRate.Core.Common
{
    public class PhpCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("₱", CurrencyCodes.PHP, "608", "Philippine Piso"));
        }
    }
}
