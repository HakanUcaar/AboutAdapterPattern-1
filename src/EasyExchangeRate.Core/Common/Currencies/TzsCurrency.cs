namespace EasyExchangeRate.Core.Common
{
    public class TzsCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("TSh", CurrencyCodes.TZS, "834", "Tanzanian shilling"));
        }
    }
 }
