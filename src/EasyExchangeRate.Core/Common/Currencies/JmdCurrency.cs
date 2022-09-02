namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Jmd Currency
    /// </summary>
    public class JmdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.JMD, "388", "Jamaican Dollar"));
        }
    }
}
