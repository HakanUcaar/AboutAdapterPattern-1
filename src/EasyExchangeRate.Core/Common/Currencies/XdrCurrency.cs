namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Xdr Currency
    /// </summary>
    public class XdrCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("XDR", CurrencyCodes.XDR, "960", "Special Drawing Rights"));
        }
    }
}
