namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Cdf Currency
    /// </summary>
    public class CdfCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("FC", CurrencyCodes.CDF, "976", "Congolese franc"));
        }
    }
}
