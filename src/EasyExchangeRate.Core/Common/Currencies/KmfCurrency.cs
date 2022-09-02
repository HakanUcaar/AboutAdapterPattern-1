namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Kmf Currency
    /// </summary>
    public class KmfCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("CF", CurrencyCodes.KMF, "174", "Comoro franc"));
        }
    }
}
