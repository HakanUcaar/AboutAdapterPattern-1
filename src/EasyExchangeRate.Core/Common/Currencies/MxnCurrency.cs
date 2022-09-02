namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Mxn Currency
    /// </summary>
    public class MxnCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.MXN, "484", "Mexican Peso"));
        }
    }
}
