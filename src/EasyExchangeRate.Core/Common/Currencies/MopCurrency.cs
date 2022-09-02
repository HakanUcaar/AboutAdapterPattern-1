namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Mop Currency
    /// </summary>
    public class MopCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("MOP", CurrencyCodes.MOP, "446", "Macanese Pataca"));
        }
    }
}
