namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Iqd Currency
    /// </summary>
    public class IqdCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("د.ع.", CurrencyCodes.IQD, "368", "Iraqi Dinar"));
        }
    }
}
