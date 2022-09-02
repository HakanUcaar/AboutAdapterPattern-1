namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Bob Currency
    /// </summary>
    public class BobCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("Bs", CurrencyCodes.BOB, "068", "Bolivian boliviano"));
        }
    }
}
