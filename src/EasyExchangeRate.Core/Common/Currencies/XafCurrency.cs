namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Xaf Currency
    /// </summary>
    public class XafCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("FCFA", CurrencyCodes.XAF, "950", "Central African CFA Franc"));
        }
    }
}
