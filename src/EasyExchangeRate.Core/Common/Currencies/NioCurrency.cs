namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Nio Currency
    /// </summary>
    public class NioCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("C$", CurrencyCodes.NIO, "558", "Nicaraguan Córdoba"));
        }
    }
}
