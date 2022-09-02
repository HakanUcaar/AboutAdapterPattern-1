namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Cop Currency
    /// </summary>
    public class CopCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.COP, "170", "Colombian peso"));
        }
    }
}
