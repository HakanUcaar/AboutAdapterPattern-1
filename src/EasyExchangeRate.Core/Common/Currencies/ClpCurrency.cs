namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Clp Currency
    /// </summary>
    public class ClpCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.CLP, "152", "Chilean peso"));
        }
    }
}
