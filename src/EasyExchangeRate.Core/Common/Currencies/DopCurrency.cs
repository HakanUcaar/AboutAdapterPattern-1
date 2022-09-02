namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Dop Currency
    /// </summary>
    public class DopCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.DOP, "214", "Dominican peso"));
        }
    }
}
