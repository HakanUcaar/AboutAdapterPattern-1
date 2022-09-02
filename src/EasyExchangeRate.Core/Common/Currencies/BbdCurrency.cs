namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Bbd Currency
    /// </summary>
    public class BbdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.BBD, "052", "Barbadian dollar"));
        }
    }
}
