namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Xof Currency
    /// </summary>
    public class XofCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("CFA", CurrencyCodes.XOF, "952", "West African CFA Franc"));
        }
    }
}
