namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Cup Currency
    /// </summary>
    public class CupCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.CUP, "192", "Cuban peso"));
        }
    }
}
