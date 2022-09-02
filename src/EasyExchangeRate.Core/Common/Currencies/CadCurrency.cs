namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Cad Currency
    /// </summary>
    public class CadCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.CAD, "124", "Canadian dollar"));
        }
    }
}
