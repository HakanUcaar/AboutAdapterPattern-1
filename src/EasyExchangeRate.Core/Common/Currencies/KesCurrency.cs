namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Kes Currency
    /// </summary>
    public class KesCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("Ksh", CurrencyCodes.KES, "404", "Kenyan Shilling"));
        }
    }
}
