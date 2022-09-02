namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Fkp Currency
    /// </summary>
    public class FkpCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("£", CurrencyCodes.FKP, "238", "Falkland Islands pound"));
        }
    }
}
