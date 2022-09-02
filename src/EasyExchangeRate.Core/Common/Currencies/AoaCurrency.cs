namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Aoa Currency
    /// </summary>
    public class AoaCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("Kz", CurrencyCodes.AOA, "973", "Angolan kwanza"));
        }
    }
}
