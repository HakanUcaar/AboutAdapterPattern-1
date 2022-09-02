namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Bov Currency
    /// </summary>
    public class BovCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("", CurrencyCodes.BOV, "984", "Bolivian Mvdol (funds code)"));
        }
    }
}
