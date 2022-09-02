namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Ars Currency
    /// </summary>
    public class ArsCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.ARS, "032", "Argentine peso"));
        }
    }
}
