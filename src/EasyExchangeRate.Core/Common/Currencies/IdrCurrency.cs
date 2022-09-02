namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Idr Currency
    /// </summary>
    public class IdrCurrency 
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("Rp", CurrencyCodes.IDR, "360", "Indonesian Rupiah"));
        }
    }
}
