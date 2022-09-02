namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Uzs Currency
    /// </summary>
    public class UzsCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("сўм", CurrencyCodes.UZS, "860", "Uzbekistani Som"));
        }
    }
}
