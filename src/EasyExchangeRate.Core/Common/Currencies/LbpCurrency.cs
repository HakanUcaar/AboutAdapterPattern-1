namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Lbp Currency
    /// </summary>
    public class LbpCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("ل.ل.‏", CurrencyCodes.LBP, "422", "Lebanese Pound"));
        }
    }
}
