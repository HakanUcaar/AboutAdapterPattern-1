namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Brl Currency
    /// </summary>
    public class BrlCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("R$", CurrencyCodes.BRL, "986", "Brazilian real"));
        }
    }
}
