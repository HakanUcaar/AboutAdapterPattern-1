namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Byn Currency
    /// </summary>
    public class BynCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("Br", CurrencyCodes.BYN, "933", "Belarusian ruble"));
        }
    }
}
