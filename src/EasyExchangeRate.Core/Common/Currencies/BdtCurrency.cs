namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Bdt Currency
    /// </summary>
    public class BdtCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("৳", CurrencyCodes.BDT, "050", "Bangladeshi taka"));
        }
    }
}
