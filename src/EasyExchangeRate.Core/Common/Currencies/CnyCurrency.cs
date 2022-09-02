namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Cny Currency
    /// </summary>
    public class CnyCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("¥", CurrencyCodes.CNY, "156", "Renminbi"));
        }
    }
}
