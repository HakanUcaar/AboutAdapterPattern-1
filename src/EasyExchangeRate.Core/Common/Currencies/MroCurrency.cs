namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Mro Currency
    /// </summary>
    public class MroCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("UM", CurrencyCodes.MRO, "478", "Mauritanian ouguiya"));
        }
    }
}
