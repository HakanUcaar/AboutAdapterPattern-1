namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Bgn Currency
    /// </summary>
    public class BgnCurrency : EasyCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("лв.", CurrencyCodes.BGN, "975", "Bulgarian lev"));
        }
    }
}
