namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Hnl Currency
    /// </summary>
    public class HnlCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("L", CurrencyCodes.HNL, "340", "Honduran Lempira"));
        }
    }
}
