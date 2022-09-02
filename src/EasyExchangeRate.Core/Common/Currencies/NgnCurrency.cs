namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Ngn Currency
    /// </summary>
    public class NgnCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("₦", CurrencyCodes.NGN, "566", "Nigerian Naira"));
        }
    }
}
