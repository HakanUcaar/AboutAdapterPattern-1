namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Kwd Currency
    /// </summary>
    public class KwdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("د.ك.", CurrencyCodes.KWD, "414", "Kuwaiti Dinar"));
        }
    }
}
