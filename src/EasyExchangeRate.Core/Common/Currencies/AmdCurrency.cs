namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Armenian dram
    /// </summary>
    public class AmdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("֏", CurrencyCodes.AMD, "051", "Armenian dram"));
        }
    }
}
