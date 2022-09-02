namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Gnf Currency
    /// </summary>
    public class GnfCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("FG", CurrencyCodes.GNF, "324", "Guinean franc"));
        }
    }
}
