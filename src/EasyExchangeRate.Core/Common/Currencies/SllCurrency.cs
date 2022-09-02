namespace EasyExchangeRate.Core.Common
{
    public class SllCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("Le", CurrencyCodes.SLL, "694", "Sierra Leonean leone"));
        }
    }
}
