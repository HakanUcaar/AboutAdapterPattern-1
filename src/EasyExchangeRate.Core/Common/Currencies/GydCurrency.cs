namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Gyd Currency
    /// </summary>
    public class GydCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.GYD, "328", "Guyanese dollar"));
        }
    }
}
