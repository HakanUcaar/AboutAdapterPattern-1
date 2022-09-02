namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Ang Currency
    /// </summary>
    public class AngCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("NAƒ", CurrencyCodes.ANG, "532", "Netherlands Antillean guilder"));
        }
    }
}
