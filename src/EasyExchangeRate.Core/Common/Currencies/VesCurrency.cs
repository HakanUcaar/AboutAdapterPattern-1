namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Ves Currency
    /// </summary>
    public class VesCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("Bs.S", CurrencyCodes.VES, "928", "Venezuelan Bolívar"));
        }
    }
}
