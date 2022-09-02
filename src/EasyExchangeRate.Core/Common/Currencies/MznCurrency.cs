namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Mzn Currency
    /// </summary>
    public class MznCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("MT", CurrencyCodes.MZN, "943", "Mozambican metical"));
        }
    }
}
