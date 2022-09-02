namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Jod Currency
    /// </summary>
    public class JodCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("د.ا.‏", CurrencyCodes.JOD, "400", "Jordanian Dinar"));
        }
    }
}
