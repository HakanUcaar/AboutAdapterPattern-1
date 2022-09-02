namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Ghs Currency
    /// </summary>
    public class GhsCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("GH₵", CurrencyCodes.GHS, "936", "Ghanaian cedi"));
        }
    }
}
