namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Etb Currency
    /// </summary>
    public class EtbCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("ብር", CurrencyCodes.ETB, "230", "Ethiopian birr"));
        }
    }
}
