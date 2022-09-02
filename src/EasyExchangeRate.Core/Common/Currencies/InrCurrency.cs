namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Inr Currency
    /// </summary>
    public class InrCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("₹", CurrencyCodes.INR, "356", "Indian Rupee"));
        }
    }
}
