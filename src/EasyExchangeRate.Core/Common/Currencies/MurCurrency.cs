namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Mur Currency
    /// </summary>
    public class MurCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("₨", CurrencyCodes.MUR, "480", "Mauritian rupee"));
        }
    }
}
