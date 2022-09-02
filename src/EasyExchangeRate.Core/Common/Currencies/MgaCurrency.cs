namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Mga Currency
    /// </summary>
    public class MgaCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("Ar", CurrencyCodes.MGA, "969", "Malagasy ariary"));
        }
    }
}
