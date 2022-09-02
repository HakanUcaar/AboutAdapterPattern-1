namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Vef Currency
    /// </summary>
    public class VefCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("Bs.S", CurrencyCodes.VEF, "937", "Venezuelan bolívar fuerte"));
        }
    }
}
