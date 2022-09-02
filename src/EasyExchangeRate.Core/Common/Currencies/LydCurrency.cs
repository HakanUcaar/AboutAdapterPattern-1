namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Lyd Currency
    /// </summary>
    public class LydCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("د.ل.", CurrencyCodes.LYD, "434", "Libyan Dinar"));
        }
    }
}
